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
                    },
                    fault =>
                    {
                        MessageBox.Show("Inicio de sesión con problemas " + fault.Message, "Incio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 );

            string login = txtEmail.Text;
            string password = txtPass.Text;
            Backendless.UserService.Login(login, password, callback);


        }
    }
}
