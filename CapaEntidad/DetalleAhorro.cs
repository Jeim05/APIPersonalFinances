using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleAhorro
    {
        public int IdDetalleAhorro {  get; set; }
        public Ahorro? Ahorro { get; set; }
        public string? Descripcion { get; set; }
        public decimal Monto { get; set; }
    }
}
