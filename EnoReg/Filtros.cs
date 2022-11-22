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
        DataGridView dtgprincipal;
        MySqlDataReader dr;
        public Filtros(ProductoDAO productoDAO, MySql.Data.MySqlClient.MySqlDataReader mySqlDataReader,Point location, DataGridView dtgprincipal)
        {
            this.productoDAO = productoDAO;
            this.dr = mySqlDataReader;
            this.dtgprincipal = dtgprincipal;
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
            DataTable dt = new DataTable();
            dt.Load(productoDAO.CargarFiltro(cbx_registro.Text,dtp_dateFirst.Value.ToString("yyyy-MM-dd"), dtp_dateLast.Value.ToString("yyyy-MM-dd"), cbx_producto.Text,txb_destino.Text));
            dtgprincipal.DataSource = dt;
            productoDAO.cerrarConexion();

            // añadir unidad a los valores y colores
            string nombre;
            string unidad = "";
            MySqlDataReader dr;
            for (int i = 0; i < dtgprincipal.RowCount; i++)
            {
                nombre = (string)dtgprincipal.Rows[i].Cells[1].Value;
                dr = productoDAO.ObtenerUnidad(nombre);
                while (dr.Read())
                {
                    unidad = dr.GetString(0);
                }
                if (!dtgprincipal.Rows[i].Cells[6].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].Cells[6].Value += " " + unidad;
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(218, 255, 202);
                }
                if (!dtgprincipal.Rows[i].Cells[7].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].Cells[7].Value += " " + unidad;
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
                dtgprincipal.Rows[i].Cells[8].Value += " " + unidad;
            }


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txb_destino_TextChanged(object sender, EventArgs e)
        {
            if (!txb_destino.Text.Equals("")) {
                cbx_registro.SelectedIndex = 2;
            }
            else {
                cbx_registro.SelectedIndex = 0;
            }
        }
    }
}
