using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CA2MiniProject.Models;

namespace CA2MiniProject.Controllers.webapi
{
    [RoutePrefix("api/Users")]
    public class WebApiController : ApiController
    {
        [HttpGet]
        [Route("GetUsers")]
        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();

            string[] users = { "Carson Alexander","Meredith Alonso", "Arturo Anand", "Gytis Barzdukas" , "Yan Li", "Peggy Justice", "Laura Norman", "Nino Olivetto" };

            foreach (string user in users)
            {
                User currentUser = new User
                {
                    Name = user,
                    Email = user + "@EnergyCalc.com"
                };
                userList.Add(currentUser);
            }
            return userList;
        }

        public class User
        {
            public String Name { get; set; }
            public String Email { get; set; }
        }
    }
}
