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
    public class pacienteController : Controller
    {       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(entPaciente pacienteD)
        {
            pacienteDAL docdb = new pacienteDAL();
            string resp = docdb.AgregarPaciente(pacienteD);

            return View();
        }
        public ActionResult Buscar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(entPaciente pacienteD)
        {
            pacienteDAL docdb = new pacienteDAL();
            DataTable resp = docdb.BuscarPaciente(pacienteD);
            if (resp.Rows.Count > 0)
            {
                return View();
            }
            return View();
        }
    }
}