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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //BL.Interfaces.ILIBRERIA ilibreria = new BL.Clases.LIBRERIA();
            //dgvPrueba.DataSource = ilibreria.ListarLibreria();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxLogo_Click(null, e);

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //si hay algun formulario abierto lo cerramos
            if (activeForm != null)
                activeForm.Close();
            //guardamos el formulario que se abre
            activeForm = childForm;
            //Indicamos que el formulario no es nivel superior, se toma como un control
            childForm.TopLevel = false;
            //Quitamos el borde del formulario 
            childForm.FormBorderStyle = FormBorderStyle.None;
            //Para llenar todo el panel contenedor
            childForm.Dock = DockStyle.Fill;
            //Agregamos el formulario a la lista de controles del panel contenedor
            panelContenedor.Controls.Add(childForm);
            //Asociamos el formulario con el panel contenedor
            panelContenedor.Tag = childForm;
            //Si hay algun logo tenemos que traer hacia el frente al formulario
            childForm.BringToFront();
            //Se muestra el formulario hijo 
            childForm.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            openChildForm(new Inicio());
        }

        private void buttonLibreria_Click(object sender, EventArgs e)
        {
            openChildForm(new Libreria());
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            openChildForm(new Personal());
        }

        private void buttonNomina_Click(object sender, EventArgs e)
        {
            openChildForm(new Nomina());
        }

        private void buttonProveedor_Click(object sender, EventArgs e)
        {
            openChildForm(new Proveedor());
        }

        private void buttonAlmacen_Click(object sender, EventArgs e)
        {
            openChildForm(new Almacen());
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            openChildForm(new Extra());
        }

        private void buttonLibro_Click(object sender, EventArgs e)
        {
            openChildForm(new Libro());
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new Cliente());
        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            openChildForm(new Venta());
        }
    }
}
