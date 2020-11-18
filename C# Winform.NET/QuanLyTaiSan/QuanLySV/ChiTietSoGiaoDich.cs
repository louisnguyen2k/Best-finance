using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class ChiTietSoGiaoDich : Form
    {
        /*PROPERTY*/
        // @IdUser: ID tài khoản của user đăng nhập thành công.
        // @IDWallet: ID ví cần query
        public string IDUser;
        public string IDWallet;
        DateTime Date;

        public ChiTietSoGiaoDich(string idUser, string idWallet)
        {
            InitializeComponent();
            IDUser = idUser;
            IDWallet = idWallet;
            Date = DateTime.Now;
        }

        private void ChiTietSoGiaoDich_Load(object sender, EventArgs e)
        {
            add_cbbDinhKi();
            rbtMocDinhKi.Checked = true;
            
            
        }



        private void rbt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMocDinhKi.Checked == true)
            {
                gbGiaoDichDinhKi.Enabled = true;
                gbGiaoDichThoiGian.Enabled = false;



                cbbDinhKi.SelectedIndex = 0;

                
            }
            else
            {
                gbGiaoDichDinhKi.Enabled = false;
                gbGiaoDichThoiGian.Enabled = true;
                cbbDinhKi.SelectedIndex = -1;

                string time_start = dtpNgayBatDau.Value.ToString("MM/dd/yyyy");
                string time_end = dtpNgayKetThuc.Value.ToString("MM/dd/yyyy");
                loadForm(time_start, time_end);
            }
        }


        private void cbbDinhKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbDinhKi.SelectedIndex == -1)
            {
                return;
            }
            else if (cbbDinhKi.SelectedIndex == 0) // tất cả
            {
                loadForm("", "");
            }
            else if (cbbDinhKi.SelectedIndex == 1) // hôm nay
            {
                string time = DateTime.Now.ToString("MM/dd/yyyy");
                loadForm(time, "");
            }
            else if (cbbDinhKi.SelectedIndex == 2) // hôm qua
            {
                string time = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
                loadForm(time, "");
            }
            else if (cbbDinhKi.SelectedIndex == 3) // tuần này
            {
                string time_start = Commom.FirstDayOfWeek(DateTime.Now).AddDays(1).ToString("MM/dd/yyyy");
                string time_end = Commom.FirstDayOfWeek(DateTime.Now).AddDays(7).ToString("MM/dd/yyyy");
                loadForm(time_start, time_end);
            }
            else if (cbbDinhKi.SelectedIndex == 4) // tháng này
            {
                string time_start = new DateTime(Date.Year, Date.Month, 1).ToString("MM/dd/yyyy");
                int day_in_month = DateTime.DaysInMonth(Date.Year, Date.Month);
                string time_end = new DateTime(Date.Year, Date.Month, day_in_month).ToString("MM/dd/yyyy");
                loadForm(time_start, time_end);
            }
            else if (cbbDinhKi.SelectedIndex == 5) // Năm nay
            {
                string time_start = new DateTime(Date.Year, 1, 1).ToString("MM/dd/yyyy");
                string time_end = new DateTime(Date.Year, 12, 31).ToString("MM/dd/yyyy");
                loadForm(time_start, time_end);
            }

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            string time_start = dtpNgayBatDau.Value.ToString("MM/dd/yyyy");
            string time_end = dtpNgayKetThuc.Value.ToString("MM/dd/yyyy");
            loadForm(time_start, time_end);
        }


        void add_cbbDinhKi()
        {
            cbbDinhKi.Items.Add("Tất cả giao dịch");
            cbbDinhKi.Items.Add("Hôm nay");
            cbbDinhKi.Items.Add("Hôm qua");
            cbbDinhKi.Items.Add("Tuần này");
            cbbDinhKi.Items.Add("Tháng này");
            cbbDinhKi.Items.Add("Năm nay");
        }

        void loadForm(string start, string end)
        {
            panelLoad.Controls.Clear();
            LichSuGiaoDich fr = new LichSuGiaoDich(IDUser, IDWallet, start, end) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelLoad.Controls.Add(fr);
            fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        
    }
}
