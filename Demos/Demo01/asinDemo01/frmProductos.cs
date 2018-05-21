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

namespace asinDemo01
{
    public partial class frmProductos : Form
    {
        PictureBox pbox;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void llenardgv(object sender, EventArgs e)
        {


        }

        private async void frmProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            //cargar barra de progreso
            pbox = new PictureBox();
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.Dock = DockStyle.Fill;

            string archivo = @"C:\Users\altamira\source\repos\ProgramacionAsincrona\archivos\loader.gif";
            pbox.LoadAsync(archivo);
            pbox.LoadCompleted += new AsyncCompletedEventHandler(finCargaImagen);

            //cargar data
            daProducto pro = new daProducto();
            List<beProducto> lista = null;
            await Task.Run(() => {
                lista = pro.Listar();
            });
            //renderizado
            dataGridView1.DataSource = lista;
            pbox.Visible = false;
            dataGridView1.Visible = true;
        }
        private void finCargaImagen(object sender, AsyncCompletedEventArgs e)
        {
            this.Controls.Add(pbox);

        }
    }
}
