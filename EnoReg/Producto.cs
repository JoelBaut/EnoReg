using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnoReg
{
    internal class Producto
    {
        private int id;
        private string name;
        private double stock;
        private string unidad;
        private Bitmap image;
        private ArrayList entradas = new ArrayList();
        private ArrayList salidas = new ArrayList();

        public Producto()
        {
        }

        public Producto(int id, string name, string unidad, Bitmap image)
        {
            this.id = id;
            this.name = name;
            this.stock = 0;
            this.unidad = unidad;
            this.image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Stock { get => stock; set => stock = value; }
        public string Unidad { get => unidad; set => unidad = value; }
        public Bitmap Image { get => image; set => image = value; }
        public ArrayList Entradas { get => entradas; set => entradas = value; }
        public ArrayList Salidas { get => salidas; set => salidas = value; }

        public void modificarStock(double cantidad) { 
            this.stock += cantidad;
        }
        public void añadiirEnetrada(Entrada e) {
            Entradas.Add(e);
        }
        public void añadiirSalidas(Salida s)
        {
            Salidas.Add(s);
        }

    }
}
