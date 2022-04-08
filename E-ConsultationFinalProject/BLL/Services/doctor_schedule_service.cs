using BLL.Entity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class doctor_schedule_service
    {
        public static List<DoctorSheduleModel> Get()
        {
            var user = DataAccessFactory.DoctorSheduleDataAccess().Get();
            List<DoctorSheduleModel> data = new List<DoctorSheduleModel>();
            foreach (var u in user)
            {
                data.Add(new DoctorSheduleModel()
                {
                    doctor_info = new DoctorInfoModel()
                    {
                       user=new userModel()
                       {
                           u_username=u.doctor_info.user.u_name
                       }
                    },
                    schedule_day = u.schedule_day,
                    schedule_starting_time = u.schedule_starting_time,
                    schedule_ending_time = u.schedule_ending_time
                }) ; 
            }
            return data;
        }
    }
}
