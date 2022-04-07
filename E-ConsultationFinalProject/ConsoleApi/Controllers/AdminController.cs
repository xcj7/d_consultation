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
    public class UserController : ApiController
    {
        [Route("api/user/Get")]
        public HttpResponseMessage Get()
        {
            var data = AllUserService.Get();
           if(data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "User Empty");
        }
        [Route("api/user/Get")]
        [HttpPost]
        public HttpResponseMessage Add(userModel u)
        {
            AllUserService.Add(u);
            return Request.CreateResponse("User Successsfully Added");
        }
    }
}
