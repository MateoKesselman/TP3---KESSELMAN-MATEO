using System;
using System.Collections.Generic;
using System.Text;

namespace EJ4
{
    public abstract class Encriptador : iEncriptador
    {
        private string iNombre;

        public Encriptador (string pNombre)
        {
            this.iNombre = pNombre;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public abstract string Encriptar(string pCadena);

        public abstract string Desencriptar(string pCadena);

    }
}
