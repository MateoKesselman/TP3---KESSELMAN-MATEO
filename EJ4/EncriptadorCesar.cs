using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EJ4
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";

        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            String cifrado = "";
            if (this.iDesplazamiento > 0 && this.iDesplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = GetPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + this.iDesplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else //si no existe el caracter no se cifra
                    {
                        cifrado += pCadena[i];
                    }
                }

            }
            return cifrado;
        }

        public override string Desencriptar(string pCadena)
        {
            String cifrado = "";
            if (this.iDesplazamiento > 0 && this.iDesplazamiento < abc.Length)
            {
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = GetPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - this.iDesplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += pCadena[i];
                    }
                }

            }
            return cifrado;
        }

        static int GetPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }

}