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
    public class DoctorInfoService
    {
        public static List<DoctorInfoModel> Get()
        {
            List<DoctorInfoModel> data = new List<DoctorInfoModel>();
           
            var doctor = DataAccessFactory.DoctorInfoDataAccess().Get();
           
            foreach (var u in doctor)
            {
                data.Add(new DoctorInfoModel()
                {
                    d_govid = u.d_govid,
                    d_degree = u.d_degree,
                    d_speciality = u.d_speciality,
                    user = new userModel()
                    {
                       
                        u_name = u.user.u_name,
                        u_username = u.user.u_username,
                        u_password = u.user.u_password,
                        u_address = u.user.u_address,
                        u_email = u.user.u_email,
                        u_phone = u.user.u_phone,
                        u_nid = u.user.u_nid,
                        u_category = u.user.u_category,
                        u_status = u.user.u_status

                    }

                });
            }
            return data;
        }

    }
}
