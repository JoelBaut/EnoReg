using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnoReg
{
    public partial class AñadirSalida : Form
    {
        private ProductoDAO productoDAO;
        MySqlDataReader dr;
        public AñadirSalida(ProductoDAO productoDAO, MySqlDataReader mySqlDataReader, Point location)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;            
            cargarCombo(dr);
            dtpFechaSalida.MaxDate = DateTime.Today;
        }
        private void cargarCombo(MySqlDataReader dr)
        {
            while (dr.Read())
            {
                cmbProductos.Items.Add(new
                {
                    id = dr["id_producto"],
                    nombre = dr["nombre"]
                });
            }
            cmbProductos.DisplayMember = "nombre";
            cmbProductos.ValueMember = "id";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = "Tienes que rellenar o seleccionar:";
            Boolean valor = false;
            double cantidaNumerico =0;
            string cantidad ="";

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
            else
            {
                cmbProductos.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(txbLote.Text))
            {
                if (mensaje.Length > 34)
                {
                    mensaje += ",";
                }
                mensaje += " Lote";          
                txbLote.Focus();
                txbLote.BackColor = Color.LightCoral;
                valor = true;
            }
            else
            {
                txbLote.BackColor = Color.White;
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
            else
            {
                cantidad = txbCantidad.Text;
                cantidad = cantidad.Replace(",",".");
                MessageBox.Show(cantidad);
                if (!double.TryParse(cantidad, out cantidaNumerico)) {
                    mensaje += "Canidad [ Recuerde introducir solo numeros ]";
                    valor = true;
                }
                else
                {
                    txbCantidad.BackColor = Color.White;
                }
            }
            if (valor == false &&(productoDAO.ObtenerStock(cmbProductos.Text) - Convert.ToDecimal(cantidad,CultureInfo.InvariantCulture)) <= 0 )
            {
                MessageBox.Show("Se pretende sacar mas productos de los disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valor = true;
            }
            if (valor==false) {
                mensaje = "Salida introducida correctamente";
                productoDAO.InsertarSalida(cmbProductos.Text, dtpFechaSalida.Value.ToString("yyyy-MM-dd"), txbLote.Text, cantidad, txbDestino.Text, txbObservaciones.Text);
                productoDAO.cerrarConexion();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (mensaje.Length > 34)
            {
                MessageBox.Show(mensaje + ".", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void AñadirSalida_Load(object sender, EventArgs e)
        {
            
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            dr = productoDAO.ObtenerUnidad(cmbProductos.Text);
            while (dr.Read())
            {
                lblUnidad.Text = dr.GetString(0);
            }
        }
    }
}
