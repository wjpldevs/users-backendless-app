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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnBackCatalogs_Click(object sender, EventArgs e)
        {
            frmCatalogs formCatalogs = new frmCatalogs();
            formCatalogs.Show();
            this.Hide();
        }
    }
}
