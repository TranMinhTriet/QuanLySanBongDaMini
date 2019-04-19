using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class Category
    {
        public Category(int id, string loaiDanhMuc)
        {
            this.ID = id;
            this.LoaiDanhMuc = loaiDanhMuc;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.LoaiDanhMuc = row["LoaiDanhMuc"].ToString();
        }

        private string loaiDanhMuc;
        public string LoaiDanhMuc { get => loaiDanhMuc; set => loaiDanhMuc = value; }
        private int iD;
        public int ID { get => iD; set => iD = value; }

    }
}
