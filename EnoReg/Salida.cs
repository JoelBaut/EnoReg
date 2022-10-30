using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Salida : Registro
    {
        private String destino;

        public Salida(string destino, DateTime fecha, String lote, double cantidad, String observaciones):base(fecha, lote, cantidad, observaciones)    
        {
            this.destino = destino;
        }

        public string Destino { get => destino; set => destino = value; }
    }
}
