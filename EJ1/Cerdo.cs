using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa un cerdo. 
    /// </summary>
    public class Cerdo : Animal
    {
        /// <summary>
        /// Imprime por pantalla el ruido que hace el cerdo.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Oinc");
        }
    }
}
