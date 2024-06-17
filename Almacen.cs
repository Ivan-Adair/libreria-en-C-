using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            BL.Interfaces.IALMACEN ialmacen = new BL.Clases.ALMACEN();
            dataGridViewAlmacen.DataSource = ialmacen.ListarAlmacen();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IALMACEN ialmacen = new BL.Clases.ALMACEN();
            DATOS.ALMACEN almacen = new DATOS.ALMACEN
            {
                ID = Convert.ToInt32(textBoxID.Text),
                ALM_PRO = Convert.ToInt32(textBoxAlmPro.Text),
                CANTIDAD = Convert.ToInt32(textBoxCantidad.Text),
                FECHA_ENTRADA = textBoxFechaEntrada.Text,
                FECHA_SALIDA = textBoxFechaSalida.Text,
                ALM_LIBR = Convert.ToInt32(textBoxAlmLibr.Text)
            };
            ialmacen.InsertarAlmacen(almacen);
            MessageBox.Show("Dato Ingresado");

            BL.Interfaces.IALMACEN ialmaceen = new BL.Clases.ALMACEN();
            dataGridViewAlmacen.DataSource = ialmaceen.ListarAlmacen();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IALMACEN ialmacen = new BL.Clases.ALMACEN();
            DATOS.ALMACEN almacenModificado = new DATOS.ALMACEN
            {
                ID = Convert.ToInt32(textBoxID.Text),
                ALM_PRO = Convert.ToInt32(textBoxAlmPro.Text),
                CANTIDAD = Convert.ToInt32(textBoxCantidad.Text),
                FECHA_ENTRADA = textBoxFechaEntrada.Text,
                FECHA_SALIDA = textBoxFechaSalida.Text,
                ALM_LIBR = Convert.ToInt32(textBoxAlmLibr.Text)
            };
            ialmacen.ActualizarAlmacen(almacenModificado);
            MessageBox.Show("Dato Modificado");
        }
    }
}
