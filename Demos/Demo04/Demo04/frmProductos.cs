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
using Demo04.Taller.Servicios; //ProductoClient

namespace Demo04
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
        public List<beProducto> lbeProducto;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            
        }
        
        private async void LlamadaAsincrona(object sender, EventArgs e)
        {
            ProductoClient oProducto = new ProductoClient();
            lbeProducto = await oProducto.ListarAsync();
            dataGridView1.DataSource = lbeProducto;

        }
    }
}
