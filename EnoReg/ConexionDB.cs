using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EnoReg
{
    internal class ConexionDB
    {
        MySqlConnection conn = null;

        public ConexionDB()
        {
           
        }
        public void crearConexion() {
            conn = new MySqlConnection(Properties.Settings.Default.ConexionDB);
            conn.Open();
        }
        public void cerrarConexion() {
            conn.Close(); 
        }
        public MySqlDataReader CargarProductos(String sentenciaSQL)
        {
            crearConexion();
            MySqlCommand cmd = new MySqlCommand(sentenciaSQL, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            cerrarConexion();

            return dataReader;
        }
        public MySqlDataReader CargarEntrada(String sentenciaSQL)
        {
            crearConexion();
            MySqlCommand cmd = new MySqlCommand(sentenciaSQL, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            cerrarConexion();

            return dataReader;
        }
        public MySqlDataReader CargarSalida(String sentenciaSQL)
        {
            crearConexion();
            MySqlCommand cmd = new MySqlCommand(sentenciaSQL, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            cerrarConexion();

            return dataReader;
        }

        public void Insertar(String sentenciaSQL)
        {
            crearConexion();
            MySqlCommand cmd = new MySqlCommand(sentenciaSQL, conn);
            cmd.ExecuteNonQuery();
            cerrarConexion();
        }


    }
}
