using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorAyP
{
    class Obra
    {
        ///public ArrayList ListaObreros;
        protected string nombrePropietario;
        protected int dniPropietario;
        private int codigoInterno;
        private string tipoDeObra;
        private int tiempoDeEjecucion;
        private int estadoDeAvance;
        private int costo;
        protected JefeDeObra jefesDeObra;
       


        public Obra(string nombrePropietario, int dniPropietario, int codigoInterno, string tipoDeObra, int tiempoDeEjecucion, int estadoDeAvance, int costo, JefeDeObra jefesDeObra)
        {
            this.nombrePropietario = nombrePropietario;
            this.dniPropietario = dniPropietario;
            this.tipoDeObra = tipoDeObra;
            this.tiempoDeEjecucion = tiempoDeEjecucion;
            this.costo = costo;
            this.jefesDeObra = jefesDeObra;

        }
    }

   

}
