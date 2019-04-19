using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class Food
    {
        public Food(int id, string tenThucAn, string dvt, int idcategory, float price, string note)
        {
            this.ID = id;
            this.TenThucAn = tenThucAn;
            this.Dvt = dvt;
            this.IDCategory = idcategory;
            this.Price = price;
            this.Note = note;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenThucAn = row["TenThucAn"].ToString();
            this.Dvt = row["dvt"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ChangeType(row["price"].ToString(), typeof(float));
            this.Note = row["Note"].ToString();
        }
        private string note;
        private float price;
        private int iDCategory;
        private string dvt;
        private string tenThucAn;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string TenThucAn { get => tenThucAn; set => tenThucAn = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public float Price { get => price; set => price = value; }
        public string Note { get => note; set => note = value; }
    }
}
