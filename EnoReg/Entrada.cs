using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Entrada : Registro
    {
        private string proveedor;
        private DateTime caducidad;
        private string albaran;


        public Entrada(string proveedor, DateTime caducidad, string albaran, DateTime fecha, string lote, double cantidad, string observaciones) : base(fecha, lote, cantidad, observaciones)
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
