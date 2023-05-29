using BackendlessAPI;
using BackendlessAPI.Async;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace users_backendless_app
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmModules modules = new frmModules();
            this.Hide();
            modules.Show();
        }

        private void CargarProveedores() 
        {
            AsyncCallback<IList<Dictionary<string, object>>> callback;
            callback = new AsyncCallback<IList<Dictionary<string, object>>>(
              foundSuppliers =>
              {
                  if (this.dtgProveedores.Rows.Count > 0)
                  {
                      this.dtgProveedores.Rows.Clear();
                  }

                  foreach (var foundSupplier in foundSuppliers)
                  {

                      int n = this.dtgProveedores.Rows.Add();

                      this.dtgProveedores.Rows[n].Cells[0].Value = foundSupplier["NombreProveedor"];
                      this.dtgProveedores.Rows[n].Cells[1].Value = foundSupplier["CorreoProveedor"];

                  }
              },
              error =>
              {
                  MessageBox.Show("Error al cargar los proveedores: " + error.Message);
              });

            Backendless.Data.Of("Proveedor").Find(callback);
        }

        private void btnAgregarNuevoProveedor_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> proveedor = new Dictionary<string, object>();

            proveedor["NombreProveedor"] = txtNombreProveedor.Text.Trim();
            proveedor["CorreoProveedor"] = txtCorreoProveedor.Text.Trim();

            txtNombreProveedor.Clear();
            txtCorreoProveedor.Clear();
            txtNombreProveedor.Focus();

            // save object asynchronously
            AsyncCallback<Dictionary<string, object>> callback;
            callback = new AsyncCallback<Dictionary<string, object>>(
                result =>
                {
                    MessageBox.Show("Proveedor guardado");
                },

                fault =>
                {
                    MessageBox.Show("Error al guardar proveedor {0}", fault.Message);
                });

            Backendless.Data.Of("Proveedor").Save(proveedor, callback);
        }

        private void btnRefrescarProveedores_Click(object sender, EventArgs e)
        {
            this.CargarProveedores();
            MessageBox.Show("Información de proveedores actualizada correctamente");
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            AsyncCallback<int> deleteObjectCallback = new AsyncCallback<int>(
              deletionTime =>
              {
                  MessageBox.Show("Proveedor eliminado en " + deletionTime.ToString() + " ms.", "Eliminacion de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.CargarProveedores();
              },
              error =>
              {
                  MessageBox.Show("Error al eliminar el cliente: " + error.ToString(), "Error al eliminar el proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            );

            var selectedObjectId = this.dtgProveedores.Rows[this.dtgProveedores.CurrentCell.RowIndex].Cells[0].Value as String;

            Backendless.Data.Of("Proveedor").Remove($"NombreProveedor = '{selectedObjectId}'", deleteObjectCallback);
        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Activated(object sender, EventArgs e)
        {
            this.CargarProveedores();
        }
    }
}
