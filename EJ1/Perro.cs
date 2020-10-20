using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa un perro.
    /// </summary>
    public class Perro : Animal
    {
        /// <summary>
        /// Imprime por pantalla el ruido que hace el perro.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Guau");
        }
    }
}
