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
    public partial class Libro : Form
    {
        public Libro()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Libro_Load(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRO ilibro = new BL.Clases.LIBRO();
            dataGridViewLibro.DataSource = ilibro.ListarLibro();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRO ilibro = new BL.Clases.LIBRO();
            DATOS.LIBRO libro = new DATOS.LIBRO
            {
                ID = textBoxID.Text,
                TITULO = textBoxTitulo.Text,
                EDITORIAL = textBoxEditorial.Text,
                AUTOR = textBoxAutor.Text,
                FECHA_EDICION = textBoxFechaEdicion.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                DESCUENTO = Convert.ToInt32(textBoxDescuento.Text),
                TIPO = textBoxTipo.Text,
                STOCK = textBoxStock.Text,
                ESTANTE = textBoxEstante.Text,
                LIB_ALM = Convert.ToInt32(textBoxLibAlm.Text)
            };
            ilibro.InsertarLibro(libro);
            MessageBox.Show("Libro Ingresado");

            BL.Interfaces.ILIBRO ilibroo = new BL.Clases.LIBRO();
            dataGridViewLibro.DataSource = ilibroo.ListarLibro();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRO ilibro = new BL.Clases.LIBRO();
            DATOS.LIBRO libroModificado = new DATOS.LIBRO
            {
                ID = textBoxID.Text,
                TITULO = textBoxTitulo.Text,
                EDITORIAL = textBoxEditorial.Text,
                AUTOR = textBoxAutor.Text,
                FECHA_EDICION = textBoxFechaEdicion.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                DESCUENTO = Convert.ToInt32(textBoxDescuento.Text),
                TIPO = textBoxTipo.Text,
                STOCK = textBoxStock.Text,
                ESTANTE = textBoxEstante.Text,
                LIB_ALM = Convert.ToInt32(textBoxLibAlm.Text)
            };
            ilibro.ActualizarLibro(libroModificado);
            MessageBox.Show("Dato Modificado");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRO ilibro = new BL.Clases.LIBRO();
            string lib = textBoxID.Text;
            ilibro.EliminarLibro(lib);
            MessageBox.Show("Dato Eliminado");
        }
    }
}
