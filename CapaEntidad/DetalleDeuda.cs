using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleDeuda
    {
        public int IdDetalleDeuda { get; set; }
        public Deuda? Deuda { get; set; }
        public string? Descripcion { get; set; }
        public decimal Monto { get; set; }
    }
}
