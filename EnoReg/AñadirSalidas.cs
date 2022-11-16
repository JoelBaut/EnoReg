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
    public partial class AñadirSalida : Form
    {
        private ProductoDAO productoDAO;
        MySqlDataReader dr;
        public AñadirSalida(ProductoDAO productoDAO, MySqlDataReader mySqlDataReader, Point location)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Location = location;
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

            if (productoDAO.ObtenerStock(cmbProductos.Text) - int.Parse(txbCantidad.Text)<=0) {
                MessageBox.Show("Se pretende sacar mas productos de los disponibles.");
            }
            else {
                productoDAO.InsertarSalida(cmbProductos.Text, dtpFechaSalida.Value.ToString("yyyy-MM-dd"), txbLote.Text, txbCantidad.Text, txbDestino.Text, txbObservaciones.Text);
                productoDAO.cerrarConexion();
                DialogResult = DialogResult.OK;
                this.Hide();
            }

            // validaciones

            // productos
            if(cmbProductos.SelectedIndex.Equals(-1))
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
        }

        private void AñadirSalida_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - this.Size.Width, this.Location.Y);
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
        }
    }
}
