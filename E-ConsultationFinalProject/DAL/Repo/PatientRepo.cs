using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PatientRepo : IRepository<patient, int>
    {
        dpconsultationEntities db;
        public PatientRepo(dpconsultationEntities db)
        {
            this.db = db;
        }
        public bool Add(patient obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(patient obj)
        {
            throw new NotImplementedException();
        }

        public bool EditDelete(patient obj)
        {
            var data = db.patients.FirstOrDefault(x => x.p_id == obj.p_id);
            data.isdeleted = obj.isdeleted;
            if(db.SaveChanges()!=0)
            {
                return true;
            }
            return false;
            
        }

        public bool EditStatus(patient obj)
        {
            throw new NotImplementedException();
        }

        public patient Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<patient> Get()
        {
            return db.patients.ToList();
        }
    }
}
