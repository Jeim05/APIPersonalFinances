using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CategoriaData
    {
        private readonly ConnectionStrings conexiones;

        public CategoriaData(IOptions<ConnectionStrings> options)
        {
            conexiones = options.Value;
        }

        public async Task<List<Categoria>> Lista()
        {
            List<Categoria> categorias = new List<Categoria>();
        } 
    }
}
