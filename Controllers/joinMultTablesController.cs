using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//add model
using TwoTableWebAPI.Models;


namespace TwoTableWebAPI.Controllers
{
    public class joinMultTablesController : ApiController
    {
        public IHttpActionResult getResults()
        {
            SampleDBEntities sd = new SampleDBEntities();
            List<tb_Country> iCountry = sd.tb_Country.ToList();
            List<tb_City> iCity = sd.tb_City.ToList();

            
            var Query = from c in iCountry
                        join ct in iCity on c.cID equals ct.cID into table
                        from ct in table.DefaultIfEmpty()
                        select new JoinClass1 { getCountry = c, getCity = ct };

            return Ok(Query);



        }
    }
}
