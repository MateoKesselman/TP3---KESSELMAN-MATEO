using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    /// <summary>
    /// Clase que representa el patrón Controlador de Fachada.
    /// </summary>
    public class Facade
    {
        private Sala iSalaDeConsulta;
        private Sala iSalaDeUrgencia;

        /// <summary>
        /// Instancia un objeto de la clase Facade.
        /// </summary>
        public Facade ()
        {
            Turno[] turnosConsulta ={new Turno(0,new Paciente("MATEO","KESSELMAN",20,"42487149"),1,new DateTime(2020, 10, 8, 21, 0, 0)),
        new Turno(1,new Paciente("DANIEL","KESSELMAN",50,"18746952"),2, new DateTime(2020, 10, 8, 12, 0, 0)),
        new Turno(2,new Paciente("HUGO","LOPEZ",24,"40427449"),3, new DateTime(2020, 10, 8, 16, 0, 0)),
        new Turno(3,new Paciente("MARTIN","BEATRICE",23,"408487846"),4, new DateTime(2020, 10, 8, 11, 0, 0)),
        new Turno(4,new Paciente("HORACIO","JURADO",42,"20437169"),5, new DateTime(2020, 10, 8, 19, 0, 0)),
        new Turno(5,new Paciente("LUCRECIA","MARTINEZ",32,"30497617"),1, new DateTime(2020, 10, 8, 15, 0, 0)),
        new Turno(6,new Paciente("ESTEBAN","PEREZ",33,"29431741"),2, new DateTime(2020, 10, 8, 14, 0, 0)),
        new Turno(7,new Paciente("LEANDRO","DOELLO",25,"39976684"),3, new DateTime(2020, 10, 8, 18, 0, 0)),
        new Turno(8,new Paciente("GRACIELA","LUJAN",42,"20796591"),4, new DateTime(2020, 10, 8, 20, 0, 0)),
        new Turno(9,new Paciente("NORMA","FERRERO",53,"16341467"),5, new DateTime(2020, 10, 8, 13, 0, 0))};
            Turno[] turnosUrgencia ={new Turno(0,new Paciente("MATEO","KESSELMAN",20,"42487149"),1,new DateTime(2020, 10, 8, 21, 0, 0)),
        new Turno(1,new Paciente("DANIEL","KESSELMAN",50,"18746952"),2, new DateTime(2020, 10, 8, 12, 0, 0)),
        new Turno(2,new Paciente("HUGO","LOPEZ",24,"40427449"),3, new DateTime(2020, 10, 8, 16, 0, 0)),
        new Turno(3,new Paciente("MARTIN","BEATRICE",23,"408487846"),4, new DateTime(2020, 10, 8, 11, 0, 0)),
        new Turno(4,new Paciente("HORACIO","JURADO",42,"20437169"),5, new DateTime(2020, 10, 8, 19, 0, 0)),
        new Turno(5,new Paciente("LUCRECIA","MARTINEZ",32,"30497617"),1, new DateTime(2020, 10, 8, 15, 0, 0)),
        new Turno(6,new Paciente("ESTEBAN","PEREZ",33,"29431741"),2, new DateTime(2020, 10, 8, 14, 0, 0)),
        new Turno(7,new Paciente("LEANDRO","DOELLO",25,"39976684"),3, new DateTime(2020, 10, 8, 18, 0, 0)),
        new Turno(8,new Paciente("GRACIELA","LUJAN",42,"20796591"),4, new DateTime(2020, 10, 8, 20, 0, 0)),
        new Turno(9,new Paciente("NORMA","FERRERO",53,"16341467"),5, new DateTime(2020, 10, 8, 13, 0, 0))};

            FIFO estrategiaFIFO = new FIFO();
            Triaje estrategiaTriaje = new Triaje();

            this.iSalaDeConsulta = new Sala(turnosConsulta, estrategiaFIFO);
            this.iSalaDeUrgencia = new Sala(turnosUrgencia, estrategiaTriaje);
        }

        /// <summary>
        /// Obtiene turno correspondiente en la sala de Consultas.
        /// </summary>
        /// <returns></returns>
        public Turno ObtenerTurnoEnSalaDeConsulta()
        {
            return iSalaDeConsulta.ObtenerProximoTurno();
        }

        /// <summary>
        /// Obtiene turno correspondiente en la sala de Urgencias.
        /// </summary>
        /// <returns></returns>
        public Turno ObtenerTurnoEnSalaDeUrgencia()
        {
            return iSalaDeUrgencia.ObtenerProximoTurno();
        }

    }
}
