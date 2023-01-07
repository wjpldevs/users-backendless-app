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
using BackendlessAPI.Exception;

namespace users_backendless_app
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            AsyncCallback<BackendlessUser> callback = new 
                
                AsyncCallback<BackendlessUser>(
                    user =>
                    {
                        Form1 frm1 = new Form1();
                        MessageBox.Show("Inicio de sesión exitoso", "Incio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm1.Show();
                        this.Hide();
                        this.Invalidate();
                    },
                    fault =>
                    {
                        MessageBox.Show("Inicio de sesión con problemas " + fault.Message, "Incio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 );

            string login = txtEmail.Text;
            string password = txtPass.Text;
            Backendless.UserService.Login(login, password, callback, true);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtEmail.Focus();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            this.txtEmail.Focus();

            AsyncCallback<Boolean> callback_isValidLogin = new AsyncCallback<Boolean>(
              isValidLogin =>
              {
                  if (isValidLogin)
                  {
                      if (!Application.OpenForms.OfType<Form1>().Any()) {
                          Form1 frm1 = new Form1();
                          frm1.Show();
                          this.Hide();
                      }
                  }
                  else {
                      this.Show();
                  }
              },
              fault =>
              {
                  MessageBox.Show("Error: " + fault.ToString(), "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
              });

             Backendless.UserService.IsValidLogin(callback_isValidLogin);
        }
    }
}
