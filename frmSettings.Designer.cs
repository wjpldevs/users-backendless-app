namespace users_backendless_app
{
    partial class frmSettings
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
            this.btnBackSettings = new System.Windows.Forms.Button();
            this.btnLogoutSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackSettings
            // 
            this.btnBackSettings.Location = new System.Drawing.Point(12, 12);
            this.btnBackSettings.Name = "btnBackSettings";
            this.btnBackSettings.Size = new System.Drawing.Size(75, 23);
            this.btnBackSettings.TabIndex = 0;
            this.btnBackSettings.Text = "Atras";
            this.btnBackSettings.UseVisualStyleBackColor = true;
            this.btnBackSettings.Click += new System.EventHandler(this.btnBackSettings_Click);
            // 
            // btnLogoutSettings
            // 
            this.btnLogoutSettings.BackColor = System.Drawing.Color.Crimson;
            this.btnLogoutSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogoutSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutSettings.ForeColor = System.Drawing.Color.White;
            this.btnLogoutSettings.Location = new System.Drawing.Point(684, 12);
            this.btnLogoutSettings.Name = "btnLogoutSettings";
            this.btnLogoutSettings.Size = new System.Drawing.Size(104, 23);
            this.btnLogoutSettings.TabIndex = 8;
            this.btnLogoutSettings.Text = "Cerrar sesión";
            this.btnLogoutSettings.UseVisualStyleBackColor = false;
            this.btnLogoutSettings.Click += new System.EventHandler(this.btnLogoutSettings_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogoutSettings);
            this.Controls.Add(this.btnBackSettings);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBackSettings;
        private Button btnLogoutSettings;
    }
}