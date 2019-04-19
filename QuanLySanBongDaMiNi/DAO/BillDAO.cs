using QuanLySanBongDaMiNi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return BillDAO.instance;
            } 
            private set => instance = value;
        }
        private BillDAO() { }
        
        public int GetUncheckedBillIDbySoccerYardID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idSanBong = " + id + "AND status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            else
            {
                return -1;
            }
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC USP_INSERTBILL @idSoccerYard", new object[] { id});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) from dbo.Bill");
            }
            catch
            {
                return 1;
            }
            

        }
    }
}
