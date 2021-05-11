using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logictrack_listado.Models
{
    public class Entregas
    {
        public int id { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string encargadoRecepcion { get; set; }
        public string observacion { get; set; }
        public int idDespacho { get; set; }
        public Despacho despacho { get; set; }
    }
}