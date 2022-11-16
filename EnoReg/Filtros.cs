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
    public partial class Filtros : Form
    {
        private ProductoDAO productoDAO;
        MySqlDataReader dr;
        public Filtros(ProductoDAO productoDAO, MySql.Data.MySqlClient.MySqlDataReader mySqlDataReader)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            InitializeComponent();
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            cargarComboProductos(dr);
            cargarComboRegistros();
            dtp_dateLast.MaxDate = DateTime.Today;
        }
        private void cargarComboProductos(MySqlDataReader dr)
        {
            while (dr.Read())
            {
                cbx_producto.Items.Add(new
                {
                    id = dr["id_producto"],
                    nombre = dr["nombre"]
                });
            }
            cbx_producto.DisplayMember = "nombre";
            cbx_producto.ValueMember = "id";

            // añadir opcion cualquier producto
            cbx_producto.Items.Insert(0, new { id = 0, nombre = "<Cualquiera>" });
            cbx_producto.SelectedIndex = 0;
        }
        private void cargarComboRegistros() {
            cbx_registro.Items.Insert(0, new { id = 0, nombre = "Entradas/Salidas" });
            cbx_registro.Items.Insert(1, new { id = 0, nombre = "Entradas" });
            cbx_registro.Items.Insert(2, new { id = 0, nombre = "Salidas" });

            cbx_registro.DisplayMember = "nombre";
            cbx_registro.ValueMember = "id";
            cbx_registro.SelectedIndex = 0;
            
        }
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
