using System;
using System.Collections.Generic;
using System.Text;

namespace EJ4
{
    public class EncriptadorNulo : Encriptador
    {
       public EncriptadorNulo() : base("Null")
        {
        }

        public override string Encriptar (string pCadena)
        {
            return pCadena;
        }

        public override string Desencriptar (string pCadena)
        {
            return pCadena;
        }
    }
}
