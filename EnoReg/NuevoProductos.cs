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
    public partial class NuevoProductos : Form
    {
        public NuevoProductos()
        {
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {
            fil_explorar.Filter = "imagenes (*.png,*.jpg,*.bmp)|*.png;*.jpg;*.bmp"
                + "|archivos JPEG (*.jpg)|*.jpg"
                + "|archivos PNG (*.jpg)|*.png"
                + "|archivos MBP (*.jpg)|*.bmp";

            if (fil_explorar.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = new Bitmap(fil_explorar.FileName);
                pcb_imagen.Image = imagen;
            }
        }
    }
}
