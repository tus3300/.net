using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class RoleBUS
    {
        private static ManagementDormitoryContextDataContext db = new ManagementDormitoryContextDataContext();
        public static List<Role> GetData()
        {
            return db.Roles.ToList();
        }        
    }
}
