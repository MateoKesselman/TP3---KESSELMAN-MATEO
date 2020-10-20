using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = { new Gato(), new Perro(), new Vaca(), new Cerdo() };
            Veterinaria veterinaria = new Veterinaria();
            veterinaria.AceptarAnimales(animales);
        }
    }
}
