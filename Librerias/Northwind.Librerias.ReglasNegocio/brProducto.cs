using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Librerias.AccesoDatos;
using Northwind.Librerias.EntidadesNegocio;


namespace Northwind.Librerias.ReglasNegocio
{
    public class brProducto
    {
        public List<beProducto> Listar()
        {
            daProducto odaProducto = new daProducto();
            return odaProducto.Listar();
        }
    }
}
