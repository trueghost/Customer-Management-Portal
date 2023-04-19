using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Search.Models;
namespace Search.Controllers
{
    [RoutePrefix("Api/ChangeStatus")]
    public class StatusController : ApiController
    {
        CustomerEntities DB = new CustomerEntities();

        [Route("status")]
        [HttpPost]
        public object status(StatusChange sd)
        {
            var a = DB.ChangeStatus(sd.CustomerId);
            return a;
        }



    }
}