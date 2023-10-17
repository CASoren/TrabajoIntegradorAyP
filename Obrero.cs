using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorAyP
{
    class Obrero : Persona
    {
        protected int numLegajo;
        protected int sueldo;
        protected string cargo;


        /// constructor de la clase obrero 
        public Obrero (int numLegajo, int sueldo, string cargo, string nombre, string apellido, int dni) : base (nombre, apellido, dni)
        {
            this.numLegajo = numLegajo;
            this.sueldo = sueldo;
            this.cargo = cargo;
        
        }



        /// getters y seters de obrero 
        public int getNumLegajo
        {
            get { return numLegajo; }
            set { numLegajo = value; }
        }
        public int getSueldo 
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public string getCargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    }
}
