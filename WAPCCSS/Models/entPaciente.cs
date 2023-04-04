using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPCCSS.Models
{
    public class entPaciente
    {
        public int codigo { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public DateTime fechanacimiento { get; set; }
        public Boolean genero { get; set; }
        public string contacto { get; set; }        
        public int pais { get; set; }
        public int provincia { get; set; }
        public int distrito { get; set; }
        public int estadocivil { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fecharegistro { get; set; }
        public string ocupacion { get; set; }

    }
}