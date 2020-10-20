using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa un gato.
    /// </summary>
    public class Gato : Animal
    {
        /// <summary>
        /// Imprime por pantalla el ruido que hace el gato.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
}
