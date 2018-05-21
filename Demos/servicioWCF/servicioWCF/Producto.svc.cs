using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Northwind.Librerias.EntidadesNegocio;
using Northwind.Librerias.ReglasNegocio;
namespace servicioWCF
{
    public class Producto : IProducto
    {
        List<beProducto> IProducto.Listar()
        {

            brProducto obrProducto = new brProducto();
            List<beProducto> lbeProducto = obrProducto.Listar();
            return lbeProducto;
        }

        
    }

}
