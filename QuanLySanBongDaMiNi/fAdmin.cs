using QuanLySanBongDaMiNi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongDaMiNi
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadCategoryList();
            LoadFoodList();
            LoadSanBongList();
        }

        void LoadAccountList()
        {
            string query = "SELECT username as [Tài khoản] , Displayname as [Tên hiển thị] , PassWord as [Mật khẩu] , Type as [Loại tài khoản]  from dbo.Account";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { });

        }

        void LoadCategoryList()
        {
            string query = "SELECT ID , LoaiDanhMuc as [Loại doanh mục] from dbo.Category";
            dtgvCategory.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { });
        }
        
        void LoadFoodList()
        {
            string query = "SELECT f.ID , f.TenThucAn as [Mặt hàng] , f.dvt as [Đơn vị tính]  , f.price as [Giá tiền] , f.Note as [Ghi chú] from dbo.Food f";
            dtgvProduct.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { });
        }
        
        void LoadSanBongList()
        {
            string query = "SELECT ID , name as [Tên sân bóng] , status as [Trạng thái] from dbo.SanBong";
            dtgvSoccer.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { });
        }
    }
}
