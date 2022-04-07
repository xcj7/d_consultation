using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AllUserRepo : IRepository<user,int>
    {
         dpconsultationEntities db;
        public AllUserRepo(dpconsultationEntities db)
        {
            this.db = db;
        }

        public bool Add(user obj)
        {
            db.users.Add(obj);
            if(db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(user obj)
        {
            throw new NotImplementedException();
        }

        public user Get(int id)
        {
            return db.users.FirstOrDefault(x => x.u_id == id);
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }
    }
}
