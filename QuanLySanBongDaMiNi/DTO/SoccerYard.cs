using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class SoccerYard
    {
        public SoccerYard(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public SoccerYard(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        private int iD;
        public int ID
        {
            get => iD;
            set => iD = value;
        }
        private string status;
        public string Status
        {
            get => status;
            set => status = value;
        }


    }
}
