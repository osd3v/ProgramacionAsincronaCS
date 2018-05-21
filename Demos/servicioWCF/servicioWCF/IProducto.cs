using Northwind.Librerias.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicioWCF
{
    [ServiceContract]
    public interface IProducto
    {
        [OperationContract]
        List<beProducto> Listar();
    }
}
