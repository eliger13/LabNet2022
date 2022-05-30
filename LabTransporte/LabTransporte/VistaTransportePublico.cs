using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    internal class VistaTransportePublico
    {
        [System.ComponentModel.DisplayName("Transporte")]
        public string tipoTransporte { get; set; }

        [System.ComponentModel.DisplayName("Numero")]
        public int nroTransporte { get; set; }

        [System.ComponentModel.DisplayName("Pasajeros")]
        public int pasajeros { get; set; }

        public VistaTransportePublico(string tipoTransporte, int nroTransporte, int pasajeros)
        {
            this.tipoTransporte = tipoTransporte;
            this.nroTransporte = nroTransporte;
            this.pasajeros = pasajeros;
        }
    }
}
