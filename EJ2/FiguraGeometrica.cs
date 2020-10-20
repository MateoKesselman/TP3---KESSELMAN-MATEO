using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    /// <summary>
    /// Clase que representa una Figura Geométrica.
    /// </summary>
    public abstract class FiguraGeometrica
    {
        /// <summary>
        /// Calcula el área de la figura geométrica.
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularArea();

        /// <summary>
        /// Calcula el perímetro de la figura geométrica.
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularPerimetro();
    }

}