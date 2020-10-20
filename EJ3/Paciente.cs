using System;
using System.Collections.Generic;
using System.Text;

namespace EJ3
{
    /// <summary>
    /// Clase que representa un Paciente.
    /// </summary>
    public class Paciente
    {
        private string iNombre;
        private string iApellido;
        private int iEdad;
        private string iDNI;

        /// <summary>
        /// Instancia un objeto de la clase Paciente.
        /// </summary>
        /// <param name="pNombre"></param>
        /// <param name="pApellido"></param>
        /// <param name="pEdad"></param>
        /// <param name="pDni"></param>
        public Paciente (string pNombre, string pApellido, int pEdad, string pDni)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iEdad = pEdad;
            this.iDNI = pDni;
        }

        /// <summary>
        /// Nombre del paciente.
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
        }

        /// <summary>
        /// Apellido del paciente.
        /// </summary>
        public string Apellido
        {
            get { return this.iApellido; }
        }

        /// <summary>
        /// Edad del paciente.
        /// </summary>
        public int Edad
        {
            get { return this.iEdad; }
        }

        /// <summary>
        /// DNI del paciente.
        /// </summary>
        public string DNI
        {
            get { return this.iDNI; }
        }

    }
}
