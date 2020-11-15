using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*We use a "m" to specify a decimal number*/
            Cerveza oCerverza = new Cerveza(5, 6.5M, 30);
            oCerverza.Fermentacion();
        }
    }
}
