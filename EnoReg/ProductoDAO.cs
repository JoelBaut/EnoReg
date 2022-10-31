using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnoReg
{
    internal class ProductoDAO
    {
        ConexionDB conexionDB = null;

        public ProductoDAO()
        {
            conexionDB = new ConexionDB();
            conexionDB.Insertar("INSERT INTO `producto`(`nombre`, `unidad`) VALUES ('Mosto','L');");
        }
    }
}
