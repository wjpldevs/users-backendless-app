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
            this.btnBackOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackOrders
            // 
            this.btnBackOrders.Location = new System.Drawing.Point(12, 12);
            this.btnBackOrders.Name = "btnBackOrders";
            this.btnBackOrders.Size = new System.Drawing.Size(75, 23);
            this.btnBackOrders.TabIndex = 1;
            this.btnBackOrders.Text = "Atras";
            this.btnBackOrders.UseVisualStyleBackColor = true;
            this.btnBackOrders.Click += new System.EventHandler(this.btnBackOrders_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackOrders);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBackOrders;
    }
}