using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    /// <summary>
    /// Clase que representa un Turno.
    /// </summary>
    public class Turno
    {
        private int iNumero;
        private Paciente iPaciente;
        private int iNivelDeUrgencia;
        private DateTime iFechaYHoraDeLlegada;
        private bool iAtendido;

        /// <summary>
        /// Instancia un objeto de la clase Turno.
        /// </summary>
        /// <param name="pNumero"> Número de Turno. </param>
        /// <param name="pPaciente"> Paciente del Turno. </param>
        /// <param name="pNivelDeUrgencia"> Nivel de urgencia del Turno. </param>
        /// <param name="pFechaYHoraDeLlegada"> Fecha y Hora de llegada del paciente. </param>
        public Turno(int pNumero, Paciente pPaciente, int pNivelDeUrgencia, DateTime pFechaYHoraDeLlegada)
        {
            this.iNumero = pNumero;
            this.iPaciente = pPaciente;
            this.iNivelDeUrgencia = pNivelDeUrgencia;
            this.iFechaYHoraDeLlegada = pFechaYHoraDeLlegada;
            this.iAtendido = false;
        }

        /// <summary>
        /// Número del Turno.
        /// </summary>
        public int Numero
        {
            get { return this.iNumero; }
        }

        /// <summary>
        /// Paciente del turno.
        /// </summary>
        public Paciente Paciente
        {
            get { return this.iPaciente; }
        }

        /// <summary>
        /// Nivel de urgencia del Turno.
        /// </summary>
        public int NivelDeUrgencia
        {
            get { return this.iNivelDeUrgencia; }
        }

        /// <summary>
        /// Fecha y hora de llegada del paciente. 
        /// </summary>
        public DateTime FechaYHoraDeLlegada
        {
            get { return this.iFechaYHoraDeLlegada; }
        }

        /// <summary>
        /// Indica si el turno fue o no atendido.
        /// </summary>
        public bool Atendido
        {
            get { return this.iAtendido; }
            set { this.iAtendido = value; }
        }

        /// <summary>
        /// Tiempo en espera que lleva el paciente correspondiente al Turno.
        /// </summary>
        /// <returns></returns>
        public TimeSpan TiempoEnEspera()
        {
           TimeSpan tiempoEnEspera = (DateTime.Now - this.FechaYHoraDeLlegada);
           return tiempoEnEspera;
        }

    }
}
