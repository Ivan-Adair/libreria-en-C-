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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            BL.Interfaces.IPROVEEDOR iproveedor = new BL.Clases.PROVEEDOR();
            dataGridViewProveedor.DataSource = iproveedor.ListarProveedor();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPROVEEDOR iproveedor = new BL.Clases.PROVEEDOR();
            DATOS.PROVEEDOR proveedor = new DATOS.PROVEEDOR
            {
                ID = Convert.ToInt32(textBoxID.Text),
                EMPRESA = textBoxEmpresa.Text,
                EDITORIAL = textBoxEditorial.Text,
                NOMBRE = textBoxNombre.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                CANTIDAD = Convert.ToInt32(textBoxCantidad.Text),
                FECHA = textBoxFecha.Text,
                PRO_LIBR = Convert.ToInt32(textBoxProLibr.Text)
            };
            iproveedor.InsertarProveedor(proveedor);
            MessageBox.Show("Proveedor Ingresado");

            BL.Interfaces.IPROVEEDOR iproveedoor = new BL.Clases.PROVEEDOR();
            dataGridViewProveedor.DataSource = iproveedoor.ListarProveedor();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPROVEEDOR iproveedor = new BL.Clases.PROVEEDOR();
            DATOS.PROVEEDOR proveedorModificado = new DATOS.PROVEEDOR
            {
                ID = Convert.ToInt32(textBoxID.Text),
                EMPRESA = textBoxEmpresa.Text,
                EDITORIAL = textBoxEditorial.Text,
                NOMBRE = textBoxNombre.Text,
                PRECIO = Convert.ToInt32(textBoxPrecio.Text),
                CANTIDAD = Convert.ToInt32(textBoxCantidad.Text),
                FECHA = textBoxFecha.Text,
                PRO_LIBR = Convert.ToInt32(textBoxProLibr.Text)
            };
            iproveedor.ActualizarProveedor(proveedorModificado);
            MessageBox.Show("Dato Modificado");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            BL.Interfaces.IPROVEEDOR iproveedor = new BL.Clases.PROVEEDOR();
            int pro = Convert.ToInt32(textBoxID.Text);
            iproveedor.EliminarProveedor(pro);
            MessageBox.Show("Dato Eliminado");
        }
    }
}
