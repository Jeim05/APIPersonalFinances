using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ahorro
    {
        public int IdAhorro { get; set; }
        public Usuario? Usuario { get; set; }
        public string? Nombre { get; set; }
        public string? FechaRegistro { get; set; }
        public decimal Total {  get; set; }
    }
}
