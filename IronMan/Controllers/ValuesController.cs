using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Jarvis;
using Jarvis.WarpFactroy;
using DukesArchives.web;

namespace IronMan.Controllers
{
    [Route("MarkIArmor/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class ValuesController : Controller
    {
        private WARP _warp;

        public ValuesController()
        {
            _warp = new SqlWarp("data source=DESKTOP-58VSOLT\\SQLEXPRESS; initial catalog = Valhalla; persist security info = True; Integrated Security = SSPI").Buld_WebAsynchronousRequestProcessor();
        }
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_warp.Compute(new WebBckRequest()));
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public JsonResult Post([FromBody]WebFrnRequest irnWebReq)
        {
            return Json(_warp.Compute(new WebBckRequest()));
        }
        public JsonResult Put([FromBody]WebFrnRequest irnWebReq)
        {
            return Json(_warp.Compute(new WebBckRequest()));
        }
    }
}
