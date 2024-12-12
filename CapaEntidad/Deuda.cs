using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Deuda
    {
        public int IdDeuda { get; set; }
        public Usuario? Usuario { get; set; }
        public Categoria? Categoria { get; set; }
        public string? Fecha { get; set; }
        public string? Detalle { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal MontoPendiente { get; set; }
    }
}
