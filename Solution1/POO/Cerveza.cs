using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Cerveza
    {
        /*We use getters and setter to allow the
          class atribute asing a diferent value.*/
        public int Amargor { get; set; }
        public decimal Alcohol { get; set; }
        public int TiempoFernentacion { get; set; }

        public Cerveza(int Amargor, decimal Alcohol, int TiempoFernentacion)
        {
            this.Amargor = Amargor;
            this.Alcohol = Alcohol;
            this.TiempoFernentacion = TiempoFernentacion;
        }

        public void Fermentacion()
        {
            Console.WriteLine("Se fermentó!");
        }
    }
}
