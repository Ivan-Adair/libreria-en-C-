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
    public partial class Extra : Form
    {
        public Extra()
        {
            InitializeComponent();
        }

        private void Extra_Load(object sender, EventArgs e)
        {
            BL.Interfaces.IEXTRA iextra = new BL.Clases.EXTRA();
            dataGridViewExtra.DataSource = iextra.ListarExtra();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IEXTRA iextra = new BL.Clases.EXTRA();
            DATOS.EXTRA extra = new DATOS.EXTRA
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                MARCA = textBoxMarca.Text,
                COLOR = textBoxColor.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                STOCK = textBoxStock.Text,
                ESTANTE = textBoxEstante.Text,
                EXT_ALM = Convert.ToInt32(textBoxExtAlm.Text)
            };
            iextra.InsertarExtra(extra);
            MessageBox.Show("Dato Ingresado");
            BL.Interfaces.IEXTRA iextraa = new BL.Clases.EXTRA();
            dataGridViewExtra.DataSource = iextraa.ListarExtra();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IEXTRA iextra = new BL.Clases.EXTRA();
            DATOS.EXTRA extraModificado = new DATOS.EXTRA
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                MARCA = textBoxMarca.Text,
                COLOR = textBoxColor.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                STOCK = textBoxStock.Text,
                ESTANTE = textBoxEstante.Text,
                EXT_ALM = Convert.ToInt32(textBoxExtAlm.Text)
            };
            iextra.ActualizarExtra(extraModificado);
            MessageBox.Show("Dato Modificado");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IEXTRA iextra = new BL.Clases.EXTRA();
            int extr = Convert.ToInt32(textBoxID.Text);
            iextra.EliminarExtra(extr);
            MessageBox.Show("Dato Eliminado");
        }
    }
}
