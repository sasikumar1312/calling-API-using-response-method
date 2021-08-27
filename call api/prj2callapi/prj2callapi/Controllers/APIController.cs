using MaheApi.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prj2callapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        public List<string> StateIndex()
        {
            var responseString = ApiCall.GetApi("https://localhost:44335/Web");
            var rootobject = new JavaScriptSerializer().Deserialize<List<string>>(responseString);
            return rootobject;
        }
    }
}
