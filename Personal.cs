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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            BL.Interfaces.IPERSONAL ipersonal = new BL.Clases.PERSONAL();
            dataGridViewPersonal.DataSource = ipersonal.ListarPersonal();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPERSONAL ipersona = new BL.Clases.PERSONAL();
            DATOS.PERSONAL persona = new DATOS.PERSONAL
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxAPP.Text,
                APM = textBoxAPM.Text,
                PUESTO = textBoxPuesto.Text,
                CIUDAD = textBoxCiudad.Text,
                MUNICIPIO = textBoxMunicipio.Text,
                COD_POSTAL = Convert.ToInt32(textBoxCod_Postal.Text),
                CALLE = textBoxCalle.Text,
                RFC = textBoxRfc.Text,
                CURP = textBoxCurp.Text,
                TELEFONO = textBoxTelefono.Text,
                SERVICIO = textBoxServicio.Text,
                JORNADA = textBoxJornada.Text,
                HRS_EXTRA = textBoxHrs_extras.Text,
                PER_LIBR = Convert.ToInt32(textBoxPer_Libr.Text)
            };
            ipersona.InsertarPersonal(persona);
            MessageBox.Show("Persona Ingresada");

            BL.Interfaces.IPERSONAL iperson = new BL.Clases.PERSONAL();
            dataGridViewPersonal.DataSource = iperson.ListarPersonal();

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPERSONAL ipersonal = new BL.Clases.PERSONAL();
            DATOS.PERSONAL personalModificado = new DATOS.PERSONAL
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxAPP.Text,
                APM = textBoxAPM.Text,
                PUESTO = textBoxPuesto.Text,
                CIUDAD = textBoxCiudad.Text,
                MUNICIPIO = textBoxMunicipio.Text,
                COD_POSTAL = Convert.ToInt32(textBoxCod_Postal.Text),
                CALLE = textBoxCalle.Text,
                RFC = textBoxRfc.Text,
                CURP = textBoxCurp.Text,
                TELEFONO = textBoxTelefono.Text,
                SERVICIO = textBoxServicio.Text,
                JORNADA = textBoxJornada.Text,
                HRS_EXTRA = textBoxHrs_extras.Text,
                PER_LIBR = Convert.ToInt32(textBoxPer_Libr.Text)
            };
            ipersonal.ActualizarPersonal(personalModificado);
            MessageBox.Show("Dato Modificado");

            BL.Interfaces.IPERSONAL ipersonaaal = new BL.Clases.PERSONAL();
            dataGridViewPersonal.DataSource = ipersonaaal.ListarPersonal();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPERSONAL ipersonal = new BL.Clases.PERSONAL();
            int id = Convert.ToInt32(textBoxID.Text);
            ipersonal.EliminarPersonal(id);
            MessageBox.Show("Dato Eliminado");
        }
    }
}
