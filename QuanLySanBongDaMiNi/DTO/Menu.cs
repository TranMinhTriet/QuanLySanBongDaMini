using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class Menu
    {
        public Menu(string foodName, float count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["TenThucAn"].ToString();
            this.Count = (float)Convert.ChangeType(row["count"].ToString(), typeof(float));
            this.Price = (float)Convert.ChangeType(row["price"].ToString(), typeof(float));
            this.TotalPrice = (float)Convert.ChangeType(row["totalPrice"].ToString(), typeof(float));
        }
        private float totalPrice;
        private float price;
        private float count;
        private string foodName;

        public string FoodName { get => foodName; set => foodName = value; }
        public float Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
