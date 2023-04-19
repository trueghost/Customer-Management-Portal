using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Search.Models;
namespace Search.Controllers
{
    [RoutePrefix("Api/Searchdata")]
    public class SearchdateController : ApiController
    {
        CustomerEntities DB = new CustomerEntities();
        [Route("showdata")]
        [HttpGet]
        public object showdata()
        {
            var a = DB.CustomerFetch();
            return a;
        }

        [Route("search")]
        [HttpPost]
        public object search(searchdate sd)
        {
            var a = DB.CustomerSearchDate(sd.startdate, sd.enddate);
            return a;
        }
    }
}