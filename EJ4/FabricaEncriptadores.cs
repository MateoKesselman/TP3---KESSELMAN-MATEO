using System;
using System.Collections.Generic;
using System.Text;

namespace EJ4
{
    public sealed class FabricaEncriptadores
    {
        private readonly static FabricaEncriptadores cInstancia = new FabricaEncriptadores();
        private Dictionary<string, iEncriptador> iEncriptadores = new Dictionary<string, iEncriptador>();

        private FabricaEncriptadores()
        {
            iEncriptadores.Add("César", new EncriptadorCesar(10));
        }

        public iEncriptador GetEncriptador (string nombre)
        {
            iEncriptador iEncriptador;
            iEncriptadores.TryGetValue(nombre, out iEncriptador);
            return iEncriptador;
        }

        public static FabricaEncriptadores Instancia
        {
            get { return cInstancia; }
        }
    }
}

/*Singleton es un patrón de diseño del tipo creacional
 * cuyo propósito es garantizar la existencia de una
 * sola instancia de una clase. Además el acceso a esa
 * única instancia tiene que ser global. */

/*La clase FabricaEncriptadores es un Singleton
 * que es responsable de crear y mantener una instancia
 * de cada implementación de la interface IEncriptador.
 * El método GetEncriptador devuelve la instancia de IEncriptador
 * cuyo nombre coincide con el parámetro proporcionado.
 * Si el nombre proporcionado no existe, entonces se
 * debe devolver una instancia de EncriptadorNulo.*/