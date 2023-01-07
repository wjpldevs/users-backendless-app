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

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AsyncCallback<IList<Dictionary<string, object>>> callback;
            callback = new AsyncCallback<IList<Dictionary<string, object>>>(
              foundUsers =>
              {
                  if (this.dtgUsuarios.Rows.Count > 0) { 
                    this.dtgUsuarios.Rows.Clear();
                  }

                  foreach (var foundUser in foundUsers) {

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

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}