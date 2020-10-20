using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EJ3.Test
{
    public class FacadeTests
    {

        [Fact]
        public void Test_Obtener_Turno_En_Sala_De_Consulta()
        {
            //ARRANGE
            Facade facade = new Facade();
            var TurnoExpected1 = new Turno(3, new Paciente("MARTIN", "BEATRICE", 23, "408487846"), 4, new DateTime(2020, 10, 8, 11, 0, 0));
            var TurnoExpected2 = new Turno(1, new Paciente("DANIEL", "KESSELMAN", 50, "18746952"), 2, new DateTime(2020, 10, 8, 12, 0, 0));
            var TurnoExpected3 = new Turno(9, new Paciente("NORMA", "FERRERO", 53, "16341467"), 5, new DateTime(2020, 10, 8, 13, 0, 0));
            var TurnoExpected4 = new Turno(6, new Paciente("ESTEBAN", "PEREZ", 33, "29431741"), 2, new DateTime(2020, 10, 8, 14, 0, 0));
            var TurnoExpected5 = new Turno(5, new Paciente("LUCRECIA", "MARTINEZ", 32, "30497617"), 1, new DateTime(2020, 10, 8, 15, 0, 0));
            var TurnoExpected6 = new Turno(2, new Paciente("HUGO", "LOPEZ", 24, "40427449"), 3, new DateTime(2020, 10, 8, 16, 0, 0));
            var TurnoExpected7 = new Turno(7, new Paciente("LEANDRO", "DOELLO", 25, "39976684"), 3, new DateTime(2020, 10, 8, 18, 0, 0));
            var TurnoExpected8 = new Turno(4, new Paciente("HORACIO", "JURADO", 42, "20437169"), 5, new DateTime(2020, 10, 8, 19, 0, 0));
            var TurnoExpected9 = new Turno(8, new Paciente("GRACIELA", "LUJAN", 42, "20796591"), 4, new DateTime(2020, 10, 8, 20, 0, 0));
            var TurnoExpected10 = new Turno(0, new Paciente("MATEO", "KESSELMAN", 20, "42487149"), 1, new DateTime(2020, 10, 8, 21, 0, 0));
           

            //ACT
            var turnoActual1 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool1 = TurnoExpected1.Paciente.Nombre == turnoActual1.Paciente.Nombre;

            var turnoActual2 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool2 = TurnoExpected2.Paciente.Nombre == turnoActual2.Paciente.Nombre;

            var turnoActual3 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool3 = TurnoExpected3.Paciente.Nombre == turnoActual3.Paciente.Nombre;

            var turnoActual4 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool4 = TurnoExpected4.Paciente.Nombre == turnoActual4.Paciente.Nombre;

            var turnoActual5 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool5 = TurnoExpected5.Paciente.Nombre == turnoActual5.Paciente.Nombre;

            var turnoActual6 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool6 = TurnoExpected6.Paciente.Nombre == turnoActual6.Paciente.Nombre;

            var turnoActual7 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool7 = TurnoExpected7.Paciente.Nombre == turnoActual7.Paciente.Nombre;

            var turnoActual8 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool8 = TurnoExpected8.Paciente.Nombre == turnoActual8.Paciente.Nombre;

            var turnoActual9 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool9 = TurnoExpected9.Paciente.Nombre == turnoActual9.Paciente.Nombre;

            var turnoActual10 = facade.ObtenerTurnoEnSalaDeConsulta();
            bool bool10 = TurnoExpected10.Paciente.Nombre == turnoActual10.Paciente.Nombre;

            //ASSERT
            Assert.True(bool1);
            Assert.True(bool2);
            Assert.True(bool3);
            Assert.True(bool4);
            Assert.True(bool5);
            Assert.True(bool6);
            Assert.True(bool7);
            Assert.True(bool8);
            Assert.True(bool9);
            Assert.True(bool10);
        }


        [Fact]
        public void Test_Obtener_Turno_En_Sala_De_Urgencia()
        {
            //ARRANGE
            Facade facade = new Facade();
            var TurnoExpected7 = new Turno(3, new Paciente("MARTIN", "BEATRICE", 23, "408487846"), 4, new DateTime(2020, 10, 8, 11, 0, 0));
            var TurnoExpected3 = new Turno(1, new Paciente("DANIEL", "KESSELMAN", 50, "18746952"), 2, new DateTime(2020, 10, 8, 12, 0, 0));
            var TurnoExpected9 = new Turno(9, new Paciente("NORMA", "FERRERO", 53, "16341467"), 5, new DateTime(2020, 10, 8, 13, 0, 0));
            var TurnoExpected4 = new Turno(6, new Paciente("ESTEBAN", "PEREZ", 33, "29431741"), 2, new DateTime(2020, 10, 8, 14, 0, 0));
            var TurnoExpected1 = new Turno(5, new Paciente("LUCRECIA", "MARTINEZ", 32, "30497617"), 1, new DateTime(2020, 10, 8, 15, 0, 0));
            var TurnoExpected5 = new Turno(2, new Paciente("HUGO", "LOPEZ", 24, "40427449"), 3, new DateTime(2020, 10, 8, 16, 0, 0));
            var TurnoExpected6 = new Turno(7, new Paciente("LEANDRO", "DOELLO", 25, "39976684"), 3, new DateTime(2020, 10, 8, 18, 0, 0));
            var TurnoExpected10 = new Turno(4, new Paciente("HORACIO", "JURADO", 42, "20437169"), 5, new DateTime(2020, 10, 8, 19, 0, 0));
            var TurnoExpected8 = new Turno(8, new Paciente("GRACIELA", "LUJAN", 42, "20796591"), 4, new DateTime(2020, 10, 8, 20, 0, 0));
            var TurnoExpected2 = new Turno(0, new Paciente("MATEO", "KESSELMAN", 20, "42487149"), 1, new DateTime(2020, 10, 8, 21, 0, 0));


            //ACT
            var turnoActual1 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool1 = TurnoExpected1.Paciente.Nombre == turnoActual1.Paciente.Nombre;

            var turnoActual2 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool2 = TurnoExpected2.Paciente.Nombre == turnoActual2.Paciente.Nombre;

            var turnoActual3 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool3 = TurnoExpected3.Paciente.Nombre == turnoActual3.Paciente.Nombre;

            var turnoActual4 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool4 = TurnoExpected4.Paciente.Nombre == turnoActual4.Paciente.Nombre;

            var turnoActual5 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool5 = TurnoExpected5.Paciente.Nombre == turnoActual5.Paciente.Nombre;

            var turnoActual6 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool6 = TurnoExpected6.Paciente.Nombre == turnoActual6.Paciente.Nombre;

            var turnoActual7 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool7 = TurnoExpected7.Paciente.Nombre == turnoActual7.Paciente.Nombre;

            var turnoActual8 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool8 = TurnoExpected8.Paciente.Nombre == turnoActual8.Paciente.Nombre;

            var turnoActual9 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool9 = TurnoExpected9.Paciente.Nombre == turnoActual9.Paciente.Nombre;

            var turnoActual10 = facade.ObtenerTurnoEnSalaDeUrgencia();
            bool bool10 = TurnoExpected10.Paciente.Nombre == turnoActual10.Paciente.Nombre;

            //ASSERT
            Assert.True(bool1);
            Assert.True(bool2);
            Assert.True(bool3);
            Assert.True(bool4);
            Assert.True(bool5);
            Assert.True(bool6);
            Assert.True(bool7);
            Assert.True(bool8);
            Assert.True(bool9);
            Assert.True(bool10);
        }

    }
}