using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.DataServices;

namespace HelloWorld.WebAPI.Controllers
{
    public class BusinessOperationsController : ApiController
    {
        private IBusinessOperations _businessOperations;

        public BusinessOperationsController(
            IBusinessOperations businessOperations)
        {
            _businessOperations = businessOperations;
        }

        [HttpGet]
        [ActionName("GetMessage")]
        public HttpResponseMessage GetMessage()
        {
            try
            {
                var message = _businessOperations.ReturnMessage();

                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, "Unexpected error(s): " + ex.ToString());
            }
        }
    }
}