using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ContractBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Contract> GetData()
        {
            return db.Contracts.ToList();
        }
        public static int Insert(Contract model)
        {
            if (db.Contracts.FirstOrDefault(x => x.studentCode.Equals(model.studentCode)) != null)
                return 0;
            if (db.Contracts.FirstOrDefault(x => x.roomId == model.roomId) != null)
                return -2;
            try
            {
                db.Contracts.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Update(Contract model)
        {
            var modelUpdate = db.Contracts.SingleOrDefault(x => x.id == model.id);
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.deposit = model.deposit;
                modelUpdate.dateStart = model.dateStart;
                modelUpdate.dateEnd = model.dateEnd;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Delete(int id)
        {

            try
            {
                var model = db.Contracts.SingleOrDefault(x => x.id == id);
                if (new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) <= model.dateEnd)
                    return 0;
                if (model == null)
                    return -1;
                db.Contracts.DeleteOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static List<Contract> Search(string q = "")
        {
            q = q.ToLower().Trim();
            return db.Contracts.Where(x => x.Student.name.ToLower().Contains(q) ||
                                         x.studentCode.ToLower().Equals(q) ||
                                         x.Room.name.ToLower().Contains(q) ||
                                         x.priceActual.ToString().Equals(q) ||
                                         x.deposit.ToString().Equals(q) ||
                                         x.dateStart.ToString().Equals(q) ||
                                         x.dateEnd.ToString().Equals(q)).ToList();
        }
    }
}
