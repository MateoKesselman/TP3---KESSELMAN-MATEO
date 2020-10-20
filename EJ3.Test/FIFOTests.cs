using System;
using Xunit;

namespace EJ3.Test
{
    public class FIFOTests
    {
        [Fact]
        public void Test_Seleccion_Del_Proximo_Turno()
        {
            //ARRANGE
            CriterioDeSeleccion criterioFIFO = new FIFO();

            Turno turnoExpected = new Turno(0, new Paciente("MATEO", "KESSELMAN", 20, "42487149"), 1, new DateTime(2020, 10, 8, 1, 0, 0));
            Turno turno2 = new Turno(1, new Paciente("DANIEL", "KESSELMAN", 50, "18746952"), 2, new DateTime(2020, 10, 8, 2, 0, 0));
            Turno turno3 = new Turno(2, new Paciente("HUGO", "LOPEZ", 24, "40427449"), 3, new DateTime(2020, 10, 8, 3, 0, 0));
            Turno turno4 = new Turno(3, new Paciente("MARTIN", "BEATRICE", 23, "408487846"), 4, new DateTime(2020, 10, 8, 4, 0, 0));
            Turno turno5 = new Turno(4, new Paciente("HORACIO", "JURADO", 42, "20437169"), 5, new DateTime(2020, 10, 8, 5, 0, 0));
            Turno turno6 = new Turno(5, new Paciente("LUCRECIA", "MARTINEZ", 32, "30497617"), 1, new DateTime(2020, 10, 8, 6, 0, 0));
            Turno turno7 = new Turno(6, new Paciente("ESTEBAN", "PEREZ", 33, "29431741"), 2, new DateTime(2020, 10, 8, 7, 0, 0));
            Turno turno8 = new Turno(7, new Paciente("LEANDRO", "DOELLO", 25, "39976684"), 3, new DateTime(2020, 10, 8, 8, 0, 0));
            Turno turno9 = new Turno(8, new Paciente("GRACIELA", "LUJAN", 42, "20796591"), 4, new DateTime(2020, 10, 8, 9, 0, 0));
            Turno turno10 = new Turno(9, new Paciente("NORMA", "FERRERO", 53, "16341467"), 5, new DateTime(2020, 10, 8, 10, 0, 0));

            Turno[] turnos = { turno4, turno2, turno3, turnoExpected, turno9, turno8, turno6, turno7,
            turno5, turno10};

            //ACT
            var turnoActual = criterioFIFO.SeleccionDelProximoTurno(turnos);

            //ASSERT
            Assert.Equal(turnoExpected, turnoActual);
        }

    }
}
