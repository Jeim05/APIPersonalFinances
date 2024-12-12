using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetallePresupuesto
    {
        public int IdDetallePresupuesto { get; set; }
        public Presupuesto? Presupuesto { get; set; }
        public Categoria? Categoria { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoGasto { get; set; }
        public decimal Monto { get; set; }
    }
}
