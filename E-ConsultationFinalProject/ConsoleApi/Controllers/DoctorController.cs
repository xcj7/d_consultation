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
    public class DoctorController : ApiController
    {
        [Route("api/Doctor/Get")]
        public HttpResponseMessage Get()
        {
            var data = AllUserService.Get();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "User Empty");
        }
        [Route("api/Doctor/Add")]
        [HttpPost]
        public HttpResponseMessage Add(userModel u)
        {
            AllUserService.Add(u);
            return Request.CreateResponse("User Successsfully Added");
        }
        [Route("api/Doctor/GetDoctor")]
        public HttpResponseMessage GetDoctor()
        {
            var data = DoctorInfoService.Get();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }






     //ok
        [Route("api/Doctor/EditDoctor/{id}")]
        [HttpPost]
        public HttpResponseMessage EditDoctor(ConsultationModel model, int id)
        {
           ConsultationService.Edit(model, id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }




    //ok
       
        [Route("api/Doctor/Consultation_StatusChange/{id}")]
        [HttpPost]
        public HttpResponseMessage Consultation_StatusChange(ConsultationModel u, int id)
        {
            ConsultationService.EditConsultationStatus(u, id);
            return Request.CreateResponse("Successfuly Status Changed");
        }



    //ok
        [Route("api/Doctor/SearchPatient")]
        [HttpPost]
        public HttpResponseMessage SearchPatient(ConsultationModel model)
        {
            var data = ConsultationService.SearchPatient(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

//ok

//search shedule 
        [Route("api/Doctor/Searchshedule")]
        [HttpPost]
        public HttpResponseMessage Searchshedule(DoctorSheduleModel model)
        {
            var data = ConsultationService.Searchshedule(model);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //search patient per day
        [Route("api/Doctor/SearchPatientperDay")]
        [HttpPost]
        public HttpResponseMessage SearchPatientperDay(Date_StatusModel obj)
        {
            var data = ConsultationService.SearchPatientperDay(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



    }
}
