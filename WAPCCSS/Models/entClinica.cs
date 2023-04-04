using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPCCSS.Models
{
    public class entClinica
    {
        public int codigo { get; set; }
        public int cedula { get; set; }
        public string nombre { get; set; }
        public int pais { get; set; }
        public int provincia { get; set; }
        public int distrito { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string sitioweb { get; set; }

    }
}