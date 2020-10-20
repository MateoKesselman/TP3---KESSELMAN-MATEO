using System;

namespace EJ4
{
    public class Interface
    {
        static void Main(string[] args)
        {/*
            Facade facade = new Facade();
            int nNumero = 3;
            while (nNumero != 0)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine(" ------------------ 1_ENCRIPTAR CADENA --------------------------------");
                Console.WriteLine(" ------------------ 2_DESENCRIPTAR CADENA -----------------------------");
                Console.WriteLine(" ------------------ 0_SALIR -------------------------------------------");
                Console.WriteLine(" ----------------------------------------------------------------------");
                Console.WriteLine();

                Console.Write(" INTRODUZCA NÚMERO:");
                nNumero = int.Parse(Console.ReadLine());

                switch (nNumero)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("INGRESE LA CADENA QUE DESEA ENCRIPTAR: ");
                        string cadena = Console.ReadLine();
                        string cadenaEncriptada = facade.Encriptar(cadena);


                        double pX1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PRIMER PUNTO");
                        double pY1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA X DEL SEGUNDO PUNTO");
                        double pX2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL SEGUNDO PUNTO");
                        double pY2 = Convert.ToDouble(Console.ReadLine());
                        var facade = new Facade();
                        double result = facade.ObtenerDistanciaEntreLosDosPuntos(pX1, pY1, pX2, pY2);
                        Console.Clear();
                        Console.WriteLine("LA DISTANCIA ENTRE LOS PUNTOS (" + pX1 + " , " + pY1 + ") Y (" + pX2 + " , " + pY2 + ") ES " + Math.Round(result, 2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("INGRESE COORDENADA X DEL PUNTO CENTRO");
                        double pX = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE COORDENADA Y DEL PUNTO CENTRO");
                        double pY = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE RADIO DEL CIRCULO");
                        double pRadio = Convert.ToDouble(Console.ReadLine());
                        var facade2 = new Facade();
                        double result2 = facade2.ObtenerPerimetroDelCirculo(pX, pY, pRadio);
                        Console.Clear();
                        Console.WriteLine("EL PERÍMETRO DEL CÍRCULO CUYO RADIO ES " + pRadio + " Y TIENE POR CENTRO EL PUNTO (" + pX + " , " + pY + ") ES " + Math.Round(result2, 2));
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
            }*/
        }
    }
    
}
