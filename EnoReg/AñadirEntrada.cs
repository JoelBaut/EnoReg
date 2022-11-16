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
        public AñadirEntrada(ProductoDAO productoDAO, MySqlDataReader mySqlDataReader)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            cargarCombo(dr);
            dtpFechaEntrada.MaxDate = DateTime.Today;
            dtpCaducidad.MinDate = DateTime.Today;
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

        private void btnAceptarEntrada_Click(object sender, EventArgs e)
        {
            productoDAO.InsertarEntrada(cmbProductos.Text, dtpFechaEntrada.Value.ToString("yyyy-MM-dd"), txbLote.Text, txbAlbaran.Text,txbProveedor.Text, dtpCaducidad.Value.ToString("yyyy-MM-dd"), txbCantidad.Text);
            productoDAO.cerrarConexion();
            DialogResult = DialogResult.OK;
            this.Hide();

            // validaciones

            // productos
            if (cmbProductos.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Tienes que seleccionar un producto",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbProductos.Focus();
            }

            // lote
            if (string.IsNullOrEmpty(txbLote.Text))
            {
                MessageBox.Show("Rellena el campo Lote",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txbLote.Focus();
                txbLote.BackColor = Color.LightCoral;
            }

            // cantidad
            if (string.IsNullOrEmpty(txbCantidad.Text))
            {
                MessageBox.Show("Rellena el campo Cantidad",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txbCantidad.Focus();
                txbCantidad.BackColor = Color.LightCoral;
            }

            // proveedor
            if (string.IsNullOrEmpty(txbProveedor.Text))
            {
                MessageBox.Show("Rellena el campo Proveedor",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txbProveedor.Focus();
                txbProveedor.BackColor = Color.LightCoral;
            }

            // albaran
            if (string.IsNullOrEmpty(txbAlbaran.Text))
            {
                MessageBox.Show("Rellena el campo Albarán",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txbAlbaran.Focus();
                txbAlbaran.BackColor = Color.LightCoral;
            }
        }
    }
}
