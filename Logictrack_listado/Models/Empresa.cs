using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logictrack_listado.Models
{
    public class Empresa
    {
        public int idEmpresaCliente { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String razonSocial { get; set; }
        public String identificacion { get; set; }
        public String departamento { get; set; }
        public String ciudad { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
    }
}