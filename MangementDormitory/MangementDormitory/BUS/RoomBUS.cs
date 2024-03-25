using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class RoomBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Room> GetData()
        {
            return db.Rooms.ToList();
        }
        public static int Insert(Room model)
        {
            if (db.Rooms.FirstOrDefault(x => x.name.ToLower().Equals(model.name.ToLower())) != null)
                return 0;
            try
            {
                db.Rooms.InsertOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }
        public static int Update(Room model)
        {
            if (db.Rooms.FirstOrDefault(x => x.id != model.id && x.name.ToLower().Equals(model.name.ToLower())) != null)
                return 0;
            var modelUpdate = db.Rooms.SingleOrDefault(x => x.id == model.id);
            try
            {
                if (modelUpdate == null)
                    return -1;
                modelUpdate.name = model.name;
                modelUpdate.area = model.area;
                modelUpdate.numberOfBeds = model.numberOfBeds;
                modelUpdate.price = model.price;
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
                var model = db.Rooms.SingleOrDefault(x => x.id == id);
                if (model == null)
                    return -1;
                db.Rooms.DeleteOnSubmit(model);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public static List<Room> Search(string q = "")
        {
            q = q.ToLower().Trim();
            return db.Rooms.Where(x => x.name.ToLower().Contains(q) ||
                                    x.area.ToString().Equals(q) ||
                                    x.numberOfBeds.ToString().Equals(q) ||
                                    x.price.ToString().Equals(q)).ToList();
        }
        public static Room FindById(int id)
        {
            return db.Rooms.Single(x => x.id == id);
        }
    }
}
