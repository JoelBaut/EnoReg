using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnoReg
{
    public class ProductoDAO
    {
        ConexionDB conexionDB = null;

        public ProductoDAO()
        {
            conexionDB = new ConexionDB();
        }
        public void cerrarConexion() {
            conexionDB.cerrarConexion();
        }
        public MySqlDataReader CargarTodo() {
            String sql = "select fecha_entrada Fecha, nombre Nombre, proveedor Proveedor, lote Lote, fecha_caducidad Caducidad, albaran Albaran,cantidad Entrada,'-' Salida, stock Stock, '-' Destino, '-' Observaciones" +
                " from producto_entrada, producto" +
                " where producto_entrada.id_producto = producto.id_producto" +
                " Union" +
                " select fecha_salida Fecha, nombre Nombre, '-' Proveedor, lote Lote, '-'Caducidad, '-'Albaran,'-'Entrada,cantidad Salida, stock Stock, destino Destino, observaciones Observaciones" +
                " from producto_salida, producto" +
                " where producto_salida.id_producto = producto.id_producto" +
                " order by fecha DESC;";
            return conexionDB.Select(sql);
        }

        public void InsertarProducto(String nombre, String unidad, String rutaImagen)
        {

            String sql = "INSERT INTO `producto`(`nombre`, `unidad`, `imagen`) VALUES ('" + nombre + "', '" + unidad + "', LOAD_FILE('"+ rutaImagen + "'));";
            conexionDB.Insertar(sql);
        }
        public void InsertarEntrada() {
            
        }
        public void InsertarSalida()
        {

        }
    }
}
