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
            this.btnBackCatalogs = new System.Windows.Forms.Button();
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
            // frmCatalogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackCatalogs);
            this.Name = "frmCatalogs";
            this.Text = "frmCatalogs";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBackCatalogs;
    }
}