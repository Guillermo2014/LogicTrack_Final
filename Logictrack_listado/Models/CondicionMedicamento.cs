using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logictrack_listado.Models
{
    public class CondicionMedicamento
    {
        public int idCondicionMedicamento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String variableMedicion { get; set; }
        public String unidadMedida { get; set; }
        public Double valorMedida { get; set; }
        public Double valorMinimo { get; set; }
        public Double valorMaximo { get; set; }
        public int idMedicamento { get; set; }
        public Medicamento medicamento { get; set; }
    }
}