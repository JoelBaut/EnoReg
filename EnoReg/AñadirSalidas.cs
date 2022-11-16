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
        public AñadirSalida(ProductoDAO productoDAO, MySqlDataReader mySqlDataReader)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            cargarCombo(dr);
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

            
        }

    }
}
