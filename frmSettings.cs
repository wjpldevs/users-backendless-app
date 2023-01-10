using BackendlessAPI.Async;
using BackendlessAPI;
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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnBackSettings_Click(object sender, EventArgs e)
        {
            // TODO: Optimize the way to reference to the forms
            frmModules formModules = new frmModules();
            formModules.Show();
            this.Hide();
        }

        private void btnLogoutSettings_Click(object sender, EventArgs e)
        {
            // do not forget to call Backendless.InitApp in the app initialization code 

            AsyncCallback<Object> logoutCallback = new AsyncCallback<Object>(
              user =>
              {
                  MessageBox.Show("Has cerrado sesion!", "Sesion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.Hide();
                  frmLogin login = new frmLogin();
                  login.Show();
              },
              fault =>
              {
                  MessageBox.Show("Error al cerrar sesion: " + fault.ToString(), "Error al cerrar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
              });

            Backendless.UserService.Logout(logoutCallback);
        }
    }
}
