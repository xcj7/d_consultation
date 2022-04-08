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
            var user = db.users.FirstOrDefault(x => x.u_id == id);
            db.users.Remove(user);
           if (db.SaveChanges()!=0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(user obj)
        {
            var user = db.users.FirstOrDefault(x => x.u_id == obj.u_id);
            user.u_status = obj.u_status;
            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
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
