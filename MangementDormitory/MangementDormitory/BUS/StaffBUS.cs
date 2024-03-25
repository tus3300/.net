using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class StaffBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Staff> GetData()
        {
            return db.Staffs.ToList();
        }
        public static int Insert(Staff model)
        {
            if (db.Staffs.SingleOrDefault(x => x.username.ToLower().Equals(model.username.ToLower())) != null)
                return 0;
            try
            {
                model.password = Library.EndCodeMD5("12345");
                db.Staffs.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Update(Staff model)
        {

            var modelUpdate = db.Staffs.SingleOrDefault(x => x.id == model.id);
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.name = model.name;
                modelUpdate.phone = model.phone;
                modelUpdate.note = model.note;
                modelUpdate.Role = db.Roles.Single(x => x.id == model.roleId);
                modelUpdate.roleId = model.roleId;
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
                var model = db.Staffs.SingleOrDefault(x => x.id == id);
                if (model == null)
                    return -1;
                db.Staffs.DeleteOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static List<Staff> Search(string q = "")
        {
            q = q.ToLower().Trim();
            return db.Staffs.Where(x => x.name.ToLower().Contains(q) ||
                                     x.Role.name.ToLower().Contains(q) ||
                                     x.phone.Equals(q) ||
                                     x.note.ToLower().Contains(q)).ToList();
        }
        public static int ResetPassword(int id)
        {

            var modelUpdate = db.Staffs.SingleOrDefault(x => x.id == id);
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.password = Library.EndCodeMD5("12345");
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        /// <summary>
        /// -2: sai mật khẩu
        /// -1: có lỗi xảy ra
        /// 0: xác nhận mật khẩu không giống nhau
        /// 1: thành công
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <param name="prePassword"></param>
        /// <returns>int</returns>
        public static int ChangePassword(int id, string oldPassword, string newPassword, string prePassword)
        {
            oldPassword = Library.EndCodeMD5(oldPassword);
            var modelUpdate = db.Staffs.SingleOrDefault(x => x.id == id && x.password.Equals(oldPassword));
            try
            {
                if (modelUpdate == null)
                    return -2;
                if (!newPassword.Equals(prePassword))
                    return 0;
                modelUpdate.password = Library.EndCodeMD5(newPassword);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static Staff Login(string username, string password)
        {
            password = Library.EndCodeMD5(password);
            var model = db.Staffs.SingleOrDefault(x => x.password.Equals(password) && x.username.Equals(username));
            return model;

        }
    }
}
