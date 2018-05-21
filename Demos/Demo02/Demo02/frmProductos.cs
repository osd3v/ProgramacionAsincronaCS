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
using Northwind.Librerias.ReglasNegocio;
using Northwind.Librerias.EntidadesNegocio;

namespace Demo02
{
    public partial class frmProductos : Form
    {
        brProducto obrProducto;
        delegate List<beProducto> Delegado();
        List<beProducto> lista;
        Delegado objDelegado;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void llenardgv(object sender, EventArgs e)
        {


        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            obrProducto = new brProducto();
            objDelegado = new Delegado(obrProducto.Listar);
            AsyncCallback acb = new AsyncCallback(finLlamadaAsincrona);
            objDelegado.BeginInvoke(acb,null);

        }
        private void finLlamadaAsincrona(IAsyncResult iar)
        {
            if (iar.IsCompleted)
            {
                lista = objDelegado.EndInvoke(iar);
                MethodInvoker mi = new MethodInvoker(mostrarDGV);
                this.Invoke(mi);
            }
        }
        private void mostrarDGV()
        {
            dataGridView1.DataSource = lista;
        }
    }
}
