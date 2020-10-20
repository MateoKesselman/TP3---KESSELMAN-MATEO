using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{

    /// <summary>
    /// Clase que representa un Punto.
    /// </summary>
    public class Punto
    {
        private double iX;
        private double iY;

        /// <summary>
        /// Instancia un objeto de la clase Punto.
        /// </summary>
        /// <param name="pX"> Coordenada X del punto. </param>
        /// <param name="pY"> Coordenada Y del punto. </param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        /// <summary>
        /// Coordenada X del punto.
        /// </summary>
        public double X
        {
            get { return this.iX; }
            set { this.iX = value; }
        }

        /// <summary>
        /// Coordenada Y del punto.
        /// </summary>
        public double Y
        {

            get { return this.iY; }
            set { this.iY = value; }
        }

        /// <summary>
        /// Calcula la distancia entre dos objetos Punto.
        /// </summary>
        /// <param name="pPunto"> Punto del cual se desea calcular la distancia. </param>
        /// <returns></returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double a = Math.Pow((pPunto.X - this.X), 2);
            double b = Math.Pow((pPunto.Y - this.Y), 2);
            return Math.Sqrt(a + b);
        }
    }
}
