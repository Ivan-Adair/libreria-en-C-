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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            BL.Interfaces.ICLIENTE icliente = new BL.Clases.CLIENTE();
            dataGridViewCliente.DataSource = icliente.ListarCliente();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ICLIENTE icliente = new BL.Clases.CLIENTE();
            DATOS.CLIENTE cliente = new DATOS.CLIENTE
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxApellidoPaterno.Text,
                APM = textBoxApellidoMaterno.Text,
                CORREO = textBoxCorreo.Text,
                TELEFONO = textBoxTelefono.Text
            };
            icliente.InsertarCliente(cliente);
            MessageBox.Show("Cliente ingresado");

            BL.Interfaces.ICLIENTE iclientee = new BL.Clases.CLIENTE();
            dataGridViewCliente.DataSource = iclientee.ListarCliente();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.ICLIENTE icliente = new BL.Clases.CLIENTE();
            DATOS.CLIENTE clienteModificado = new DATOS.CLIENTE
            {
                ID = Convert.ToInt32(textBoxID.Text),
                NOMBRE = textBoxNombre.Text,
                APP = textBoxApellidoPaterno.Text,
                APM = textBoxApellidoMaterno.Text,
                CORREO = textBoxCorreo.Text,
                TELEFONO = textBoxTelefono.Text
            };
            icliente.ActualizarCliente(clienteModificado);
            MessageBox.Show("Dato Modificado");
        }
    }
}
