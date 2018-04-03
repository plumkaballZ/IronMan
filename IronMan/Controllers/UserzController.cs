﻿using DukesArchives;
using DukesArchives.warp;
using Jarvis;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IronMan.Controllers
{
    [Route("MarkIArmor/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class UserzController : Controller
    {
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
        public JsonResult Post([FromBody]warpWebRequest irnWebReq)
        {
            return Json("We have a Hulk");
        }

        public JsonResult Put([FromBody]warpWebRequest irnWebReq)
        {
            return Json("We have a Hulk");
        }
    }
}
