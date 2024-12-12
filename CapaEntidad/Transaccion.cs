using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Transaccion
    {
        public int IdTransaccion { get; set; }
        public Categoria? Categoria { get; set; }
        public Usuario? Usuario { get; set; }
        public string? Fecha { get; set; }
        public string? Descripcion { get; set; }
        public string? MetodoPago { get; set; }
        public string? TipoTransaccion { get; set; }
        public decimal? Monto { get; set; }

    }
}
