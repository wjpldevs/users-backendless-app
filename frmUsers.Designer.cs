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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de usuarios con Backendless";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::users_backendless_app.Properties.Resources.logo_app;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(783, 28);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(119, 31);
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
            this.dtgUsuarios.Location = new System.Drawing.Point(399, 118);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 29;
            this.dtgUsuarios.Size = new System.Drawing.Size(503, 470);
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
            this.btnAgregarUsuario.Location = new System.Drawing.Point(21, 467);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(144, 43);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtEmailRegistro
            // 
            this.txtEmailRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailRegistro.Location = new System.Drawing.Point(21, 153);
            this.txtEmailRegistro.Name = "txtEmailRegistro";
            this.txtEmailRegistro.Size = new System.Drawing.Size(318, 27);
            this.txtEmailRegistro.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // txtNombreRegistro
            // 
            this.txtNombreRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreRegistro.Location = new System.Drawing.Point(21, 252);
            this.txtNombreRegistro.Name = "txtNombreRegistro";
            this.txtNombreRegistro.Size = new System.Drawing.Size(318, 27);
            this.txtNombreRegistro.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            // 
            // txtContraseniaRegistro
            // 
            this.txtContraseniaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseniaRegistro.Location = new System.Drawing.Point(21, 361);
            this.txtContraseniaRegistro.Name = "txtContraseniaRegistro";
            this.txtContraseniaRegistro.Size = new System.Drawing.Size(318, 27);
            this.txtContraseniaRegistro.TabIndex = 14;
            // 
            // btnRefrescarUsuarios
            // 
            this.btnRefrescarUsuarios.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefrescarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescarUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarUsuarios.Location = new System.Drawing.Point(187, 467);
            this.btnRefrescarUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarUsuarios.Name = "btnRefrescarUsuarios";
            this.btnRefrescarUsuarios.Size = new System.Drawing.Size(152, 43);
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
            this.btnEliminarUsuario.Location = new System.Drawing.Point(111, 528);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(144, 45);
            this.btnEliminarUsuario.TabIndex = 17;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
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
    }
}