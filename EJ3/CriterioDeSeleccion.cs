using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    /// <summary>
    /// Clase que implementan estrategias para la elección de un turno.
    /// </summary>
    public abstract class CriterioDeSeleccion
    {
        /// <summary>
        /// Método que selecciona el próximo turno correspondiente.
        /// </summary>
        /// <param name="pTrunos"> Arreglo de turnos disponibles. </param>
        /// <returns></returns>
        public abstract Turno SeleccionDelProximoTurno(Turno[] pTrunos);
    }
}