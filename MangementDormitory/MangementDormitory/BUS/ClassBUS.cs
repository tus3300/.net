using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class ClassBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Class> GetData()
        {
            return db.Classes.ToList();
        }
        public static int Insert(Class model)
        {
            if (db.Classes.FirstOrDefault(x => x.name.ToLower().Equals(model.name.ToLower())) != null)
                return 0;
            try
            {
                db.Classes.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Update(Class model)
        {
            if (db.Classes.FirstOrDefault(x => x.id != model.id && x.name.ToLower().Equals(model.name.ToLower())) != null)
                return 0;
            var modelUpdate = db.Classes.SingleOrDefault(x => x.id == model.id);
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.name = model.name;
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
                var model = db.Classes.SingleOrDefault(x => x.id == id);
                if (model == null)
                    return -1;
                db.Classes.DeleteOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static List<Class> Search(string q="")
        {
            q = q.ToLower().Trim();
            return db.Classes.Where(x=>x.name.ToLower().Contains(q)).ToList();
        }
    }
}
