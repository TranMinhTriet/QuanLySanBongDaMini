using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int productID, float count) {
            this.ID = id;
            this.BillID = billID;
            this.ProductID = productID;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.ProductID = (int)row["idFood"];
            this.Count = (float)Convert.ChangeType(row["count"].ToString(),typeof(float));
            
        }
        private float count;
        private int productID;
        private int billID;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public float Count { get => count; set => count = value; }
    }
}
