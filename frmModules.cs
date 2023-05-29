using BackendlessAPI;
using BackendlessAPI.Async;

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

        private void button1_Click(object sender, EventArgs e)
        {
            frmProveedores suppliers = new frmProveedores();
            suppliers.Show();
            this.Hide();
        }
    }
}
