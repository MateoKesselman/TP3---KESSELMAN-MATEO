using System;
using System.Collections.Generic;
using System.Text;

namespace EJ1
{
    /// <summary>
    /// Clase que representa una veterinaria de animales.
    /// </summary>
    public class Veterinaria
    {
        /// <summary>
        /// Imprime por pantalla el ruido de los animáles del arreglo que se brinda al método como parámetro.
        /// </summary>
        /// <param name="pAnimales"> Arreglo de animales. </param>
        public void AceptarAnimales(Animal[] pAnimales)
        {
            foreach (Animal animal in pAnimales)
            {
                animal.HacerRuido();
            }
        }
    }
}
