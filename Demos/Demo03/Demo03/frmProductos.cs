using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Demo03.Taller.Servicios; //ProductoClient

namespace Demo03
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void llenardgv(object sender, EventArgs e)
        {


        }
        public List<beProducto> lista;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            
        }
        private void finalizarLlamadaAsincrona(object sender,ListarCompletedEventArgs e)
        {
                lista = e.Result;
            
            MethodInvoker mi = new MethodInvoker(()=> { dataGridView1.DataSource = lista; });
            this.Invoke(mi);
        }

        private void LlamadaAsincrona(object sender, EventArgs e)
        {
            ProductoClient oProducto = new ProductoClient();
            oProducto.ListarAsync();
            oProducto.ListarCompleted += new EventHandler<ListarCompletedEventArgs>(finalizarLlamadaAsincrona);
        }
    }
}
