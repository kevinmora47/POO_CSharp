using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            León oLeon = new León();
            oLeon.Correr();
            oLeon.Nombre="Simba";
            oLeon.CantidadDeCarneQueCome = 10;
            Console.WriteLine(oLeon.Nombre, oLeon.CantidadDeCarneQueCome);

            Buitre oBuitre = new Buitre();
            oBuitre.Volar();
            oBuitre.Nombre = "Tambor";
            Console.WriteLine(oBuitre.Nombre);
        }
    }
}
