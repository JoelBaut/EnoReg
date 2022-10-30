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
        private ArrayList Entradas = new ArrayList();
        private ArrayList Salidas = new ArrayList();

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
        public ArrayList Entradas1 { get => Entradas; set => Entradas = value; }
        public ArrayList Salidas1 { get => Salidas; set => Salidas = value; }

        public void modificarStock(double cantidad) { 
            this.stock += cantidad;
        }
        /*public void añadiirEnetrada(Entrada e) {
            Entradas.Add(e);
        }
        public void añadiirSalidas(Salidas s)
        {
            Salidas.Add(s);
        }*/

    }
}
