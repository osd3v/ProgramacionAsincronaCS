using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace asinDemo01
{
    class daProducto
    {

        public List<beProducto> Listar()
        {
            List<beProducto> lbeProducto = null;
            string stringcon = ConfigurationManager.ConnectionStrings["conNW"].ConnectionString;
            using (SqlConnection cn=new SqlConnection(stringcon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("uspListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (reader!=null)
                {
                    beProducto obeProducto;
                    lbeProducto = new List<beProducto>();
                    int posProductID = reader.GetOrdinal("ProductID");
                    int posProductName= reader.GetOrdinal("ProductName");
                    int posSupplierID = reader.GetOrdinal("SupplierID");
                    int posCategoryID = reader.GetOrdinal("CategoryID");
                    int posUnitPrice = reader.GetOrdinal("UnitPrice");
                    int posUnitsInStock = reader.GetOrdinal("UnitsInStock");
                    while (reader.Read())
                    {
                        obeProducto = new beProducto() {
                            idProducto = reader.GetInt32(posProductID),
                            Nombre = reader.GetString(posProductName),
                            Precio = reader.GetDecimal(posUnitPrice),
                            Stock = reader.GetInt16(posUnitsInStock),
                            idCategoria = reader.GetInt32(posCategoryID),
                            idProveedor = reader.GetInt32(posSupplierID)
                        };


                        lbeProducto.Add(obeProducto);
                    }
                }
            }
            return lbeProducto;
        }
    }
}
