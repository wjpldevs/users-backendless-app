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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void btnBackCatalogs_Click(object sender, EventArgs e)
        {
            frmCatalogs formCatalogs = new frmCatalogs();
            formCatalogs.Show();
            this.Hide();
        }

        private void LoadSuppliersFromBackendless() {

            AsyncCallback<IList<Dictionary<string, object>>> callback;

            callback = new AsyncCallback<IList<Dictionary<string, object>>>(

              foundSuppliers =>
              {
                  if (this.dtgSuppliers.Rows.Count > 0)
                  {
                      this.dtgSuppliers.Rows.Clear();
                  }

                  foreach (var foundSupplier in foundSuppliers)
                  {

                      int n = this.dtgSuppliers.Rows.Add();

                      this.dtgSuppliers.Rows[n].Cells[0].Value = foundSupplier["objectId"];
                      this.dtgSuppliers.Rows[n].Cells[1].Value = foundSupplier["SupplierName"];
                      this.dtgSuppliers.Rows[n].Cells[2].Value = foundSupplier["SupplierEmail"];

                  }
              },
              error =>
              {
                  MessageBox.Show("Error al cargar los proveedores: " + error.Message);
              });

            Backendless.Data.Of("Suppliers").Find(callback);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> supplier = new Dictionary<string, object>();
            supplier["SupplierName"] = txtSupplierName.Text;
            supplier["SupplierEmail"] = txtSupplierEmail.Text;

            // save object asynchronously
            AsyncCallback<Dictionary<string, object>> callback;
            callback = new AsyncCallback<Dictionary<string, object>>(
              result =>
              {
                  if (result != null)
                  {
                      MessageBox.Show("Proveedor registrado existosamente \n " + result["objectId"]);
                      LoadSuppliersFromBackendless();
                      this.txtSupplierName.Text = "";
                      this.txtSupplierEmail.Text = "";
                      this.txtSupplierName.Focus();
                  }
              },

              fault =>
              {
                  MessageBox.Show("Error al crear al proveedor: " + fault.ToString(), "Error en proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
              });

            Backendless.Data.Of("Suppliers").Save(supplier, callback) ;
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            AsyncCallback<int> deleteObjectCallback = new AsyncCallback<int>(
              deletionTime =>
              {
                  MessageBox.Show("Proveedor eliminado en " + deletionTime.ToString() + " ms.", "Eliminacion de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.LoadSuppliersFromBackendless();
              },
              error =>
              {
                  MessageBox.Show("Error al eliminar al proveedor: " + error.ToString(), "Error al eliminar el proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            );

            var selectedObjectId = this.dtgSuppliers.Rows[this.dtgSuppliers.CurrentCell.RowIndex].Cells[0].Value as String;

            Backendless.Data.Of("Suppliers").Remove($"objectId = '{selectedObjectId}'", deleteObjectCallback);
        }

        private void frmSuppliers_Activated(object sender, EventArgs e)
        {
            LoadSuppliersFromBackendless();
        }
    }
}
