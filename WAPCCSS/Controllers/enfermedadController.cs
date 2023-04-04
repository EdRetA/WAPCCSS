using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using WAPCCSS.Models;

namespace WAPCCSS.Controllers
{
    public class enfermedadController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(entEnfermedad enfermedadD)
        {
            enfermedadDAL docdb = new enfermedadDAL();
            string resp = docdb.AgregarEnfermedad(enfermedadD);
                        
            return View();
        }
       
    }
}