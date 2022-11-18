using MySql.Data.MySqlClient;
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
        private ProductoDAO productoDAO;
        MySqlDataReader dr;
        public AñadirEntrada(ProductoDAO productoDAO, MySqlDataReader mySqlDataReader, Point location)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            this.Location = new Point(this.Location.X, this.Location.Y);

            cargarCombo(dr);
            dtpFechaEntrada.MaxDate = DateTime.Today;
            dtpCaducidad.MinDate = DateTime.Today;
            dtpCaducidad.Value = DateTime.Now.Date;
        }

        private void cargarCombo(MySqlDataReader dr)
        {
            while (dr.Read()) {
                cmbProductos.Items.Add(new
                {
                    id = dr["id_producto"],
                    nombre = dr["nombre"]
                }); 
            }
            cmbProductos.DisplayMember = "nombre";
            cmbProductos.ValueMember = "id";
        }


        private void AñadirEntrada_Load(object sender, EventArgs e)
        {
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }

        private void btnAceptarEntrada_Click(object sender, EventArgs e)
        {     
            Boolean valor = false;
            String mensaje = "Tienes que rellenar o seleccionar:";
            if (cmbProductos.SelectedIndex.Equals(-1))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Producto";
                cmbProductos.Focus();
                cmbProductos.BackColor = Color.LightCoral;
                valor = true;
            }
            if (string.IsNullOrEmpty(txbLote.Text))
            {
                if (mensaje.Length > 34) {
                    mensaje += ",";
                }
                mensaje += " Lote";
                txbLote.Focus();
                txbLote.BackColor = Color.LightCoral;
                valor = true;
            }
            if (string.IsNullOrEmpty(txbCantidad.Text))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Cantidad";
                txbCantidad.Focus();
                txbCantidad.BackColor = Color.LightCoral;
                valor = true;
            }
            if (dtpCaducidad.Value.Date == DateTime.Now.Date)
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Fecha de Caducidad";
                dtpCaducidad.Focus();
                valor = true;
            }
            if (string.IsNullOrEmpty(txbProveedor.Text))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Proveedor";
                txbProveedor.Focus();
                txbProveedor.BackColor = Color.LightCoral;
                valor = true;
            }
            if (string.IsNullOrEmpty(txbAlbaran.Text))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Albaran";
                txbAlbaran.Focus();
                txbAlbaran.BackColor = Color.LightCoral;
                valor = true;
            }
            if(valor==false) {
                mensaje = "Entrada introducida correctamente";
                productoDAO.InsertarEntrada(cmbProductos.Text, dtpFechaEntrada.Value.ToString("yyyy-MM-dd"), txbLote.Text, txbAlbaran.Text, txbProveedor.Text, dtpCaducidad.Value.ToString("yyyy-MM-dd"), txbCantidad.Text);
                productoDAO.cerrarConexion();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(mensaje+".","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
