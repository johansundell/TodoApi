using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            var test = new TodoItem[] { new TodoItem{ nummer = 1, text = "test"} };
            var t = test.Append( new TodoItem{nummer = 2, text ="test2" });
            var l = t.ToList();
            l.Add( new TodoItem{ nummer = 3, text = "test3"});
            //test = test.Concat( new [] { new { nummer= 2, text = "test2"}});
            //return new string[] { "sudde1", "sudde2" };
            return l.ToArray();
        }
    }
}