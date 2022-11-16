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
            cargarCombo(dr);
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
            productoDAO.InsertarEntrada(cmbProductos.Text, dtpFechaEntrada.Value.ToString("yyyy-MM-dd"), cmbLote.Text, cmbAlbaran.Text,cmbProveedor.Text, dtpCaducidad.Value.ToString("yyyy-MM-dd"), cmbCantidad.Text);
            productoDAO.cerrarConexion();
            DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
