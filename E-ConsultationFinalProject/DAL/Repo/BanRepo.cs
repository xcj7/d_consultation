using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class BanRepo : IRepository<ban, int>
    {
        dpconsultationEntities db;
        public BanRepo(dpconsultationEntities db)
        {
            this.db = db;
        }
        public bool Add(ban obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ban obj)
        {
            throw new NotImplementedException();
        }

        public bool EditDelete(ban obj)
        {
            throw new NotImplementedException();
        }

        public bool EditStatus(ban obj)
        {
            throw new NotImplementedException();
        }

        public ban Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ban> Get()
        {
            return db.bans.ToList();
        }
    }
}
