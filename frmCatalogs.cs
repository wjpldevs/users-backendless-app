﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace users_backendless_app
{
    public partial class frmCatalogs : Form
    {
        public frmCatalogs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmModules modulos = new frmModules();
            this.Hide();
            modulos.Show();
        }
    }
}
