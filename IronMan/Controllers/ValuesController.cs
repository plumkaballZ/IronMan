using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Jarvis;
using DukesArchives.warp;

namespace IronMan.Controllers
{
    [Route("MarkIArmor/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class ValuesController : Controller
    {
        //private WARP _warp;

        //public ValuesController()
        //{
        //    _warp = new SqlWarp("data source=DESKTOP-58VSOLT\\SQLEXPRESS; initial catalog = Valhalla; persist security info = True; Integrated Security = SSPI").Buld_WebAsynchronousRequestProcessor();
        //}
        //// GET api/values
        //[HttpGet]
        //public JsonResult Get()
        //{
        //    return Json(_warp.Compute(new dbRequest(new frnWebRequest())));
        //}
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        //[HttpPost]
        //public JsonResult Post([FromBody]frnWebRequest irnWebReq)
        //{
        //    return Json(_warp.Compute(new dbRequest(irnWebReq)));
        //}
        //public JsonResult Put([FromBody]frnWebRequest irnWebReq)
        //{
        //    return Json(_warp.Compute(new dbRequest(irnWebReq)));
        //}
    }
}
