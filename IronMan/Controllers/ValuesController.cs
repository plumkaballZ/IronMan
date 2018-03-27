using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using DukesArchives;

namespace IronMan.Controllers
{
    [Route("MarkIArmor/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class ValuesController : Controller
    {

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json("I am Iron Man");
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public JsonResult Post([FromBody]IronWebRequest irnWebReq)
        {
            return Json("We have a Hulk");
        }

        public JsonResult Put([FromBody]IronWebRequest irnWebReq)
        {
            return Json("We have a Hulk");
        }
    }
}
