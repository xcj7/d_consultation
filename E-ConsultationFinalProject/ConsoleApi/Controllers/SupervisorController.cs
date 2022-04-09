using BLL.Entity;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ConsoleApi.Controllers
{
    public class SupervisorController : ApiController
    {
        [Route("api/Supervisor/Get")]
        
        public HttpResponseMessage GetPatientConsultation()
        {
            var data = doctor_schedule_service.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Supervisor/AddSchedule")]
        [HttpPost]
        public HttpResponseMessage AddSchedule(DoctorSheduleModel ds)
        {
            doctor_schedule_service.Add(ds);
            return Request.CreateResponse("Schedule Successsfully Added");
        }
        [Route("api/Admin/EditSchedule/{id}")]
        [HttpPost]
        public HttpResponseMessage EditSchedule(DoctorSheduleModel model, int id)
        {
            doctor_schedule_service.EditUserStatus(model, id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
