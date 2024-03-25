using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class StudentBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Student> GetData()
        {
            
            return db.Students.ToList();
        }
        public static int Insert(Student model)
        {
            if (db.Students.FirstOrDefault(x => x.studentCode.ToLower().Equals(model.studentCode.ToLower())) != null)
                return 0;
            try
            {
                db.Students.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Update(Student model)
        {
            var modelUpdate = db.Students.SingleOrDefault(x => x.studentCode.ToLower().Equals(model.studentCode.ToLower()));
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.name = model.name;
                modelUpdate.phone = model.phone;
                modelUpdate.Class = db.Classes.Single(x => x.id == model.classId);
                modelUpdate.classId = model.classId;
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static int Delete(string studentCode)
        {
            try
            {
                var model = db.Students.SingleOrDefault(x => x.studentCode.Equals(studentCode));
                if (model == null)
                    return -1;
                db.Students.DeleteOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static List<Student> Search(string q = "")
        {
            q = q.ToLower().Trim();
            return db.Students.Where(x => x.name.ToLower().Contains(q) ||
                                          x.Class.name.ToLower().Contains(q) ||
                                          x.phone.Equals(q) ||
                                          x.studentCode.ToLower().Equals(q)).ToList();
        }
    }
}
