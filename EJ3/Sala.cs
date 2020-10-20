using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    /// <summary>
    /// Clase que representa una Sala.
    /// </summary>
    public class Sala
    {
        private Turno[] iTurnos;
        private CriterioDeSeleccion iCriterioDeSeleccion;

        /// <summary>
        /// Instancia un objeto de la clase Sala.
        /// </summary>
        /// <param name="pTurnos"> Arreglo de Turnos disponibles. </param>
        /// <param name="pCriterioDeSeleccion"> Estrategia empleada para la selección de próximo turno. </param>
        public Sala (Turno[] pTurnos, CriterioDeSeleccion pCriterioDeSeleccion)
        {
            this.iTurnos = pTurnos;
            this.iCriterioDeSeleccion = pCriterioDeSeleccion;
        }

        /// <summary>
        /// Método que obtiene el próximo turno correspondiente.
        /// </summary>
        /// <returns></returns>
        public Turno ObtenerProximoTurno()
        {
            Turno proximoTurno = this.iCriterioDeSeleccion.SeleccionDelProximoTurno(this.iTurnos);
            if (proximoTurno != null)
            {
                this.iTurnos[proximoTurno.Numero].Atendido = true;
            }
            return proximoTurno;
        }
    }
}
