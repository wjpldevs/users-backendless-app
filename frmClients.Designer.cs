namespace users_backendless_app
{
    partial class frmClients
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
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dtgClients = new System.Windows.Forms.DataGridView();
            this.colObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).BeginInit();
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
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Location = new System.Drawing.Point(97, 398);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(126, 34);
            this.btnDeleteClient.TabIndex = 33;
            this.btnDeleteClient.Text = "Eliminar Cliente";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Location = new System.Drawing.Point(18, 132);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(278, 23);
            this.txtClientName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email";
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientEmail.Location = new System.Drawing.Point(19, 224);
            this.txtClientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(278, 23);
            this.txtClientEmail.TabIndex = 29;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Green;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(97, 335);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(126, 32);
            this.btnAddClient.TabIndex = 28;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dtgClients
            // 
            this.dtgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colObjectId,
            this.colClient,
            this.colSupplierEmail});
            this.dtgClients.Location = new System.Drawing.Point(348, 58);
            this.dtgClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgClients.Name = "dtgClients";
            this.dtgClients.RowHeadersWidth = 51;
            this.dtgClients.RowTemplate.Height = 29;
            this.dtgClients.Size = new System.Drawing.Size(504, 381);
            this.dtgClients.TabIndex = 27;
            // 
            // colObjectId
            // 
            this.colObjectId.HeaderText = "ObjectId";
            this.colObjectId.MinimumWidth = 6;
            this.colObjectId.Name = "colObjectId";
            this.colObjectId.Width = 150;
            // 
            // colClient
            // 
            this.colClient.HeaderText = "Cliente";
            this.colClient.Name = "colClient";
            this.colClient.Width = 150;
            // 
            // colSupplierEmail
            // 
            this.colSupplierEmail.HeaderText = "Email";
            this.colSupplierEmail.Name = "colSupplierEmail";
            this.colSupplierEmail.Width = 150;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientEmail);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dtgClients);
            this.Controls.Add(this.btnBackCatalogs);
            this.Name = "frmClients";
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackCatalogs;
        private Button btnDeleteClient;
        private Label label3;
        private TextBox txtClientName;
        private Label label2;
        private TextBox txtClientEmail;
        private Button btnAddClient;
        private DataGridView dtgClients;
        private DataGridViewTextBoxColumn colObjectId;
        private DataGridViewTextBoxColumn colClient;
        private DataGridViewTextBoxColumn colSupplierEmail;
    }
}