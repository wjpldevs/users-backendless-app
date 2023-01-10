namespace users_backendless_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtEmailRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRegistro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraseniaRegistro = new System.Windows.Forms.TextBox();
            this.btnRefrescarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBackUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de usuarios con Backendless";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(685, 21);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(104, 23);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObjectId,
            this.colEmail,
            this.colName});
            this.dtgUsuarios.Location = new System.Drawing.Point(349, 88);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 29;
            this.dtgUsuarios.Size = new System.Drawing.Size(440, 352);
            this.dtgUsuarios.TabIndex = 8;
            // 
            // colObjectId
            // 
            this.colObjectId.HeaderText = "ObjectId";
            this.colObjectId.MinimumWidth = 6;
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nombre";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Green;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(18, 350);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(126, 32);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtEmailRegistro
            // 
            this.txtEmailRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailRegistro.Location = new System.Drawing.Point(18, 115);
            this.txtEmailRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailRegistro.Name = "txtEmailRegistro";
            this.txtEmailRegistro.Size = new System.Drawing.Size(278, 23);
            this.txtEmailRegistro.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreRegistro.Location = new System.Drawing.Point(18, 189);
            this.txtNombreRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(278, 23);
            this.txtNombreRegistro.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            // 
            // txtContraseniaRegistro
            // 
            this.txtContraseniaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseniaRegistro.Location = new System.Drawing.Point(18, 271);
            this.txtContraseniaRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            this.txtContraseniaRegistro.Size = new System.Drawing.Size(278, 23);
            this.txtContraseniaRegistro.TabIndex = 14;
            // 
            // btnRefrescarUsuarios
            // 
            this.btnRefrescarUsuarios.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefrescarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescarUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarUsuarios.Location = new System.Drawing.Point(164, 350);
            this.btnRefrescarUsuarios.Name = "btnRefrescarUsuarios";
            this.btnRefrescarUsuarios.Size = new System.Drawing.Size(133, 32);
            this.btnRefrescarUsuarios.TabIndex = 16;
            this.btnRefrescarUsuarios.Text = "Refrescar Usuarios";
            this.btnRefrescarUsuarios.UseVisualStyleBackColor = false;
            this.btnRefrescarUsuarios.Click += new System.EventHandler(this.btnRefrescarUsuarios_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(97, 396);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(126, 34);
            this.btnEliminarUsuario.TabIndex = 17;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnBackUsers
            // 
            this.btnBackUsers.Location = new System.Drawing.Point(10, 12);
            this.btnBackUsers.Name = "btnBackUsers";
            this.btnBackUsers.Size = new System.Drawing.Size(75, 23);
            this.btnBackUsers.TabIndex = 18;
            this.btnBackUsers.Text = "Atras";
            this.btnBackUsers.UseVisualStyleBackColor = true;
            this.btnBackUsers.Click += new System.EventHandler(this.btnBackUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackUsers);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnRefrescarUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseniaRegistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailRegistro);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCerrarSesion;
        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn colObjectId;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colName;
        private Button btnAgregarUsuario;
        private TextBox txtEmailRegistro;
        private Label label2;
        private Label label3;
        private TextBox txtNombreRegistro;
        private Label label4;
        private TextBox txtContraseniaRegistro;
        private Button btnRefrescarUsuarios;
        private Button btnEliminarUsuario;
        private Button btnBackUsers;
    }
}