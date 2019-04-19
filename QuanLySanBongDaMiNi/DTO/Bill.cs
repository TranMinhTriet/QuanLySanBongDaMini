using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row) {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var DateCheckOutTemp = row["DateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)DateCheckOutTemp;
            this.Status = (int)row["status"];
        }

        private int status;

        public int Status{
            get => status;
            set => status = value;
        }
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut{
            get => dateCheckOut;
            set => dateCheckOut = value;
        }
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn {
            get => dateCheckIn;
            set => dateCheckIn = value;
        }
        private int iD;

        public int ID{
            get => iD;
            set => iD = value;
        }
        
    }
}
