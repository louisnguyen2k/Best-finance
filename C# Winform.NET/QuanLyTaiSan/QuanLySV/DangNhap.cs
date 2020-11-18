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



namespace QuanLySV
{
    public partial class DangNhap : Form
    {
        /*MACRO*/
        // @LOGIN_FAILED : trạng thái đăng nhập thất bại
        // @LOGIN_SUCCESS : trạng thái đăng nhập thành công
        // @EXIT : Trạng thái thoát khỏi chương trình
        // @LOGOUT : Trạng thái đăng xuất tài khoản
        public static int LOGIN_FAILED = -1;
        public static int LOGIN_SUCCESS = 1;
        public static int EXIT = 2;
        public static int LOGOUT = 3;

        /*PROPERTY*/
        // @LoginResult: Trạng thái đăng nhập, nhận 1 trong 3 giá trị được MACRO ở trên
        // @IDUser: Tên tài khoản của user đăng nhập thành công.
        public int LoginResult;
        public string IDUser;
        /*---------------------------------------------------------------------*/
        /* Hàm khởi tạo form */
        public DangNhap()
        {
            LoginResult = LOGIN_FAILED; // Khởi tạo trạng thái đăng nhập là thất bại, chưa đăng nhập (LOGIN_FAILED = -1)
            IDUser = string.Empty; // Khởi tạo tên tài khoản của user đăng nhập bằng EMPTY
            InitializeComponent();
        }

        /* Sự kiện click button đăng nhập */
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string tk = tbTaiKhoan.Text;
            string mk = tbMatKhau.Text;


            if (tk == string.Empty && mk == string.Empty) // CASE-LV1: Tài khoản và mật khẩu EMPTY
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!");
            }
            else if(tk == string.Empty) //CASE-LV1: Tài khoản EMPTY
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (mk == string.Empty) //CASE-LV1: mật khẩu EMPTY
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else //CASE-LV1: Tài khoản và mật khẩu đầy đủ
            {
                // query tài khoản có tồn tại trong DB hay không
                string query = @"SELECT COUNT(*) FROM TaiKhoan
                        WHERE taikhoan = '" + tk + "'";
                DB.conn.Open();
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                int result;
                try
                {
                    result = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }catch(Exception ex)
                {
                    MessageBox.Show("Kết nối tới DataBase có vấn đề, vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.conn.Close();
                    return;
                }

                DB.conn.Close();


                if(result == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                query = @"SELECT matkhau FROM TaiKhoan
                            WHERE taikhoan = '" + tk + "'";
                DB.conn.Open();
                cmd = new SqlCommand(query, DB.conn);
                string mkQuery;
                try
                {
                    mkQuery = cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối tới DataBase có vấn đề, vui lòng thử lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.conn.Close();
                    return;
                }

                DB.conn.Close();


                if (mkQuery.Trim() == mk)
                {
                    this.IDUser = tk;
                    this.LoginResult = LOGIN_SUCCESS; // Ghi nhận trạng thái đăng nhập thành công
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMatKhau.Text = string.Empty;
                }
            }


            if (cbLuuTaiKhoan.Checked) // CASE-LV1: Nếu combobox lưu tài khoản được check khi đăng nhập thì ghi file
            {
                Write_file(tbTaiKhoan.Text, tbMatKhau.Text); // Gọi hàm ghi file
            }
            else /* Ngược lại không ghi file */
            {
                Write_file(); // Gọi hàm ghi file không đối số (Ngầm định "", "")
            }
            


            if (this.LoginResult != LOGIN_FAILED) // CASE-LV1: Kiểm tra đăng nhập có thành công không, nếu có thì đóng form đăng nhập lại
            {
                this.Close();
            }

        }

        /* Sự kiện click button thoát */
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginResult = LOGIN_FAILED; // Ghi nhận trạng thái đăng nhập thất bại
                this.Close();
            }
        }

        /* Sự kiện click vào checkbox hiển thị mật khẩu */
        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked) // CASE: hiển thị mật khẩu
            {
                tbMatKhau.UseSystemPasswordChar = false;
            }
            else // CASE: Ẩn mật khẩu thành kí tự (*)
            {
                tbMatKhau.UseSystemPasswordChar = true;
            }
        }

        /* Sự kiện form đăng nhập load */
        private void DangNhap_Load(object sender, EventArgs e)
        {
            string tk = "";
            string mk = "";
            /* Đọc tk và mk từ file */
            Read_file(ref tk, ref mk);
            if(tk != string.Empty || mk != string.Empty) //CASE-LV1: Nếu tk và mk được đọc từ file lên ko rỗng (Thành công)
            {
                cbLuuTaiKhoan.Checked = true;
            }
            tbTaiKhoan.Text = tk;
            tbMatKhau.Text = mk;
            /**/
            tbMatKhau.UseSystemPasswordChar = true; // Ẩn mật khẩu thành kí tự (*)
        }

        // Sự kiện click link lable đăng kí tài khoản
        private void llbDangKiTaiKhoan_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKiTaiKhoan dktk = new DangKiTaiKhoan();
            this.Hide();
            dktk.ShowDialog();
            dktk.Close();
            this.Show();
        }


        /*----------------Hàm sử lý các sự kiện----------------*/

        /* Đọc tài khoản và mật khẩu từ file (binary) */
        void Read_file(ref string tk, ref string mk)
        {
            BinaryReader br;
            string filePath = "../../file-txt/user-passwork.dat";
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream(filePath, FileMode.Open));
                tk = br.ReadString(); // Gán string vừa đọc đầu tiên cho tk
                mk = br.ReadString(); // Gán string vừa đọc thứ hai cho mk
            }
            catch (IOException e) // Đọc file thất bại
            {
                tk = string.Empty; // Gán tk = EMPTY
                mk = string.Empty; // Gán mk = EMPTY
                return;
            }
            br.Close();
        }

        /* Ghi tài khoản và mật khẩu xuống file (binary) */
        void Write_file(string tk = "", string mk = "")
        {
            BinaryWriter bw;
            string filePath = "../../file-txt/user-passwork.dat";
            // writing into the file
            try
            {
                bw = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate));
                bw.Write(tk); // Ghi tk xuống file đầu tiên
                bw.Write(mk); // Ghi mk xuống file thứ hai
            }
            catch (IOException e)
            {
                return;
            }
            bw.Close();
        }
    }
}
