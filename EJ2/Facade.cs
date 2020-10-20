using System;
using System.Collections.Generic;
using System.Text;

namespace EJ2
{
    /// <summary>
    /// Clase que implementa el Controlador de Fachada.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Obtiene la distancia entre dos puntos.
        /// </summary>
        /// <param name="pX1"> Coordena X del primer punto. </param>
        /// <param name="pY1"> Coordena Y del primer punto. </param>
        /// <param name="pX2"> Coordena X del segundo punto. </param>
        /// <param name="pY2"> Coordena Y del segundo punto. </param>
        /// <returns></returns>
        public double ObtenerDistanciaEntreLosDosPuntos(double pX1, double pY1, double pX2, double pY2)
        {
            var punto1 = new Punto(pX1, pY1);
            var punto2 = new Punto(pX2, pY2);
            return punto1.CalcularDistanciaDesde(punto2);
        }

        /// <summary>
        /// Obtiene el Perímetro del Triangulo.
        /// </summary>
        /// <param name="pX1"> Coordena X del primer punto del Triangulo. </param>
        /// <param name="pY1"> Coordena Y del primer punto del Triangulo. </param>
        /// <param name="pX2"> Coordena X del segundo punto del Triangulo. </param>
        /// <param name="pY2"> Coordena Y del segundo punto del Triangulo. </param>
        /// <param name="pX3"> Coordena X del tercer punto del Triangulo. </param>
        /// <param name="pY3"> Coordena Y del tercer punto del Triangulo. param>
        /// <returns></returns>
        public double ObtenerPerimetroDelTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            var triangulo = new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3));
            return triangulo.CalcularPerimetro();
        }

        /// <summary>
        /// Obtiene el Área del Triangulo.
        /// </summary>
        /// <param name="pX1"> Coordena X del primer punto del Triangulo. </param>
        /// <param name="pY1"> Coordena Y del primer punto del Triangulo. </param>
        /// <param name="pX2"> Coordena X del segundo punto del Triangulo. </param>
        /// <param name="pY2"> Coordena Y del segundo punto del Triangulo. </param>
        /// <param name="pX3"> Coordena X del tercer punto del Triangulo. </param>
        /// <param name="pY3"> Coordena Y del tercer punto del Triangulo. param>
        /// <returns></returns>
        public double ObtenerAreaDelTriangulo(double pX1, double pY1, double pX2, double pY2, double pX3, double pY3)
        {
            var triangulo = new Triangulo(new Punto(pX1, pY1), new Punto(pX2, pY2), new Punto(pX3, pY3));
            return triangulo.CalcularArea();
        }

        /// <summary>
        /// Obtiene el Perímetro del Circulo.
        /// </summary>
        /// <param name="pX"> Coordenada X del Centro del Circulo. </param>
        /// <param name="pY"> Coordenada Y del Centro del Circulo. </param>
        /// <param name="pRadio"> Radio del Ciruclo. </param>
        /// <returns></returns>
        public double ObtenerPerimetroDelCirculo(double pX, double pY, double pRadio)
        {
            var circulo = new Circulo(pX, pY, pRadio);
            return circulo.CalcularPerimetro();
        }

        /// <summary>
        /// Obtiene el Área del Circulo.
        /// </summary>
        /// <param name="pX"> Coordenada X del Centro del Circulo. </param>
        /// <param name="pY"> Coordenada Y del Centro del Circulo. </param>
        /// <param name="pRadio"> Radio del Ciruclo </param>
        /// <returns></returns>
        public double ObtenerAreaDelCirculo(double pX, double pY, double pRadio)
        {
            var circulo = new Circulo(pX, pY, pRadio);
            return circulo.CalcularArea();
        }

    }
}
