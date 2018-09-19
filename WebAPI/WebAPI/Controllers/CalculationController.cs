using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CalculationController : ApiController
    {
        [HttpGet]
        [Route("api/1.0/Sum")]
        ///rnd1={0}&rnd2={1}  
        public int Sum(int rnd1, int rnd2)
        {
            return rnd1 + rnd2 + 1;
        }

    }
}
