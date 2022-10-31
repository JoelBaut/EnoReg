using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Salida : Registro
    {
        private string destino;

        public Salida(string destino, DateTime fecha, string lote, double cantidad, string observaciones):base(fecha, lote, cantidad, observaciones)    
        {
            this.destino = destino;
        }

        public string Destino { get => destino; set => destino = value; }
    }
}
