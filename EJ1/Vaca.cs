using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa una vaca.
    /// </summary>
    public class Vaca : Animal
    {
        /// <summary>
        /// Imprime por pantalla el ruido que hace la vaca.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Muu");
        }
    }
}
