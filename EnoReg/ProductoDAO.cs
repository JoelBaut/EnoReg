using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EnoReg
{
    public class ProductoDAO
    {
        ArrayList productos = new ArrayList();
        ConexionDB conexionDB = null;

        public ProductoDAO()
        {
            conexionDB = new ConexionDB();
        }
        public void cerrarConexion() {
            conexionDB.cerrarConexion();
        }
        public MySqlDataReader CargarTodo()
        {
            String sql = "select fecha_entrada Fecha, nombre Nombre, proveedor Proveedor, lote Lote, fecha_caducidad Caducidad, albaran Albaran,FORMAT(cantidad,3) Entrada,'-' Salida, FORMAT(stock,3) Stock, '-' Destino, '-' Observaciones" +
                " from producto_entrada, producto" +
                " where producto_entrada.id_producto = producto.id_producto" +
                " Union" +
                " select fecha_salida Fecha, nombre Nombre, '-' Proveedor, lote Lote, '-'Caducidad, '-'Albaran,'-'Entrada,FORMAT(cantidad,3) Salida, FORMAT(stock,3) Stock, destino Destino, observaciones Observaciones" +
                " from producto_salida, producto" +
                " where producto_salida.id_producto = producto.id_producto" +
                " order by fecha DESC;";
            return conexionDB.Select(sql);
        }
        public void ObtenerUnidad(String nombreProducto)
        {
            String sql = "select unidad from producto where nombre='" + nombreProducto + "'";
            // conexionDB.
        }
       public double ObtenerStock(String nombreProducto)
        {
            double stock =-1;
            String sql = "select stock from producto where nombre='" + nombreProducto + "';";
            MySqlDataReader rd = conexionDB.Select(sql);
            while (rd.Read()) {
                stock = rd.GetDouble(0);
            }
            return stock;
        } 

        public void InsertarProducto(String nombre, String unidad, byte[] image)
        {

            String sql = "INSERT INTO `producto`(`nombre`, `unidad`, `imagen`) VALUES ('" + nombre + "', '" + unidad + "',@pic);";
            
            conexionDB.InsertarProducto(sql,image);
        }
        public void InsertarEntrada(String nombre,string fecha,String lote, String Albaran, String proveedor, string fcadudidad,String cantidad ) {

            String sql = "INSERT INTO `producto_entrada`(`id_producto`, `fecha_entrada`, `lote`, `albaran`, `proveedor`, `fecha_caducidad`, `cantidad`) VALUES ((SELECT id_producto from producto WHERE nombre='"+ nombre + "'),'"+ fecha+"','"+lote+ "','"+ Albaran + "','"+ proveedor + "','"+ fcadudidad + "','"+ cantidad + "');";
            conexionDB.Insertar(sql);
            sql = "Update producto set stock = stock + "+ cantidad + " where id_producto = (SELECT id_producto from producto WHERE nombre='" + nombre + "')";
            conexionDB.Update(sql);
        }
        public void InsertarSalida(string nombre, string fecha, string lote, string cantidad, string destino, string observaciones)
        {
            String sql = "INSERT INTO `producto_salida`(`id_producto`, `fecha_salida`, `lote`, `cantidad`, `destino`, `observaciones`) VALUES ((SELECT id_producto from producto WHERE nombre='"+ nombre + "'),'"+ fecha+ "','"+lote+ "','"+ cantidad + "','"+ destino + "','"+ observaciones + "');";
            conexionDB.Insertar(sql);
            sql = "Update producto set stock = stock - " + cantidad + " where id_producto = (SELECT id_producto from producto WHERE nombre='" + nombre + "')";
            conexionDB.Update(sql);
        }
        public MySqlDataReader Cargarproductos() {
            String sql = "Select id_producto,nombre from producto";
            return conexionDB.Select(sql);

        }
    }
}
