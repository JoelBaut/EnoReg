using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        string ruta="";
        byte[] img = null;
        Image imagen;
        public NuevoProductos(ProductoDAO productoDAO, Point location)
        {
            this.productoDAO = productoDAO;
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
                ruta = fil_explorar.FileName.ToString();
                pcb_imagen.Image = imagen;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Boolean valor = false;
            string mensaje = "Tienes que rellenar o seleccionar:";
            if (!ruta.Equals(""))
            {
                FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                img = brs.ReadBytes((int)stream.Length);
                imagen = pcb_imagen.Image;
            }

            if (string.IsNullOrEmpty(txb_Nombre.Text))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Nombre";
                txb_Nombre.Focus();
                txb_Nombre.BackColor = Color.LightCoral;
                valor = true;
            }
            else {
                
                string check = "-1";
                MySqlDataReader dr = productoDAO.CargarNombres(txb_Nombre.Text);
                
                    while(dr.Read()) {
                    check=dr.GetString(0);
                }                
                if (!check.Equals("-1")) {
                    mensaje = "No se pueden introducir un producto existente";
                    valor = true;
                }
                txb_Nombre.BackColor = Color.White;
            }
            if (txb_unidad.Text.Equals(""))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Unidad";
                txb_unidad.Focus();
                txb_unidad.BackColor = Color.LightCoral;
                valor = true;
            }
            else
            {
                if (!ruta.Equals(""))
                {
                    productoDAO.InsertarProducto(txb_Nombre.Text, txb_unidad.Text, img);
                }
                else {
                    productoDAO.InsertarProducto(txb_Nombre.Text, txb_unidad.Text);
                }
                txb_Nombre.ResetText();
                txb_unidad.ResetText();
            }

        }
    }
}