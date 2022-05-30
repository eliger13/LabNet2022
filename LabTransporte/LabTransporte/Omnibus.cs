using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    public class Omnibus : TransportePublico
    {
        #region Constructor
        public Omnibus(int nroTransporte, int pasajeros, int cantidadMaximaPasajeros = 100) : base(nroTransporte, pasajeros)
        {
            this.cantidadMaximaPasajeros = cantidadMaximaPasajeros;
            this.velocidadMaxima = 60;
        }
        #endregion

        #region Metodos
        /* Este metodo se encarga de comparar la cantidad de pasajeros que van a 
         * subir al omnibus con la cantidad maxima de pasajeros que pueden subir 
         */
        public override string SubirPasajeros(int pPasajeros)
        {
            int espacioDisponible = cantidadMaximaPasajeros;
            if (pPasajeros + pasajeros <= cantidadMaximaPasajeros)
            {
                pasajeros += pPasajeros;
                return $"Los pasajeros se han subido al Onmibus {nroTransporte}";
            }
            else
            {
                espacioDisponible -= pasajeros;
                return $"Disculpe, solo pueden subir hasta {espacioDisponible} pasajeros(s)";
            } 
        }

        /* Este metodo se encarga de actualizar la cantidad de pasajeros que hay en un omnibus
         * cuando algunos pasajeros se hayan bajado del mismo.
         */
        public override string BajarPasajeros(int pPasajeros)
        {
            if (pPasajeros <= pasajeros)
            {
                pasajeros -= pPasajeros;
                
                if (pasajeros == 0)
                {
                    return $"No hay pasajeros en el Ombibus {nroTransporte}.";
                }
                return $"Hay {pasajeros} pasajeros en el Omnibus {nroTransporte}.";
            }
            else
            {
                return $"Solo hay {pasajeros} pasajero(s) en el Omnibus.";
            }
        }
        #endregion
    }
}
