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
    public partial class frmCatalogs : Form
    {
        public frmCatalogs()
        {
            InitializeComponent();
        }

        private void btnBackCatalogs_Click(object sender, EventArgs e)
        {
            // TODO: Optimize the way to reference to the forms
            frmModules formModules = new frmModules();
            formModules.Show();
            this.Hide();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers formSuppliers = new frmSuppliers();
            formSuppliers.Show();
            this.Hide();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients formClients = new frmClients();
            formClients.Show();
            this.Hide();
        }
    }
}
