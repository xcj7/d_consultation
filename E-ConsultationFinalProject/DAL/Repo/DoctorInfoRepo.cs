using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DoctorInfoRepo : IRepository<doctor_info, int>
    {
        dpconsultationEntities db;
      public  DoctorInfoRepo (dpconsultationEntities db)
        {
            this.db = db;
        }
        public bool Add(doctor_info obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(doctor_info obj)
        {
            var dr = db.doctor_info.FirstOrDefault(x => x.did == obj.did);
            doctor_info dinfo = new doctor_info()
            {
                d_govid = dr.d_govid,
                d_degree = dr.d_degree,
                d_speciality = dr.d_speciality,
                u_id = dr.u_id
                

            };
        }

        public doctor_info Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<doctor_info> Get()
        {
           return db.doctor_info.ToList();
        }
    }
}
