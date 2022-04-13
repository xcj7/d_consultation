using BLL.Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrescriptionService
    {
        public static List<PrescriptionModel> GetPrescription(int id)
        {
            var data = DataAccessFactory.PrescriptionDataAccess().Get().Where(x => x.user.u_id == id);
            List<PrescriptionModel> p = new List<PrescriptionModel>();
            foreach(var v in data)
            {
                p.Add(new PrescriptionModel()
                {
                    pres_medicine = v.pres_medicine,
                    pres_test = v.pres_test,
                    pres_advice = v.pres_advice,
                    patient = new PatientModel()
                    {
                        p_sickness_reason = v.patient.p_sickness_reason,
                        p_diagnostics_info = v.patient.p_diagnostics_info,
                        doc_appoinment = new DoctorAppoinmentModel()
                        {
                            app_fee = v.patient.doc_appoinment.app_fee,
                            doctor_schedule = new DoctorSheduleModel()
                            {
                                schedule_day = v.patient.doc_appoinment.doctor_schedule.schedule_day,
                                schedule_starting_time = v.patient.doc_appoinment.doctor_schedule.schedule_starting_time,
                                schedule_ending_time = v.patient.doc_appoinment.doctor_schedule.schedule_ending_time,
                                doctor_info = new DoctorInfoModel()
                                {
                                    d_degree = v.patient.doc_appoinment.doctor_schedule.doctor_info.d_degree,
                                    d_speciality = v.patient.doc_appoinment.doctor_schedule.doctor_info.d_speciality,
                                    user = new userModel()
                                    {
                                        u_username = v.patient.doc_appoinment.doctor_schedule.doctor_info.user.u_username
                                    }

                                }
                            }
                        }
                    }
                });
            }
            return p;
        }
    }
}
