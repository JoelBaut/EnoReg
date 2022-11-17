using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnoReg
{
    public partial class NuevoProductos : Form
    {
        private ProductoDAO productoDAO;
        string ruta;
        byte[] img = null;
        public NuevoProductos(ProductoDAO productoDAO,Point location)
        {
            this.productoDAO = productoDAO;            
            InitializeComponent();
            this.Location = location;
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            cmb_unidad.Items.Add("Kg");
            cmb_unidad.Items.Add("L");
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
                ruta = fil_explorar.FileName.ToString();
                pcb_imagen.Image = imagen;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            img = brs.ReadBytes((int)stream.Length);
            productoDAO.InsertarProducto(txb_Nombre.Text,cmb_unidad.Text, img);

            // validaciones

            // nombre
            if (string.IsNullOrEmpty(txb_Nombre.Text))
            {
                MessageBox.Show("Rellena el campo Nombre",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txb_Nombre.Focus();
                txb_Nombre.BackColor = Color.LightCoral;
            }

            // unidad
            else if (cmb_unidad.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Tienes que seleccionar una unidad (kg o l)",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmb_unidad.Focus();
                cmb_unidad.BackColor = Color.LightCoral;
            }
        }
        
        private void NuevoProductos_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - this.Size.Width, this.Location.Y);
        }   
    }
}