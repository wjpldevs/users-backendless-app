namespace users_backendless_app
{
    partial class frmMaintenance
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
            this.btnBackMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackMaintenance
            // 
            this.btnBackMaintenance.Location = new System.Drawing.Point(12, 12);
            this.btnBackMaintenance.Name = "btnBackMaintenance";
            this.btnBackMaintenance.Size = new System.Drawing.Size(75, 23);
            this.btnBackMaintenance.TabIndex = 1;
            this.btnBackMaintenance.Text = "Atras";
            this.btnBackMaintenance.UseVisualStyleBackColor = true;
            this.btnBackMaintenance.Click += new System.EventHandler(this.btnBackMaintenance_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackMaintenance);
            this.Name = "frmMaintenance";
            this.Text = "frmMaintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBackMaintenance;
    }
}