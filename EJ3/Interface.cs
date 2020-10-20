using System;

namespace EJ3
{
    class Interface
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            int nNumero = 3;
            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ BIENVENIDO AL HOSPITAL ----------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_TURNO EN SALA DE CONSULTA -----------------------");
                Console.WriteLine(" ------------------ 2_TURNO EN SALA DE URGENCIA -----------------------");
                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write(" INTRODUZCA NÚMERO: ");
                nNumero = int.Parse(Console.ReadLine());

                switch (nNumero)
                {
                    case 1:
                        Console.Clear();
                        var proximoTurnoConsulta = facade.ObtenerTurnoEnSalaDeConsulta();
                        if (proximoTurnoConsulta != null)
                        {
                            Console.Write("NOMBRE: "); Console.WriteLine(proximoTurnoConsulta.Paciente.Nombre);
                            Console.Write("APELLIDO: "); Console.WriteLine(proximoTurnoConsulta.Paciente.Apellido);
                            Console.Write("EDAD: "); Console.WriteLine(proximoTurnoConsulta.Paciente.Edad);
                            Console.Write("DNI: "); Console.WriteLine(proximoTurnoConsulta.Paciente.DNI);
                            Console.Write("NIVEL DE URGENCIA: ");                           
                            if (proximoTurnoConsulta.NivelDeUrgencia == 1)
                            {
                                Console.WriteLine("ROJO");
                            }
                            else if (proximoTurnoConsulta.NivelDeUrgencia == 2)
                            {
                                Console.WriteLine("ANARANJADO");
                            }
                            else if (proximoTurnoConsulta.NivelDeUrgencia == 3)
                            {
                                Console.WriteLine("AMARILLO");
                            }
                            else if (proximoTurnoConsulta.NivelDeUrgencia == 4)
                            {
                                Console.WriteLine("VERDE");
                            }
                            else if (proximoTurnoConsulta.NivelDeUrgencia == 5)
                            {
                                Console.WriteLine("AZUL");
                            }
                            Console.Write("TIEMPO DE ESPERA EN HORAS: "); Console.WriteLine(Math.Round(proximoTurnoConsulta.TiempoEnEspera().TotalHours,2));
                        }
                        else
                        {
                            Console.WriteLine("CERO TURNOS PENDIENTES EN LA SALA DE CONSULTAS");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        var proximoTurnoUrgencia = facade.ObtenerTurnoEnSalaDeUrgencia();
                        if (proximoTurnoUrgencia != null)
                        {
                            Console.Write("NOMBRE: "); Console.WriteLine(proximoTurnoUrgencia.Paciente.Nombre);
                            Console.Write("APELLIDO: "); Console.WriteLine(proximoTurnoUrgencia.Paciente.Apellido);
                            Console.Write("EDAD: "); Console.WriteLine(proximoTurnoUrgencia.Paciente.Edad);
                            Console.Write("DNI: "); Console.WriteLine(proximoTurnoUrgencia.Paciente.DNI);
                            Console.Write("NIVEL DE URGENCIA: ");
                            if (proximoTurnoUrgencia.NivelDeUrgencia == 1)
                            {
                                Console.WriteLine("ROJO");
                            }
                            else if (proximoTurnoUrgencia.NivelDeUrgencia == 2)
                            {
                                Console.WriteLine("ANARANJADO");
                            }
                            else if (proximoTurnoUrgencia.NivelDeUrgencia == 3)
                            {
                                Console.WriteLine("AMARILLO");
                            }
                            else if (proximoTurnoUrgencia.NivelDeUrgencia == 4)
                            {
                                Console.WriteLine("VERDE");
                            }
                            else if (proximoTurnoUrgencia.NivelDeUrgencia == 5)
                            {
                                Console.WriteLine("AZUL");
                            }
                            Console.Write("TIEMPO DE ESPERA EN HORAS: "); Console.WriteLine(Math.Round(proximoTurnoUrgencia.TiempoEnEspera().TotalHours, 2));
                        }
                        else
                        {
                            Console.WriteLine("CERO TURNOS PENDIENTES EN LA SALA DE URGENCIA");
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("FINALIZADO");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("INGRESÓ UNA OPCIÓN INCORRECTA");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
