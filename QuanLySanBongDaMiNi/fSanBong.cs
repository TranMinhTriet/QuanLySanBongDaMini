using QuanLySanBongDaMiNi.DAO;
using QuanLySanBongDaMiNi.DTO;
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

namespace QuanLySanBongDaMiNi
{
    public partial class fSanBong : Form
    {
        public fSanBong()
        {
            InitializeComponent();
            LoadSoccerYard();
            LoadCategory();
        }

        #region Methods
        void LoadCategory()
        {
            List<Category> catergoryList = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = catergoryList;
            cbCategory.DisplayMember = "LoaiDanhMuc";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "TenThucAn";
        }
        void LoadSoccerYard()
        {
            List<SoccerYard> socceryardList = SoccerYardDAO.Instance.LoadSoccerYardList();

            foreach (SoccerYard item in socceryardList)
            {
                Button btn = new Button() { Width = SoccerYardDAO.SoccerYardWidth, Height = SoccerYardDAO.SoccerYardHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                flpSoccerYard.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLySanBongDaMiNi.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuBySoccerYard(id);
            float totalPrice = 0;
            foreach (QuanLySanBongDaMiNi.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("N0"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("N0"));
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-Vn");
            txtbtotalPrice.Text = totalPrice.ToString("c",culture);
        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int socceryardID = ((sender as Button).Tag as SoccerYard).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(socceryardID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAcountProfile f = new fAcountProfile();
            f.ShowDialog(); 
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            SoccerYard soccerYard = lsvBill.Tag as SoccerYard;
            int billID = BillDAO.Instance.GetUncheckedBillIDbySoccerYardID(soccerYard.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            float count = (float)Convert.ChangeType((numupdownCount.Value).ToString(), typeof(float));

            if (billID == -1)
            {
                BillDAO.Instance.InsertBill(soccerYard.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else 
            {
                BillInfoDAO.Instance.InsertBillInfo(billID, foodID, count);
            }
            ShowBill(soccerYard.ID);
        }
        #endregion
    }
}
