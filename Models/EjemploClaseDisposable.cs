using System;

namespace Models
{
    public class EjemploClaseDisposable : IDisposable
    {
        public static void Metodo1Ejemplo()
        {
            Console.WriteLine("Ejemplo");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
