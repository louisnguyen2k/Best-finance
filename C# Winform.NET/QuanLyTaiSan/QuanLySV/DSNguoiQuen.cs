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
    public partial class DSNguoiQuen : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @root: Form cha mở form hiện tại(TaiKhoan)
        public string IDUser;
        public TaiKhoan root;

        public DSNguoiQuen(string id, TaiKhoan father)
        {
            InitializeComponent();

            IDUser = id;
            root = father;
        }

        private void NguoiQuen_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void llbTroVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            root.showMenu();
            this.Close();
        }
        private void llbThem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemNguoiQuen fr = new ThemNguoiQuen(IDUser);
            fr.ShowDialog();
            fr.Close();
            getData();
        }

        private void dgvNguoiQuen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            string id = dgvDSNguoiQuen.Rows[e.RowIndex].Cells[1].Value.ToString();
            ChiTietNguoiQuen fr = new ChiTietNguoiQuen(id);
            fr.ShowDialog();
            fr.Close();
            getData();
        }

        void getData()
        {
            string select_query = @"SELECT ROW_NUMBER() OVER (ORDER BY ma_nguoi_quen) AS [STT],
                                ma_nguoi_quen,
                                ten_nguoi_quen AS N'Tên người quen',
                                sdt AS N'SDT',
                                dia_chi AS N'Địa chỉ',
                                so_tien AS N'Số tiền'
                                FROM NguoiQuen, TaiKhoan
                                WHERE TaiKhoan.taikhoan = '"+IDUser+"'";

            SqlDataAdapter adapter = new SqlDataAdapter(select_query, DB.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "DSNguoiQuen");
            dgvDSNguoiQuen.DataSource = null;
            dgvDSNguoiQuen.DataSource = ds.Tables["DSNguoiQuen"];

            dgvDSNguoiQuen.Columns[1].Visible = false;
        }


        
    }
}
