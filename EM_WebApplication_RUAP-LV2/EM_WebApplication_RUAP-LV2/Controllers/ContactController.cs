using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EM_WebApplication_RUAP_LV2.Controllers
{
    public class ContactController : ApiController
    {
        public string[] Get()
        {
            return new string[]
            {
        "Hello",
        "World"
            };
        }
    }
}
