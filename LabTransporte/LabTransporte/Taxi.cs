using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    public class Taxi : TransportePublico
    {
        private bool estaOcupado { get => pasajeros > 0; }

        #region Constructor
        public Taxi(int nroTransporte, int pasajeros, int cantidadMaximaPasajeros = 4) : base(nroTransporte, pasajeros)
        {
            this.cantidadMaximaPasajeros = cantidadMaximaPasajeros;
            this.velocidadMaxima = 100;
        }
        #endregion

        #region Metodos
        /*Este metodo se encarga de comparar la cantidad de pasajeros que van a 
         subir al taxi con la cantidad maxima de pasajeros que pueden subir a un taxi y devuelve un string*/
        public override string SubirPasajeros(int pPasajeros)
        {
            if (!estaOcupado && pPasajeros <= cantidadMaximaPasajeros)
            {
                pasajeros = pPasajeros;
                return $"Los pasajeros se han subido al Taxi {nroTransporte}";
            }
            else if (pPasajeros > cantidadMaximaPasajeros)
            {
                return $"No hay suficiente espacio en el taxi.";
            }
            else
            {
                return $"Taxi ocupado";
            }
        }

        /*Este metodo se encarga de comparar la cantidad de pasajeros que van a 
        bajar de un taxi con la cantidad de pasajeros que actualmente tiene el taxi y devuelve un string */
        public override string BajarPasajeros(int pPasajeros)
        {
            if (estaOcupado && pPasajeros <= pasajeros)
            {
                pasajeros -= pPasajeros;

                return $"Hay {pasajeros} pasajeros en el Taxi {nroTransporte}.";
            }
            else
            {
                return $"Solo hay {pasajeros} pasajero(s) en el Taxi {nroTransporte}.";
            }
        }
        #endregion
    }
}
