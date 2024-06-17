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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            BL.Interfaces.INOMINA inomina = new BL.Clases.NOMINA();
            dataGridViewNomina.DataSource = inomina.ListarNomina();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.INOMINA inomina = new BL.Clases.NOMINA();
            DATOS.NOMINA nomina = new DATOS.NOMINA
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxAPP.Text,
                APM = textBoxAPM.Text,
                RFC = textBoxRfc.Text,
                CURP = textBoxCurp.Text,
                PUESTO = textBoxPuesto.Text,
                SALARIO_NETO = Convert.ToInt32(textBoxSalarioNeto.Text),
                MATUTINA = textBoxMatutina.Text,
                COM_MATUTINA = Convert.ToInt32(textBoxComMatutina.Text),
                DIURNA = textBoxDiurna.Text,
                COM_DIURNA = Convert.ToInt32(textBoxComDiurna.Text),
                FALTA = textBoxFalta.Text,
                DESCUEN_FALTA = Convert.ToInt32(textBoxDesFalta.Text),
                SALARIO_TOTAL = Convert.ToInt32(textBoxSalarioTotal.Text),
                NOM_PER = Convert.ToInt32(textBoxNomPer.Text)
            };
            inomina.InsertarNomina(nomina);
            MessageBox.Show("Nomina Ingresada");

            BL.Interfaces.INOMINA inominaa = new BL.Clases.NOMINA();
            dataGridViewNomina.DataSource = inominaa.ListarNomina();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.INOMINA inomina = new BL.Clases.NOMINA();
            DATOS.NOMINA nominaModificada = new DATOS.NOMINA
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxAPP.Text,
                APM = textBoxAPM.Text,
                RFC = textBoxRfc.Text,
                CURP = textBoxCurp.Text,
                PUESTO = textBoxPuesto.Text,
                SALARIO_NETO = Convert.ToInt32(textBoxSalarioNeto.Text),
                MATUTINA = textBoxMatutina.Text,
                COM_MATUTINA = Convert.ToInt32(textBoxComMatutina.Text),
                DIURNA = textBoxDiurna.Text,
                COM_DIURNA = Convert.ToInt32(textBoxComDiurna.Text),
                FALTA = textBoxFalta.Text,
                DESCUEN_FALTA = Convert.ToInt32(textBoxDesFalta.Text),
                SALARIO_TOTAL = Convert.ToInt32(textBoxSalarioTotal.Text),
                NOM_PER = Convert.ToInt32(textBoxNomPer.Text)
            };
            inomina.ActualizarNomina(nominaModificada);
            MessageBox.Show("Dato Modificado");


        }
    }
}
