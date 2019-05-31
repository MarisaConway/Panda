using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pandas.Models;

namespace Pandas.Controllers
{
    public class PandaController : Controller
    {
        private PandaContext context;
        public PandaController(PandaContext dbcontext)
        {
            context = dbcontext;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Pandas = context.Pandas;
            return View();
        }
        [Route("new")]
        [HttpGet]
        public IActionResult New ()
        {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public IActionResult Create (Panda p)
        {
            if(ModelState.IsValid)
            {
                context.Create(p);
            }
            return Redirect("/");
        }
        [Route("panda/{PandaId}")]
        [HttpGet]
        public IActionResult Edit(int PandaId)
        {
            return View(context.GetPandaById(PandaId));
        }
        [Route("update/{PandaId}")]
        [HttpPost]
        public IActionResult Update(int PandaId, Panda p)
        {
            context.Update(p);
            return Redirect("/");
        }
        [Route("delete/{PandaId}")]
        [HttpPost]
        public IActionResult Delete(int PandaId)
        {
            context.DeleteById(PandaId);
            return Redirect("/");
        }


    }
}
