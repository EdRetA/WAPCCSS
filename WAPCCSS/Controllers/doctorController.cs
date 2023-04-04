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
    public class doctorController : Controller
    {
                   
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(entDoctor doctorD)
        {
            doctorDAL docdb = new doctorDAL();
            string resp = docdb.AgregarDoctor(doctorD);
                        
            return View();
        }
        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(entDoctor doctorD)
        {
            doctorDAL docdb = new doctorDAL();
            DataTable resp = docdb.BuscarDoctor(doctorD);
            if (resp.Rows.Count>0)
            {
                return View();
            }
            return View();
        }
    }
}