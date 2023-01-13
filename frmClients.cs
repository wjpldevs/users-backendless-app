using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendlessAPI;
using BackendlessAPI.Async;

namespace users_backendless_app
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnBackCatalogs_Click(object sender, EventArgs e)
        {
            frmCatalogs formCatalogs = new frmCatalogs();
            formCatalogs.Show();
            this.Hide();
        }

        private void LoadClientsFromBackendless() {
            AsyncCallback<IList<Dictionary<string, object>>> callback;

            callback = new AsyncCallback<IList<Dictionary<string, object>>>(

              foundClients =>
              {
                  if (this.dtgClients.Rows.Count > 0)
                  {
                      this.dtgClients.Rows.Clear();
                  }

                  foreach (var foundClient in foundClients)
                  {

                      int n = this.dtgClients.Rows.Add();

                      this.dtgClients.Rows[n].Cells[0].Value = foundClient["objectId"];
                      this.dtgClients.Rows[n].Cells[1].Value = foundClient["ClientName"];
                      this.dtgClients.Rows[n].Cells[2].Value = foundClient["ClientEmail"];

                  }
              },
              error =>
              {
                  MessageBox.Show("Error al cargar los clients: " + error.Message);
              });

            Backendless.Data.Of("Clients").Find(callback);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> supplier = new Dictionary<string, object>();
            supplier["ClientName"] = txtClientName.Text;
            supplier["ClientEmail"] = txtClientEmail.Text;

            // save object asynchronously
            AsyncCallback<Dictionary<string, object>> callback;
            callback = new AsyncCallback<Dictionary<string, object>>(
              result =>
              {
                  if (result != null)
                  {
                      MessageBox.Show("Cliente registrado existosamente \n " + result["objectId"]);
                      LoadClientsFromBackendless();
                      this.txtClientName.Text = "";
                      this.txtClientEmail.Text = "";
                      this.txtClientName.Focus();
                  }
              },
              fault =>
              {
                  MessageBox.Show("Error al crear al cliente: " + fault.ToString(), "Error en clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
              });

            Backendless.Data.Of("Clients").Save(supplier, callback);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            AsyncCallback<int> deleteObjectCallback = new AsyncCallback<int>(
              deletionTime =>
              {
                  MessageBox.Show("Cliente eliminado en " + deletionTime.ToString() + " ms.", "Eliminacion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.LoadClientsFromBackendless();
              },
              error =>
              {
                  MessageBox.Show("Error al eliminar al cliente: " + error.ToString(), "Error al eliminar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            );

            var selectedObjectId = this.dtgClients.Rows[this.dtgClients.CurrentCell.RowIndex].Cells[0].Value as String;

            Backendless.Data.Of("Clients").Remove($"objectId = '{selectedObjectId}'", deleteObjectCallback);
        }
    }
}
