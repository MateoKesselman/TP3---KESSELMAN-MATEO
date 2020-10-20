using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{

    /// <summary>
    /// Clase Circulo.
    /// </summary>
    public class Circulo : FiguraGeometrica
    {
        private double iRadio;
        private Punto iCentro;

        /// <summary>
        /// Instancia un objeto de la clase Circulo.
        /// </summary>
        /// <param name="pCentro"> Centro del Ciruclo. </param>
        /// <param name="pRadio"> Radio del Ciruclo. </param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iRadio = pRadio;
            this.iCentro = pCentro;
        }

        /// <summary>
        /// Instancia un objeto de la clase Circulo.
        /// </summary>
        /// <param name="pX"> Coordenada X del Centro del Circulo. </param>
        /// <param name="pY"> Coordenada Y del Centro del Circulo. </param>
        /// <param name="pRadio"> Radio del Ciruclo. </param>
        public Circulo(double pX, double pY, double pRadio)
        {

            this.iRadio = pRadio;
            this.iCentro = new Punto(pX, pY);
        }

        /// <summary>
        /// Centro del Circulo.
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
            set { this.iCentro = value; }
        }

        /// <summary>
        /// Radio del Circulo.
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
            set { this.iRadio = value; }
        }

        /// <summary>
        /// Perimetro del Circulo.
        /// </summary>
        public override double CalcularPerimetro()
        {
            return (Math.PI * (2 * this.iRadio)); 
        }

        /// <summary>
        /// Area del Circulo.
        /// </summary>
        public override double CalcularArea()
        {
             return (Math.PI * (Math.Pow(this.iRadio, 2)));
        }
    }
}
