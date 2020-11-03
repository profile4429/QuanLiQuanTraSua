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

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            loadacclist();
        }
        void loadacclist()
        {
            string query = " exec dbo.USP_GetAccountByUserName @userName = N'admin'";
            
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query, new object[] { "amin" });
        }
    }
}
