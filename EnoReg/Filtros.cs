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
            cargarCombo(dr);
            dtp_dateLast.MaxDate = DateTime.Today;
        }
        private void cargarCombo(MySqlDataReader dr)
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
            cbx_producto.Items.Insert(0, new { id_marca = 0, nombre = "<Cualquiera>" });
            cbx_producto.SelectedIndex = 0;
        }
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
