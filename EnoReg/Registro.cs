using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Registro
    {
        private DateTime fecha;
        private string lote;
        private double cantidad;
        private string observaciones;


        public Registro(DateTime fecha, string lote, double cantidad, string observaciones)

        {
            this.fecha = fecha;
            this.lote = lote;
            this.cantidad = cantidad;
            this.observaciones = observaciones;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Lote { get => lote; set => lote = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
