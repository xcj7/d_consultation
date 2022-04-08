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
    }
}
