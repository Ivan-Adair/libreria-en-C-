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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            BL.Interfaces.IVENTA iventa = new BL.Clases.VENTA();
            dataGridViewVenta.DataSource = iventa.ListarVenta();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IVENTA iventa = new BL.Clases.VENTA();
            DATOS.VENTA venta = new DATOS.VENTA
            {
                ID = textBoxID.Text,
                PRODUCTO = textBoxProducto.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                SUB_TOTAL = Convert.ToInt32(textBoxSubTotal.Text),
                IVA = Convert.ToInt32(textBoxIVA.Text),
                TOTAL = Convert.ToInt32(textBoxTotal.Text),
                TIPO = textBoxTipo.Text,
                FECHA_VENTA = (textBoxFechaVenta.Text),
                CAJA = textBoxCaja.Text,
                VEN_CLI = Convert.ToInt32(textBoxVen_Cli.Text),
                VEN_LIB = textBoxVen_Lib.Text,
                VEN_EXT = Convert.ToInt32(textBoxVen_Ext.Text),
                VEN_PER = Convert.ToInt32(textBoxVen_Per.Text)
            };
            iventa.InsertarVenta(venta);
            MessageBox.Show("Venta registrada");

            BL.Interfaces.IVENTA iventaa = new BL.Clases.VENTA();
            dataGridViewVenta.DataSource = iventaa.ListarVenta();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
