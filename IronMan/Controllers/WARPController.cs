using DukesArchives.warp;
using IronMan.filerz;
using Jarvis;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Seath.masterRepoFactroy;

namespace IronMan.Controllers
{
    [Route("MarkI/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class WARPController : Controller
    {
        private WARP _warp;
        public WARPController()
        {
            _warp = new WARP(new SqlMasterRepo("data source=Goku\\SQLEXPRESS; initial catalog = Valhalla; persist security info = True; Integrated Security = SSPI"));
        }
        [HttpGet]
        public JsonResult Get(warpWebRequest warpRequst)
        {
            if (warpRequst.jsonData == null)
                return Json("I Am IronMan");

            return Json(_warp.Process(JsonConvert.DeserializeObject<warpDBRequest>(warpRequst.jsonData)));
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public JsonResult Post([FromBody]warpWebRequest warpRequst)
        {
            return Json(_warp.Process(warpRequst.dbRequest));
        }
        public JsonResult Put([FromBody]warpWebRequest warpRequst)
        {
            return Json(_warp.Process(warpRequst.dbRequest));
        }
    }
}
