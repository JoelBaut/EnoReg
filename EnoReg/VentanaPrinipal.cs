﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnoReg
{
    public partial class VentanaPrinipal : Form
    {
        public VentanaPrinipal()
        {
            InitializeComponent();
        }

        private void VentanaPrinipal_Load(object sender, EventArgs e)
        {
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
