using BackendlessAPI;
using BackendlessAPI.Async;

namespace users_backendless_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void CargarUsuariosBackendless() {

            AsyncCallback<IList<Dictionary<string, object>>> callback;
            callback = new AsyncCallback<IList<Dictionary<string, object>>>(
              foundUsers =>
              {
                  if (this.dtgUsuarios.Rows.Count > 0)
                  {
                      this.dtgUsuarios.Rows.Clear();
                  }

                  foreach (var foundUser in foundUsers)
                  {

                      int n = this.dtgUsuarios.Rows.Add();

                      this.dtgUsuarios.Rows[n].Cells[0].Value = foundUser["objectId"];
                      this.dtgUsuarios.Rows[n].Cells[1].Value = foundUser["email"];
                      this.dtgUsuarios.Rows[n].Cells[2].Value = foundUser["name"];

                  }
              },
              error =>
              {
                  MessageBox.Show("Error al cargar los usuarios: " + error.Message);
              });

            Backendless.Data.Of("Users").Find(callback);

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.CargarUsuariosBackendless();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AsyncCallback<BackendlessUser> callback = new 
                AsyncCallback<BackendlessUser>(
                    user =>
                    {
                        if (user != null) {
                            MessageBox.Show("Usuario registrado existosamente \n " + user.ObjectId);
                            CargarUsuariosBackendless();
                            this.txtEmailRegistro.Text = "";
                            this.txtNombreRegistro.Text = "";
                            this.txtContraseniaRegistro.Text = "";
                            this.txtEmailRegistro.Focus();
                        }
                    },
                    fault =>
                    {
                        MessageBox.Show("Error al crear al usuario: " + fault.ToString(), "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                );

            BackendlessUser newUser = new BackendlessUser();
            newUser.SetProperty("email", this.txtEmailRegistro.Text);
            newUser.SetProperty("name", this.txtNombreRegistro.Text);
            newUser.Password = this.txtContraseniaRegistro.Text;
            Backendless.UserService.Register(newUser, callback);

        }

        private void btnRefrescarUsuarios_Click(object sender, EventArgs e)
        {
            this.CargarUsuariosBackendless();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            AsyncCallback<int> deleteObjectCallback = new AsyncCallback<int>(
              deletionTime =>
              {
                  MessageBox.Show("Usuario eliminado en " + deletionTime.ToString() + " ms.", "Eliminacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  this.CargarUsuariosBackendless();
              },
              error =>
              {
                  MessageBox.Show("Error al eliminar el usuario: " + error.ToString(), "Error al eliminar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            );

            var selectedObjectId = this.dtgUsuarios.Rows[this.dtgUsuarios.CurrentCell.RowIndex].Cells[0].Value as String;

            Backendless.Data.Of("Users").Remove($"objectId = '{selectedObjectId}'", deleteObjectCallback);
        }
    }
}