namespace users_backendless_app
{
    partial class frmCatalogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogs));
            this.btnBackCatalogs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackCatalogs
            // 
            this.btnBackCatalogs.Location = new System.Drawing.Point(8, 6);
            this.btnBackCatalogs.Name = "btnBackCatalogs";
            this.btnBackCatalogs.Size = new System.Drawing.Size(75, 23);
            this.btnBackCatalogs.TabIndex = 0;
            this.btnBackCatalogs.Text = "Atras";
            this.btnBackCatalogs.UseVisualStyleBackColor = true;
            this.btnBackCatalogs.Click += new System.EventHandler(this.btnBackCatalogs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(386, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Proveedores";
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClients.BackgroundImage")));
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClients.Location = new System.Drawing.Point(315, 67);
            this.btnClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(200, 96);
            this.btnClients.TabIndex = 23;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.BackgroundImage")));
            this.btnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuppliers.Location = new System.Drawing.Point(33, 67);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(195, 96);
            this.btnSuppliers.TabIndex = 22;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // frmCatalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnBackCatalogs);
            this.Name = "frmCatalogs";
            this.Text = "frmCatalogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackCatalogs;
        private Label label6;
        private Label label5;
        private Button btnClients;
        private Button btnSuppliers;
    }
}