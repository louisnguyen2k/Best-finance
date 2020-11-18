using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLySV
{
    public partial class QuanLyTaiKhoan : Form
    {


        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại
        public string IDUser;
        public TaiKhoan root;

        public QuanLyTaiKhoan(string id, TaiKhoan tk)
        {
            InitializeComponent();
            IDUser = id;
            root = tk;
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            getData();
            panelEditName.Hide();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.showMenu();
            this.Close();
        }

        private void btEditName_Click(object sender, EventArgs e)
        {
            panelEditName.Show();
            tbNewName.Text = lbName.Text;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi tên thành \""+ tbNewName.Text + "\" không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                return;
            }

            string query = "  UPDATE TaiKhoan SET name = N'"+ tbNewName.Text + "' WHERE taikhoan = '"+ IDUser +"'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thay đổi tên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !,\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.conn.Close();
                panelEditName.Hide();
                getData();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panelEditName.Hide();
        }





        private void btThayAnh_Click(object sender, EventArgs e)
        {
            Change_IMG();
        }
        private void btDoiMK_Click(object sender, EventArgs e)
        {
            Open_Change_Passwork();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            root.Logout();
        }





        /* Hàm mở form đổi mật khẩu */
        void Open_Change_Passwork()
        {
            DoiMatKhau dmk = new DoiMatKhau(IDUser);
            dmk.ShowDialog();
            dmk.Close();
        }

        /* Lấy dữ liệu đổ lên form */
        void getData()
        {
            lbName.Text = getName();
            getPicture();
        }





        /* Hàm trả về tên của người dùng theo ID */
        string getName()
        {
            string query = @"SELECT name FROM TaiKhoan
                    WHERE taikhoan = '" + IDUser + "'";
            DB.conn.Open();

            string name = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);

                name = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            DB.conn.Close();

            return name;
        }



        private string nameFile; // Lưu tên file được chọn 
        /*Sự kiện chọn ảnh để thay đổi*/
        void Change_IMG()
        {

            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.InitialDirectory = "C:\Users\Admin\Pictures"; // LOCATION FILE IMG
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn đổi ảnh mới?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    return;
                }
                nameFile = openFile.FileName;
                if (string.IsNullOrEmpty(nameFile))
                    return;
                Image myImage = Image.FromFile(nameFile);
                rpbUser.Image = myImage;
            }
            savePicture();
        }

        /*Query save picture*/
        void savePicture()
        {

            byte[] img = ImageTobByArray(rpbUser.Image);
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE TaiKhoan SET img= @img WHERE taikhoan = @IDUser", DB.conn);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@IDUser", IDUser);
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            DB.conn.Close();
        }
        /*Chuyển ảnh thành byte*/
        byte[] ImageTobByArray(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Jpeg);
            return stream.ToArray();
        }


        /* Load ảnh từ DB lên Form*/
        void getPicture()
        {
            string query = "SELECT img FROM TaiKhoan WHERE taikhoan = '" + IDUser + "'";
            try
            {
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                byte[] link = (byte[])cmd.ExecuteScalar();

                MemoryStream stream = new MemoryStream(link.ToArray());

                Image image = Image.FromStream(stream);
                if (image == null)
                    return;
                rpbUser.Image = image;
            }
            catch (Exception e)
            {
                return;
            }
            finally
            {
                DB.conn.Close();
            }
        }
    }
}
