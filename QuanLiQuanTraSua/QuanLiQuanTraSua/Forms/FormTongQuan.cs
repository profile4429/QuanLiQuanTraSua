using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using QuanLiTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormTongQuan : Form
    {
        public FormTongQuan()
        {
            InitializeComponent();
            LoadTable();
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLiTraSua.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float TongTien = 0;
            foreach (QuanLiTraSua.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Text = TongTien.ToString("c" , culture);
            textBoxThucDon.Text = TongTien.ToString("c" , culture);

        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;




                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.DeepSkyBlue;
                        btn.ForeColor = Color.Gainsboro;
                        break;

                    default:
                        btn.BackColor = Color.DarkViolet;
                        btn.ForeColor = Color.Gainsboro;
                        break;
                }


                fPanel.Controls.Add(btn);
            }


        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
