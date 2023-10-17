using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorAyP
{
    internal class Empresa
    {
        private ArrayList grupoDeObreros;
        private ArrayList grupoDeObras;
        private ArrayList obrasFinalizadas;
        private ArrayList listaJefes;



        public Empresa(ArrayList grupoDeObreros, ArrayList grupoDeObras, ArrayList obrasFinalizadas, ArrayList listaJefes)
        {
            this.grupoDeObreros = grupoDeObreros;
            this.grupoDeObras = grupoDeObras;
            this.obrasFinalizadas = obrasFinalizadas;
            this.listaJefes = listaJefes;
        }

    }

}
