using QuanLiQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Thật Sự Muốn Thoát ?", " Thông Báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false;
            }
        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            string username = TextBoxDangNhap.Text;
            string password = TextBoxMatKhau.Text;
            if (Login(username, password))
            {
                FormMainMenu f = new FormMainMenu();
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Hợp Lệ ! Vui Lòng Kiểm Tra Lại <3");
            }


        }
        bool Login(string username , string password)
        {
            return AccountDAO.Instance.login(username, password);
        }
    }

}
