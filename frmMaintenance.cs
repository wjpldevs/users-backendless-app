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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnBackMaintenance_Click(object sender, EventArgs e)
        {
            // TODO: Optimize the way to reference to the forms
            frmModules formModules = new frmModules();
            formModules.Show();
            this.Hide();
        }
    }
}
