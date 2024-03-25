using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class StatisticalBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static double Inventory(int year, int month = 0)
        {
            double? money;
            if (month == 0)
                money = db.Rents.Where(x => x.dateOfPayment.Value.Year == year).Sum(x => x.price);
            else
                money = db.Rents.Where(x => x.dateOfPayment.Value.Month == month && x.dateOfPayment.Value.Year == year).Sum(x => x.price);
            return money.HasValue ? money.Value : 0;
        }
        public static List<Room> ListRoomEmpty()
        {
            return db.Rooms.Where(x => x.Contracts.FirstOrDefault(y => y.roomId == x.id) == null).ToList();
        }
        public static DataTable ContractExpired()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("id");
            tb.Columns.Add("room");
            tb.Columns.Add("student");
            tb.Columns.Add("dateEnd");
            var date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var list = db.Contracts.Where(x => date.AddDays(3) >= x.dateEnd);
            foreach(var item in list)
            {
                DataRow dr = tb.NewRow();
                dr[0] = item.id;
                dr[1] = item.Room.name;
                dr[2] = item.Student.name;
                dr[3] = item.dateEnd;
                tb.Rows.Add(dr);
            }
            return tb;
        }

    }
}
