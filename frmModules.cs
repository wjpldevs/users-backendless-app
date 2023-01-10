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
    public partial class frmModules : Form
    {
        public frmModules()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders formOrders = new frmOrders();
            formOrders.Show();
            this.Hide();
        }

        private void btnCatalogs_Click(object sender, EventArgs e)
        {
            frmCatalogs formCatalogs = new frmCatalogs();
            formCatalogs.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            frmMaintenance formMaintenance = new frmMaintenance(); 
            formMaintenance.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Form1 frmUsers = new Form1();
            frmUsers.Show();
            this.Hide();
        }
    }
}
