using QuanLySanBongDaMiNi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongDaMiNi.DAO
{
    public class SoccerYardDAO
    {
        private static SoccerYardDAO instance;

        public static SoccerYardDAO Instance {
            get {
                if (instance == null)
                {
                    instance = new SoccerYardDAO();
                } 
                return instance;
            }
            private set { instance = value; }
        }
        public static int SoccerYardWidth = 90;
        public static int SoccerYardHeight = 90;
        private SoccerYardDAO() { }

        
        public List<SoccerYard> LoadSoccerYardList()
        {
            List<SoccerYard> soccerYardList = new List<SoccerYard>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetSoccerYardList");

            foreach(DataRow item in data.Rows)
            {
                SoccerYard socceryard = new SoccerYard(item);
                soccerYardList.Add(socceryard);
            }
            return soccerYardList;
        }
    }
}
