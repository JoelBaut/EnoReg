using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnoReg
{
    public partial class VentanaPrinipal : Form
    {
        private ProductoDAO productoDAO;
        public VentanaPrinipal()
        {
            InitializeComponent();
        }

        private void VentanaPrinipal_Load(object sender, EventArgs e)
        {
            this.Font = Properties.Settings.Default.Font;
            this.BackColor = Properties.Settings.Default.ColorFondo;
            this.ForeColor = Properties.Settings.Default.ColorLetra;
            productoDAO = new ProductoDAO();
            CargarDataGrid();
            // localizacion del boton mostrar todo
            // Point localizacion = btnMostrarTodo.FindForm().PointToClient(
            //    btnMostrarTodo.Parent.PointToScreen(btnMostrarTodo.Location));
            // btnFiltros.Location = localizacion;
        }

        private void CargarDataGrid()
        {
            // cargar datos 
            DataTable dt = new DataTable();
            dt.Load(productoDAO.CargarTodo());
            dtgprincipal.DataSource = dt;
            productoDAO.cerrarConexion();

            // añadir unidad a los valores
            String nombre;
            String unidad="";
            MySqlDataReader dr;
            for (int i = 0; i < dtgprincipal.RowCount; i++)
            {
                nombre = (string)dtgprincipal.Rows[i].Cells[1].Value;
                dr = productoDAO.ObtenerUnidad(nombre);
                while (dr.Read()) {
                    unidad = dr.GetString(0);
                }
                if (!dtgprincipal.Rows[i].Cells[6].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].Cells[6].Value += " "+unidad;
                }
                if (!dtgprincipal.Rows[i].Cells[7].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].Cells[7].Value += " " + unidad;
                }
                dtgprincipal.Rows[i].Cells[8].Value += " " + unidad;
            }

        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
        private void btnAñadirEntrada_Click(object sender, EventArgs e)
        {
            AñadirEntrada en = new AñadirEntrada(productoDAO, productoDAO.Cargarproductos());
            en.ShowDialog();
        }

        private void btnAñadirSalida_Click(object sender, EventArgs e)
        {
            AñadirSalida sa = new AñadirSalida(productoDAO, productoDAO.Cargarproductos());
            sa.ShowDialog();
            if (sa.DialogResult == DialogResult.OK)
            {
                CargarDataGrid();
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {

            Filtros filtros = new Filtros(productoDAO, productoDAO.Cargarproductos());
            filtros.ShowDialog();

        }

        public void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductos nuevoProductos = new NuevoProductos(productoDAO);
            nuevoProductos.ShowDialog();
        }
    }
}
