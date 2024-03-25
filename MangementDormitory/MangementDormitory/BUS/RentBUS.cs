using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class RentBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Rent> GetData(int contractId)
        {
            return db.Rents.Where(x => x.contractId == contractId).ToList();
        }
        public static int Insert(Rent model)
        {
            if (db.Rents.FirstOrDefault(x => x.contractId == model.contractId && x.monthYear.ToLower().Equals(model.monthYear.ToLower())) != null)
                return 0;
            try
            {
                db.Rents.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static List<Rent> Search(string q = "")
        {
            q = q.ToLower().Trim();
            return db.Rents.Where(x => x.monthYear.ToLower().Contains(q) ||
                                     x.price.ToString().Equals(q) ||
                                     x.dateOfPayment.ToString().Equals(q) ||
                                     x.Staff.name.ToLower().Contains(q)).ToList();
        }
    }
}
