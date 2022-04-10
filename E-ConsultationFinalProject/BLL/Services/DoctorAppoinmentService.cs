using BLL.Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorAppoinmentService
    {
        public static DoctorAppoinmentModel GetDoctorAppoinmentForPatient(int id)
        {
            var data = DataAccessFactory.DoctorAppoinmentDataAccess().Get(id);
            DoctorAppoinmentModel model = new DoctorAppoinmentModel() {
                app_fee = data.app_fee,
               app_id = data.app_id,
               schedule_id = data.schedule_id,
               
            };
            return model;
            
        }
    }
}
