using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static dpconsultationEntities db = new dpconsultationEntities();
        public static IRepository<user,int> AllUserDataAccess()
        {
            return new AllUserRepo(db);
        }
        public static IRepository<doctor_info,int> DoctorInfoDataAccess()
        {
            return new DoctorInfoRepo(db);
        }
    }
}
