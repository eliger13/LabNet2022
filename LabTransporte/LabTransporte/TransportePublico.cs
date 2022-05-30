using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTransporte
{
    public abstract class TransportePublico
    {
        #region Propiedades
        public int nroTransporte { get; set; }
        public int pasajeros { get; set; }

        protected int velocidad;

        protected int velocidadMaxima;

        protected int velocidadMinima = 50;

        protected int cantidadMaximaPasajeros;
        #endregion

        #region Constructor
        public TransportePublico(int nroTransporte, int pasajeros)
        {
            this.nroTransporte = nroTransporte;
            this.pasajeros = pasajeros;
        }
        #endregion

        #region Metodos
        public virtual int getVelocidadMin() 
        { 
            return velocidadMinima; 
        }

        public virtual int getVelocidadMax()
        {
            return velocidadMaxima;
        }

        // Este metodo se encarga asignar una velocidad al transporte
        public virtual string Avanzar(int pVelocidad)
        {
            velocidad = pVelocidad;
            if (pVelocidad == velocidadMaxima)
            {
                return $"Avanza a una velocidad maxima de {velocidad} Km/h.";

            }
            else
            {
                return $"Avanza a una velocidad minima de {velocidad} Km/h.";
            }
        }

        // Este metodo se encarga de asignarle 0 a la velocidad transporte 
        public virtual void Detenerse()
        {
            velocidad = 0;
        }

        public abstract string SubirPasajeros(int pPasajeros);

        public abstract string BajarPasajeros(int pPasajeros);
        #endregion
    }
}
