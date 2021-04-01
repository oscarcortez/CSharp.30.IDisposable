using Models;
using System;

namespace ConsoleApp4IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EjemploClaseDisposable ej = new EjemploClaseDisposable())
            {
                EjemploClaseDisposable.Metodo1Ejemplo();
            };

            EjemploClaseDisposable ej2 = new();
            EjemploClaseDisposable.Metodo1Ejemplo();
            ej2.Dispose();

        }
    }
}
