using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Librerias.EntidadesNegocio
{
    public class beProducto
    {
        /// <summary>
        /// Campo, variables
        /// propiedad, métodos de acceso
        /// </summary>
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public int idProveedor { get; set; }
        public int idCategoria { get; set; }
        public decimal Precio { get; set; }
        public short Stock { get; set; }

    }
}
