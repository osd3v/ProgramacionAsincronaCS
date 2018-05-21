using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo05.Taller.Servicios;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace Demo05.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Inicio()
        {
            return View();
        }
        List<beProducto> lbeProducto;
        public async Task<string> Listar()
        {
            string rpta = "";
            ProductoClient cProducto = new ProductoClient();
            lbeProducto =await cProducto.ListarAsync();
            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer dcJSON = new DataContractJsonSerializer(typeof(List<beProducto>));
            dcJSON.WriteObject(ms,lbeProducto);
            rpta = Encoding.Default.GetString(ms.ToArray());
            return rpta;


        }
    }
}