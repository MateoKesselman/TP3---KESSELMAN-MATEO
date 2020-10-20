using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa un animal.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Imprime por pantalla el mensaje "corriendo".
        /// </summary>
        public void Correr() { Console.WriteLine("corriendo");}

        /// <summary>
        /// Imprime por pantalla el mensaje "saltando".
        /// </summary>
        public void Saltar() { Console.WriteLine("saltando");}

        /// <summary>
        /// Imprime por pantalla el ruido del correspondiente animal.
        /// </summary>
        public abstract void HacerRuido();
    }
}
