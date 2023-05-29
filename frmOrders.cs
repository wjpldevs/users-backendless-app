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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmModules modules = new frmModules();
            this.Hide();
            modules.Show();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            //  empty
        }

        private void CargarClientes()
        {
            AsyncCallback<IList<Dictionary<string, object>>> callback;
            callback = new AsyncCallback<IList<Dictionary<string, object>>>(
              foundClients =>
              {
                  if (this.dtgClientes.Rows.Count > 0)
                  {
                      this.dtgClientes.Rows.Clear();
                  }

                  foreach (var foundClient in foundClients)
                  {

                      int n = this.dtgClientes.Rows.Add();

                      this.dtgClientes.Rows[n].Cells[0].Value = foundClient["NombreCliente"];
                      this.dtgClientes.Rows[n].Cells[1].Value = foundClient["ApellidoCliente"];
                      this.dtgClientes.Rows[n].Cells[2].Value = foundClient["CorreoCliente"];

                  }
              },
              error =>
              {
                  MessageBox.Show("Error al cargar los clientes: " + error.Message);
              });

            Backendless.Data.Of("Cliente").Find(callback);
        }

        private void btnAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> cliente = new Dictionary<string, object>();

            cliente["NombreCliente"] = txtNombreCliente.Text.Trim();
            cliente["ApellidoCliente"] = txtApellidoCliente.Text.Trim();
            cliente["CorreoCliente"] = txtCorreoCliente.Text.Trim();

            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtCorreoCliente.Clear();
            txtNombreCliente.Focus();

            // save object asynchronously
            AsyncCallback<Dictionary<string, object>> callback;
            callback = new AsyncCallback<Dictionary<string, object>>(
                result =>
                {
                    MessageBox.Show("Cliente guardado");
                },

                fault =>
                {
                    MessageBox.Show("Error al guardar cliente {0}", fault.Message);
                });

            Backendless.Data.Of("Cliente").Save(cliente, callback);
        }

        private void btnRefrescarClientes_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
            MessageBox.Show("Información de clientes actualizada correctamente");
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            AsyncCallback<int> deleteObjectCallback = new AsyncCallback<int>(
              deletionTime =>
              {
                  MessageBox.Show("Cliente eliminado en " + deletionTime.ToString() + " ms.", "Eliminacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.CargarClientes();
              },
              error =>
              {
                  MessageBox.Show("Error al eliminar el cliente: " + error.ToString(), "Error al eliminar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            );

            var selectedObjectId = this.dtgClientes.Rows[this.dtgClientes.CurrentCell.RowIndex].Cells[0].Value as String;

            Backendless.Data.Of("Cliente").Remove($"NombreCliente = '{selectedObjectId}'", deleteObjectCallback);
        }

        private void frmOrders_Activated(object sender, EventArgs e)
        {
            this.CargarClientes();
        }
    }
}
