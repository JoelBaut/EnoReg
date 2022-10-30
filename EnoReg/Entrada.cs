using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Entrada : Registro
    {
        private String proveedor;
        private DateTime caducidad;
        private String albaran;


        public Entrada(string proveedor, DateTime caducidad, string albaran, DateTime fecha, String lote, double cantidad, String observaciones) : base(fecha, lote, cantidad, observaciones)
        {
            this.proveedor = proveedor;
            this.caducidad = caducidad;
            this.albaran = albaran;
        }

        public string Proveedor { get => proveedor; set => proveedor = value; }
        public DateTime Caducidad { get => caducidad; set => caducidad = value; }
        public string Albaran { get => albaran; set => albaran = value; }
    }
}
