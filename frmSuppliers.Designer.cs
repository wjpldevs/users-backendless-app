namespace users_backendless_app
{
    partial class frmSuppliers
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
            this.btnBackCatalogs = new System.Windows.Forms.Button();
            this.dtgSuppliers = new System.Windows.Forms.DataGridView();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackCatalogs
            // 
            this.btnBackCatalogs.Location = new System.Drawing.Point(12, 12);
            this.btnBackCatalogs.Name = "btnBackCatalogs";
            this.btnBackCatalogs.Size = new System.Drawing.Size(75, 23);
            this.btnBackCatalogs.TabIndex = 1;
            this.btnBackCatalogs.Text = "Atras";
            this.btnBackCatalogs.UseVisualStyleBackColor = true;
            this.btnBackCatalogs.Click += new System.EventHandler(this.btnBackCatalogs_Click);
            // 
            // dtgSuppliers
            // 
            this.dtgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObjectId,
            this.colSupplier,
            this.colSupplierEmail});
            this.dtgSuppliers.Location = new System.Drawing.Point(360, 58);
            this.dtgSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgSuppliers.Name = "dtgSuppliers";
            this.dtgSuppliers.RowHeadersWidth = 51;
            this.dtgSuppliers.RowTemplate.Height = 29;
            this.dtgSuppliers.Size = new System.Drawing.Size(504, 381);
            this.dtgSuppliers.TabIndex = 9;
            // 
            // colObjectId
            // 
            this.colObjectId.HeaderText = "ObjectId";
            this.colObjectId.MinimumWidth = 6;
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.Width = 150;
            // 
            // colSupplier
            // 
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.Width = 150;
            // 
            // colSupplierEmail
            // 
            this.colSupplierEmail.HeaderText = "Email";
            this.colSupplierEmail.Name = "colSupplierEmail";
            this.colSupplierEmail.Width = 150;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(109, 398);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(126, 34);
            this.btnDeleteSupplier.TabIndex = 26;
            this.btnDeleteSupplier.Text = "Eliminar Proveedor";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Location = new System.Drawing.Point(30, 132);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(278, 23);
            this.txtSupplierName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierEmail.Location = new System.Drawing.Point(31, 224);
            this.txtSupplierEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(278, 23);
            this.txtSupplierEmail.TabIndex = 19;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Green;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Location = new System.Drawing.Point(109, 335);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(126, 32);
            this.btnAddSupplier.TabIndex = 18;
            this.btnAddSupplier.Text = "Agregar Proveedor";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierEmail);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dtgSuppliers);
            this.Controls.Add(this.btnBackCatalogs);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.Activated += new System.EventHandler(this.frmSuppliers_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackCatalogs;
        private DataGridView dtgSuppliers;
        private DataGridViewTextBoxColumn colObjectId;
        private DataGridViewTextBoxColumn colSupplier;
        private DataGridViewTextBoxColumn colSupplierEmail;
        private Button btnDeleteSupplier;
        private Label label3;
        private TextBox txtSupplierName;
        private Label label2;
        private TextBox txtSupplierEmail;
        private Button btnAddSupplier;
    }
}