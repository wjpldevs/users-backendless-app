namespace users_backendless_app
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnRefrescarProveedores = new System.Windows.Forms.Button();
            this.btnAgregarNuevoProveedor = new System.Windows.Forms.Button();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.colNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorreoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(97, 414);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(202, 45);
            this.btnEliminarProveedor.TabIndex = 35;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnRefrescarProveedores
            // 
            this.btnRefrescarProveedores.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefrescarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescarProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefrescarProveedores.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarProveedores.Location = new System.Drawing.Point(223, 333);
            this.btnRefrescarProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefrescarProveedores.Name = "btnRefrescarProveedores";
            this.btnRefrescarProveedores.Size = new System.Drawing.Size(178, 43);
            this.btnRefrescarProveedores.TabIndex = 34;
            this.btnRefrescarProveedores.Text = "Refrescar Proveedor";
            this.btnRefrescarProveedores.UseVisualStyleBackColor = false;
            this.btnRefrescarProveedores.Click += new System.EventHandler(this.btnRefrescarProveedores_Click);
            // 
            // btnAgregarNuevoProveedor
            // 
            this.btnAgregarNuevoProveedor.BackColor = System.Drawing.Color.Green;
            this.btnAgregarNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNuevoProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarNuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNuevoProveedor.Location = new System.Drawing.Point(30, 333);
            this.btnAgregarNuevoProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarNuevoProveedor.Name = "btnAgregarNuevoProveedor";
            this.btnAgregarNuevoProveedor.Size = new System.Drawing.Size(161, 43);
            this.btnAgregarNuevoProveedor.TabIndex = 33;
            this.btnAgregarNuevoProveedor.Text = "Agregar Proveedor";
            this.btnAgregarNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoProveedor.Click += new System.EventHandler(this.btnAgregarNuevoProveedor_Click);
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreProveedor,
            this.colCorreoProveedor});
            this.dtgProveedores.Location = new System.Drawing.Point(491, 95);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.RowHeadersWidth = 51;
            this.dtgProveedores.RowTemplate.Height = 29;
            this.dtgProveedores.Size = new System.Drawing.Size(756, 470);
            this.dtgProveedores.TabIndex = 32;
            // 
            // colNombreProveedor
            // 
            this.colNombreProveedor.HeaderText = "Nombre";
            this.colNombreProveedor.MinimumWidth = 6;
            this.colNombreProveedor.Name = "colNombreProveedor";
            this.colNombreProveedor.Width = 350;
            // 
            // colCorreoProveedor
            // 
            this.colCorreoProveedor.HeaderText = "Correo";
            this.colCorreoProveedor.MinimumWidth = 6;
            this.colCorreoProveedor.Name = "colCorreoProveedor";
            this.colCorreoProveedor.Width = 350;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Correo del proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre del proveedor";
            // 
            // txtCorreoProveedor
            // 
            this.txtCorreoProveedor.Location = new System.Drawing.Point(29, 229);
            this.txtCorreoProveedor.Name = "txtCorreoProveedor";
            this.txtCorreoProveedor.Size = new System.Drawing.Size(372, 27);
            this.txtCorreoProveedor.TabIndex = 29;
            this.txtCorreoProveedor.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(29, 154);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(372, 27);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::users_backendless_app.Properties.Resources.logo_app;
            this.pictureBox1.Location = new System.Drawing.Point(7, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(601, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "PROVEEDORES";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 619);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnRefrescarProveedores);
            this.Controls.Add(this.btnAgregarNuevoProveedor);
            this.Controls.Add(this.dtgProveedores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreoProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.Text = "Proveedor";
            this.Activated += new System.EventHandler(this.frmProveedores_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEliminarProveedor;
        private Button btnRefrescarProveedores;
        private Button btnAgregarNuevoProveedor;
        private DataGridView dtgProveedores;
        private DataGridViewTextBoxColumn colNombreProveedor;
        private DataGridViewTextBoxColumn colCorreoProveedor;
        private Label label3;
        private Label label2;
        private TextBox txtCorreoProveedor;
        private TextBox txtNombreProveedor;
        private PictureBox pictureBox1;
        private Label label1;
    }
}