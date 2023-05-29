namespace users_backendless_app
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnRefrescarClientes = new System.Windows.Forms.Button();
            this.btnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.colNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::users_backendless_app.Properties.Resources.logo_app;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLIENTES";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(14, 146);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(372, 27);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(14, 221);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(372, 27);
            this.txtApellidoCliente.TabIndex = 10;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(14, 297);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(372, 27);
            this.txtCorreoCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre del cliente";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Location = new System.Drawing.Point(112, 445);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(144, 45);
            this.btnEliminarCliente.TabIndex = 25;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnRefrescarClientes
            // 
            this.btnRefrescarClientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefrescarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescarClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescarClientes.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarClientes.Location = new System.Drawing.Point(234, 365);
            this.btnRefrescarClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarClientes.Name = "btnRefrescarClientes";
            this.btnRefrescarClientes.Size = new System.Drawing.Size(152, 43);
            this.btnRefrescarClientes.TabIndex = 24;
            this.btnRefrescarClientes.Text = "Refrescar Clientes";
            this.btnRefrescarClientes.UseVisualStyleBackColor = false;
            this.btnRefrescarClientes.Click += new System.EventHandler(this.btnRefrescarClientes_Click);
            // 
            // btnAgregarNuevoCliente
            // 
            this.btnAgregarNuevoCliente.BackColor = System.Drawing.Color.Green;
            this.btnAgregarNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNuevoCliente.Location = new System.Drawing.Point(15, 365);
            this.btnAgregarNuevoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            this.btnAgregarNuevoCliente.Size = new System.Drawing.Size(144, 43);
            this.btnAgregarNuevoCliente.TabIndex = 23;
            this.btnAgregarNuevoCliente.Text = "Agregar Cliente";
            this.btnAgregarNuevoCliente.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoCliente.Click += new System.EventHandler(this.btnAgregarNuevoCliente_Click);
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreCliente,
            this.colApellidoCliente,
            this.colCorreoCliente});
            this.dtgClientes.Location = new System.Drawing.Point(424, 90);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.RowHeadersWidth = 51;
            this.dtgClientes.RowTemplate.Height = 29;
            this.dtgClientes.Size = new System.Drawing.Size(811, 470);
            this.dtgClientes.TabIndex = 22;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.HeaderText = "Nombre";
            this.colNombreCliente.MinimumWidth = 6;
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.Width = 250;
            // 
            // colApellidoCliente
            // 
            this.colApellidoCliente.HeaderText = "Apellido";
            this.colApellidoCliente.MinimumWidth = 6;
            this.colApellidoCliente.Name = "colApellidoCliente";
            this.colApellidoCliente.Width = 250;
            // 
            // colCorreoCliente
            // 
            this.colCorreoCliente.HeaderText = "Correo";
            this.colCorreoCliente.MinimumWidth = 6;
            this.colCorreoCliente.Name = "colCorreoCliente";
            this.colCorreoCliente.Width = 250;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo del cliente";
            // 
            // frmOrders
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnRefrescarClientes);
            this.Controls.Add(this.btnAgregarNuevoCliente);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmOrders_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombreCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtCorreoCliente;
        private Label label3;
        private Label label2;
        private Button btnEliminarCliente;
        private Button btnRefrescarClientes;
        private Button btnAgregarNuevoCliente;
        private DataGridView dtgClientes;
        private Label label5;
        private DataGridViewTextBoxColumn colNombreCliente;
        private DataGridViewTextBoxColumn colApellidoCliente;
        private DataGridViewTextBoxColumn colCorreoCliente;
    }
}