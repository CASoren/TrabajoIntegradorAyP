using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorAyP
{
    class JefeDeObra : Obrero
    {
        protected string obraACargo;
        private int bonificacionEspecial;

        public JefeDeObra(string nombre, string apellido, int dni, int numLegajo, int sueldo, string cargo, string obraACargo, int bonificacionEspecial) : base ( numLegajo, sueldo, cargo, nombre, apellido, dni)
        {
            this.obraACargo = obraACargo;
            this.bonificacionEspecial = bonificacionEspecial;
        }



        public void dirigeObreros()
        {
            Console.WriteLine("Estoy dirigiendo a los obreros");
        }
    }
}
