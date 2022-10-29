using System;
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
    public partial class AñadirEntrada : Form
    {
        public AñadirEntrada()
        {
            InitializeComponent();
        }

        private void AñadirEntrada_Load(object sender, EventArgs e)
        {
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }
    }
}
