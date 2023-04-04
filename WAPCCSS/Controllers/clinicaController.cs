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
    public class clinicaController : Controller
    {

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(entClinica clinicaD)
        {
            clinicaDAL docdb = new clinicaDAL();
            string resp = docdb.AgregarClinica(clinicaD);

            return View();
        }
        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(entClinica clinicaD)
        {
            clinicaDAL docdb = new clinicaDAL();
            DataTable resp = docdb.BuscarClinica(clinicaD);
            if (resp.Rows.Count > 0)
            {
                return View();
            }
            return View();
        }
    }
}