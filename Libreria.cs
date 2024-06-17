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
    public partial class Libreria : Form
    {
        public Libreria()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Libreria_Load(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRERIA ilibreria = new BL.Clases.LIBRERIA();
            dataGridViewLibreria.DataSource = ilibreria.ListarLibreria();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ILIBRERIA ilibreria = new BL.Clases.LIBRERIA();
            DATOS.LIBRERIA libreriaModificada = new DATOS.LIBRERIA
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                CIUDAD = textBoxCiudad.Text,
                MUNICIPIO = textBoxMunicipio.Text,
                COD_POSTAL = Convert.ToInt32(textBoxCodPostal.Text),
                CALLE = textBoxCalle.Text,
                TELEFONO = textBoxTelefono.Text,
                CORREO = textBoxCorreo.Text
            };
            ilibreria.ActualizarLibreria(libreriaModificada);
            MessageBox.Show("Dato Modificado");

            BL.Interfaces.ILIBRERIA ilibreriaa = new BL.Clases.LIBRERIA();
            dataGridViewLibreria.DataSource = ilibreriaa.ListarLibreria();
        }
    }
}
