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
namespace QuanLySV
{
    public partial class ChiTietVi : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @IdWallet: ID ví hiện tại
        // @root: Form cha mở form hiện tại (Chứa đối tượng vi)
        // @DicWallets: Dictionary chứa các đối tượng ví của IdUser trừ ví trên form hiện tại
        // @Vi : đối tượng Ví được query từ id được truyền;
        private string IDUser;
        private string IdWallet;
        public UserControlWallets root;
        private Dictionary<string ,CWallet> DicWallets;
        private CWallet Vi;
        
        public ChiTietVi(string id, UserControlWallets father)
        {
            InitializeComponent();

            //
            IDUser = id;
            root = father;
            IdWallet = father.Id;
        }


        private void ChiTietVi_Load(object sender, EventArgs e)
        {
            getData();

            groupBoxInfor.Show();
            panelEditMoney.Hide();
            groupBoxChuyenTien.Hide();


            cbbImgViNhan.DisplayMember = "Name";
            cbbImgViNhan.ValueMember = "Img";
            getDataCBB();

        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.root.showVi();
            this.Close();
        }

        private void btChuyenTien_Click(object sender, EventArgs e)
        {
            groupBoxInfor.Hide();
            groupBoxChuyenTien.Show();
            clearFormChuyenTien();
        }

        private void btDieuChinhSoDu_Click(object sender, EventArgs e)
        {
            tbNewMoney.Text = root.MoneyWallet;
            panelEditMoney.Show();
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            string sotien = tbNewMoney.Text;
            


            DialogResult result = MessageBox.Show("Bạn có muốn lưu kết quả này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                return;
            }

            string query = @"UPDATE VI SET so_tien = " + sotien + " WHERE ma_vi = '" + IdWallet + "'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                DB.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
                return;
            }



            getData();
            panelEditMoney.Hide();
            MessageBox.Show("Lưu thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            panelEditMoney.Hide();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = @"DELETE VI WHERE ma_vi = '"+ IdWallet + "'";
            DB.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB.conn);
                cmd.ExecuteNonQuery();
                DB.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
                return;
            }



            getData();
            panelEditMoney.Hide();
            MessageBox.Show("Xóa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            root.root.showVi();
            this.Close();
        }

        private void linkLabelHuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBoxInfor.Show();
            groupBoxChuyenTien.Hide();
        }

        private void btChuyen_Click(object sender, EventArgs e)
        {
            string sotien = tbSoTienChuyen.Text;
            string ngaychuyentien = dtpNgayChuyen.Value.ToString("MM-dd-yyyy");
            string ghichu = tbGhiChu.Text;

            if (sotien == string.Empty || cbbImgViNhan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập số tiền chuyển và chọn ví nhận!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mavinhan = ((CWallet)cbbImgViNhan.SelectedItem).Id;

            float ftientrongvi = float.Parse(root.MoneyWallet);
            float fsotienchuyen = float.Parse(sotien);
            float ftiendu = ftientrongvi - fsotienchuyen;

            if (ftiendu < 0)
            {
                MessageBox.Show("Số tiền chuyển không được lớn hơn số tiền trong ví!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // thêm vào bảng chuyển tiền
            string query1 = @"INSERT INTO ChuyenTien(ma_vi_chuyen, ma_vi_nhan, so_tien, thoi_gian, ghi_chu)
                                    VALUES('"+ IdWallet + "', '"+ mavinhan + "', "+ sotien + ", '"+ ngaychuyentien + "', N'"+ ghichu + "')";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query1, DB.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chuyển tiền thành công, nhấn OK để đóng giao dịch!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DB.conn.Close();
                getData();
                groupBoxInfor.Show();
                groupBoxChuyenTien.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Chuyển tiền thất bại!, vui lòng thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DB.conn.Close();
            }

        }

        private void tbSoTienChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
                return;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbbImgViNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbImgViNhan.SelectedIndex != -1)
                pbImgViNhan.Image = Image.FromFile("../../icon/" + ((CWallet)cbbImgViNhan.SelectedItem).Img);
        }
       

        /* Lấy dữ liệu từ ví đổ lên List */
        void getData()
        {
            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE ma_vi = "+ IdWallet +"";
            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
                Vi = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
            }
            DB.conn.Close();

            pbImgVi.Image = Vi.getImage();
            lbTenVi.Text = Vi.Name;
            string don_vi_tien = Vi.Type;
            labelTypeEdit.Text = Vi.Type;

            lbSoTien.Text = root.getMoneyStr(Vi.Money) + " " + don_vi_tien;




            if (don_vi_tien == "VND")
            {
                pbImgLoaiTien.Image = Image.FromFile("../../icon/vnd.PNG");
                pbImgLoaiTienChuyen.Image = Image.FromFile("../../icon/vnd.PNG");
            }
            else
            {
                pbImgLoaiTien.Image = Image.FromFile("../../icon/usd.PNG");
                pbImgLoaiTienChuyen.Image = Image.FromFile("../../icon/usd.PNG");
            }
        }


        // lấy dữ liệu các ví từ DB khác với ví hiện tại đổ lên cobobox
        void getDataCBB()
        {
            string query = @"SELECT ma_vi, img, ten_vi, so_tien, don_vi FROM VI
                                WHERE taikhoan = '" + IDUser + "' AND ma_vi != "+ IdWallet + "";

            DB.conn.Open();
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            DicWallets = new Dictionary<string, CWallet>();
            while (rd.Read())
            {
                CWallet wl = new CWallet(rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString(), rd[4].ToString());
                cbbImgViNhan.Items.Add(wl);
                DicWallets[wl.Name] = wl;
            }
            DB.conn.Close();
        }

        // xóa các ô input panel chuyển tiền
        void clearFormChuyenTien()
        {
            tbSoTienChuyen.Text = string.Empty;
            cbbImgViNhan.SelectedIndex = -1;
            tbGhiChu.Text = string.Empty;
            dtpNgayChuyen.Value = DateTime.Today;
        }

        
    }
}
