using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{   
    /// <summary>
     /// Clase que representa el Criterio de selección Triaje.
     /// </summary>
    public class Triaje : CriterioDeSeleccion
    {
        /// <summary>
        /// Método que selecciona el próximo turno correspondiente.
        /// </summary>
        /// <param name="pTurnos"> Arreglo de turnos disponibles. </param>
        /// <returns></returns>
        public override Turno SeleccionDelProximoTurno(Turno[] pTurnos)
        {
            Turno turnoElegido = null;
            int control = 0;
            bool existencia = false;

            while ((existencia == false) && (control < pTurnos.Length))
            {
                if (pTurnos[control].Atendido == true)
                {
                    control++;
                }
                else
                {
                    existencia = true;
                    turnoElegido = pTurnos[control];
                }
            }

            if (turnoElegido != null)
            {
                for (int i = control + 1; i < pTurnos.Length; i++)
                {
                    if (pTurnos[i].Atendido == false)
                    {
                        if (pTurnos[i].NivelDeUrgencia < turnoElegido.NivelDeUrgencia)
                        {
                            turnoElegido = pTurnos[i];
                        }
                        else if (pTurnos[i].NivelDeUrgencia == turnoElegido.NivelDeUrgencia)
                        {
                            if (pTurnos[i].TiempoEnEspera() > turnoElegido.TiempoEnEspera())
                            {
                                turnoElegido = pTurnos[i];
                            }
                        }
                    }
                }
            }
            return turnoElegido;
        }
    }
}
