using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            string sql = "select fecha_entrada Fecha, nombre Nombre, proveedor Proveedor, lote Lote, fecha_caducidad Caducidad, albaran Albaran,FORMAT(cantidad,3) Entrada,'-' Salida, FORMAT(stock,3) Stock, '-' Destino, '-' Observaciones" +
                " from producto_entrada, producto" +
                " where producto_entrada.id_producto = producto.id_producto" +
                " Union" +
                " select fecha_salida Fecha, nombre Nombre, '-' Proveedor, lote Lote, '-'Caducidad, '-'Albaran,'-'Entrada,FORMAT(cantidad,3) Salida, FORMAT(stock,3) Stock, destino Destino, observaciones Observaciones" +
                " from producto_salida, producto" +
                " where producto_salida.id_producto = producto.id_producto" +
                " order by fecha DESC;";
            return conexionDB.Select(sql);
        }
        public MySqlDataReader ObtenerUnidad(string nombreProducto)
        {
            string sql = "select unidad from producto where nombre='" + nombreProducto + "'";
            return conexionDB.Select(sql);
        }
       public double ObtenerStock(String nombreProducto)
        {
            double stock =-1;
            string sql = "select stock from producto where nombre='" + nombreProducto + "';";
            MySqlDataReader rd = conexionDB.Select(sql);
            while (rd.Read()) {
                stock = rd.GetDouble(0);
            }
            return stock;
        } 

        public void InsertarProducto(String nombre, string unidad, byte[] image)
        {

            string sql = "INSERT INTO `producto`(`nombre`, `unidad`, `imagen`) VALUES ('" + nombre + "', '" + unidad + "',@pic);";
            
            conexionDB.InsertarProducto(sql,image);
        }
        public void InsertarEntrada(String nombre,string fecha,String lote, string Albaran, string proveedor, string fcadudidad,String cantidad ) {

            string sql = "INSERT INTO `producto_entrada`(`id_producto`, `fecha_entrada`, `lote`, `albaran`, `proveedor`, `fecha_caducidad`, `cantidad`) VALUES ((SELECT id_producto from producto WHERE nombre='"+ nombre + "'),'"+ fecha+"','"+lote+ "','"+ Albaran + "','"+ proveedor + "','"+ fcadudidad + "','"+ cantidad + "');";
            conexionDB.Insertar(sql);
            sql = "Update producto set stock = stock + "+ cantidad + " where id_producto = (SELECT id_producto from producto WHERE nombre='" + nombre + "')";
            conexionDB.Update(sql);
        }
        public void InsertarSalida(string nombre, string fecha, string lote, string cantidad, string destino, string observaciones)
        {
            string sql = "INSERT INTO `producto_salida`(`id_producto`, `fecha_salida`, `lote`, `cantidad`, `destino`, `observaciones`) VALUES ((SELECT id_producto from producto WHERE nombre='"+ nombre + "'),'"+ fecha+ "','"+lote+ "','"+ cantidad + "','"+ destino + "','"+ observaciones + "');";
            conexionDB.Insertar(sql);
            sql = "Update producto set stock = stock - " + cantidad + " where id_producto = (SELECT id_producto from producto WHERE nombre='" + nombre + "')";
            conexionDB.Update(sql);
        }
        public MySqlDataReader Cargarproductos() {
            string sql = "Select id_producto,nombre from producto";
            return conexionDB.Select(sql);

        }
        public MySqlDataReader CargarNombres(String nombre)
        {            
            string sql = "Select nombre from producto where nombre='"+nombre+"'";
            return conexionDB.Select(sql);

        }
        public MySqlDataReader CargarImagen(String nombre)
        {
            string sql = "Select imagen from producto where nombre = '"+nombre+"'";
            return conexionDB.Select(sql);
        }

        internal IDataReader CargarFiltro(string registro, string fechaInicial, string FechaFinal, string Producto, string Destino,string Lote)
        {
            string sql;
            string consultaStringProducto;
            string consultaStringDestino;
            string consultaStringFechaSalida;
            string consultaStringFechaEntrada;
            string consultaStringLote;
            if (Producto.Equals("<Cualquiera>"))
            {
                consultaStringProducto = "";
            }
            else {
                consultaStringProducto = "and producto.id_producto = (SELECT id_producto from producto WHERE nombre = '" + Producto + "') ";
            }

            if (Destino.Equals(""))
            {
                consultaStringDestino = "";
            }
            else
            {
                consultaStringDestino = "and `destino` =  '" + Destino + "' ";
            }
            if (Lote.Equals(""))
            {
                consultaStringLote = "";
            }
            else
            {
                consultaStringLote = "and `lote` =  '" + Lote + "' ";
            }

            consultaStringFechaEntrada = "and `fecha_entrada` between '" + fechaInicial + "' and '" + FechaFinal + "' ";
            consultaStringFechaSalida = "and `fecha_salida` between '" + fechaInicial + "' and '" + FechaFinal + "' ";


            if (registro.Equals("Entradas/Salidas"))
            {
                sql = "select fecha_entrada Fecha, nombre Nombre, proveedor Proveedor, lote Lote, fecha_caducidad Caducidad, albaran Albaran,FORMAT(cantidad,3) Entrada,'-' Salida, FORMAT(stock,3) Stock, '-' Destino, '-' Observaciones" +
                   " from producto_entrada, producto" +
                   " where producto_entrada.id_producto = producto.id_producto " + consultaStringProducto + consultaStringFechaEntrada + consultaStringLote +
                   " Union" +
                   " select fecha_salida Fecha, nombre Nombre, '-' Proveedor, lote Lote, '-'Caducidad, '-'Albaran,'-'Entrada,FORMAT(cantidad,3) Salida, FORMAT(stock,3) Stock, destino Destino, observaciones Observaciones" +
                   " from producto_salida, producto" +
                   " where producto_salida.id_producto = producto.id_producto " + consultaStringProducto + consultaStringFechaSalida + consultaStringLote+
                   " order by fecha DESC;";

            } else if (registro.Equals("Entradas")) {
                sql = "select fecha_entrada Fecha, nombre Nombre, proveedor Proveedor, lote Lote, fecha_caducidad Caducidad, albaran Albaran,FORMAT(cantidad,3) Entrada,'-' Salida, FORMAT(stock,3) Stock, '-' Destino, '-' Observaciones" +
                   " from producto_entrada, producto" +
                   " where producto_entrada.id_producto = producto.id_producto " + consultaStringProducto + consultaStringFechaEntrada + consultaStringLote +
                   " order by fecha DESC;";
            }
            else {
                sql = " select fecha_salida Fecha, nombre Nombre, '-' Proveedor, lote Lote, '-'Caducidad, '-'Albaran,'-'Entrada,FORMAT(cantidad,3) Salida, FORMAT(stock,3) Stock, destino Destino, observaciones Observaciones" +
                   " from producto_salida, producto" +
                   " where producto_salida.id_producto = producto.id_producto " + consultaStringProducto + consultaStringFechaSalida + consultaStringDestino + consultaStringLote +
                   " order by fecha DESC;";
            }


            return conexionDB.Select(sql);
        }
        internal void InsertarProducto(string nombre, string unidad)
        {

            string sql = "INSERT INTO `producto`(`nombre`, `unidad`) VALUES ('" + nombre + "', '" + unidad + "');";

            conexionDB.InsertarProducto(sql);
        }

        internal MySqlDataReader CargarObservaciones(string nombre)
        {
            string sql = "Select observaciones from producto_salida where id_producto = (SELECT id_producto from producto WHERE nombre = '" + nombre + "') ";
            return conexionDB.Select(sql);
        }
    }
}
