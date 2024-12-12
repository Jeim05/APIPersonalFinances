using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public Usuario? Usuario { get; set; }
        public string? Fecha { get; set; }
        public string? Nombre { get; set; }
        public decimal Total { get; set; }
    }
}
