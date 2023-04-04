using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPCCSS.Models
{
    public class entDoctor
    {
        public int codigo { get; set; }
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string email { get; set; }
        public int pais { get; set; }
        public int provincia { get; set; }

    }
}