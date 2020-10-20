using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EJ4
{
    public class EncriptadorAES //: Encriptador
    {
       /* public EncriptadorAES() : base("AES")
        {
        }

        /// <summary>
        /// Manda a encriptar un objeto
        /// </summary>
        /// <param name="pCadena"> Cadena a encriptar </param>
        /// <returns> Retorna la cadena encriptada con las Claves </returns>
        public override string Encriptar(string pCadena)
        {
            //Creamos el algoritmo
            System.Security.Cryptography.Rijndael rijndael = System.Security.Cryptography.Rijndael.Create();

            //Almacenamos las claves
            object vlKey = rijndael.Key;
            object vlIV = rijndael.IV;

            //Usamos el algoritmo
            using (rijndael)
            {
                //Encriptamos el objecto
                object vlEncrypted = EncryptObjectToBytes(pCadena, rijndael.Key, rijndael.IV);

                //Almacenamos en un string[] el objecto encriptado
                string[] vlEnEncrypted = ((IEnumerable)vlEncrypted).Cast<object>()
                    .Select(x => x.ToString())
                    .ToArray();

                //Almacenamos en un string[] la clave 1
                string[] vlEnKey = ((IEnumerable)vlKey).Cast<object>()
                    .Select(x => x.ToString())
                    .ToArray();

                //Almacenamos en un string[] la clave 2
                string[] vlEnIV = ((IEnumerable)vlIV).Cast<object>()
                    .Select(x => x.ToString())
                    .ToArray();

                //Creamos el string con los datos encriptados
                string vlValueEncode = string.Empty;
                vlValueEncode = vlValueEncode + string.Join(",", vlEnEncrypted);
                vlValueEncode = vlValueEncode + "/" + string.Join(",", vlEnKey);
                vlValueEncode = vlValueEncode + "/" + string.Join(",", vlEnIV);

                //Almacenamos en un objecto el string 
                object vlValueFinal = vlValueEncode;

                //Retornamos el objecto
                return (string)vlValueFinal;
            }
        }

        
        /// <summary>
        /// Manda a desencriptar un objecto
        /// </summary>
        /// <param name="pEncode">Objecto Encriptado</param>
        /// <param name="pKey">Clave 1 Encriptada</param>
        /// <param name="pIV">Clave 2 Encriptada</param>
        /// <returns>Retorna el Objecto Desencriptado</returns>
        public override string Desencriptar(string pCadena)
        {


        }

        public static object Decode(byte[] pEncode, byte[] pKey, byte[] pIV)
        {
            //Mandamos a desencriptar el objecto
            object vlValue = DecryptObjectFromBytes(pEncode, pKey, pIV);

            //Si el objecto no es nulo
            if (vlValue != null)
            {
                //Retornamos el objecto
                return vlValue;
            }
            return null;
        }*/
    }
}
// Para la implementación del algoritmo de AES
// se recomienda utilizar las clases provistas por .NET.