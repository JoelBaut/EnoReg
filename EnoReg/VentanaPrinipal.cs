using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            // añadir unidad a los valores y colores
            string nombre;
            string unidad="";
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
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(218,255,202);
                }
                if (!dtgprincipal.Rows[i].Cells[7].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].Cells[7].Value += " " + unidad;
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
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
            AñadirEntrada en = new AñadirEntrada(productoDAO, productoDAO.Cargarproductos(), btnMostrarTodo.Location);
            en.ShowDialog();
            if (en.DialogResult == DialogResult.OK)
            {
                CargarDataGrid();
            }
        }

        private void btnAñadirSalida_Click(object sender, EventArgs e)
        {
            AñadirSalida sa = new AñadirSalida(productoDAO, productoDAO.Cargarproductos(), btnMostrarTodo.Location);
            sa.ShowDialog();
            if (sa.DialogResult == DialogResult.OK)
            {
                CargarDataGrid();
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {

            Filtros filtros = new Filtros(productoDAO, productoDAO.Cargarproductos(), btnMostrarTodo.Location, dtgprincipal);
            filtros.ShowDialog();

        }

        public void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProductos nuevoProductos = new NuevoProductos(productoDAO, btnMostrarTodo.Location);
            nuevoProductos.ShowDialog();
        }

        private void dtgprincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dtgprincipal.CurrentCell.RowIndex;
            string nombre = (string)dtgprincipal.Rows[fila].Cells[1].Value;

            MySqlDataReader dataReader =  productoDAO.CargarImagen(nombre);

            if (dataReader.Read())
            {
                if (dataReader["imagen"] != DBNull.Value)
                {
                    // recuperamos la imagen...
                    byte[] imagenByte = (byte[])dataReader["imagen"];
                    MemoryStream ms = new MemoryStream(imagenByte);
                    picImagenProducto.Image = Image.FromStream(ms);
                }
                else
                {
                    picImagenProducto.Image = null;
                }
            }
        }

        private void dtgprincipal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // añadir colores cuando cambian el modo de ordenamiento al pulsar en el header de las columnas
            for (int i = 0; i < dtgprincipal.RowCount; i++)
            {
                if (!dtgprincipal.Rows[i].Cells[6].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(218, 255, 202);
                }
                if (!dtgprincipal.Rows[i].Cells[7].Value.Equals("-"))
                {
                    dtgprincipal.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                }
            }
        }
    }
}
