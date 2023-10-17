using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorAyP
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;


        /// constructor de Perona
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        

        /// getters y setters 
        public string getNombre
        {
            get { return nombre; }
            set {nombre = value;}
        }
        public string getApellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int getDni
        {
            get { return dni; }
            set { dni = value; }
        }


    }

}
