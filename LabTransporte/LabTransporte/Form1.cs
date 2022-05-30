using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTransporte
{
    public partial class Form1 : Form
    {
        List<TransportePublico> ListaTransporte = new List<TransportePublico>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaTransporte = new List<TransportePublico>();

            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            ListaTransporte.AddRange(new TransportePublico[]{
                new Omnibus(1,10),
                new Omnibus(2,10),
                new Omnibus(3,50),
                new Omnibus(4,30),
                new Omnibus(5,55),
                new Taxi(1,1),
                new Taxi(2,1),
                new Taxi(3,4),
                new Taxi(4,2),
                new Taxi(5,3),
            }) ;
            vistaDataGridView();
        }

        #region Ver Transportes
        /* Este metodo se encarga mostrar en el DataGridView la informacion relevante de los transportes,
         * permitiendo filtrar por un tipo de transporte(omnibus y taxi).
         */
        public void vistaDataGridView(string tipoTransporte = "Todos")
        {
            List<VistaTransportePublico> transportes = new List<VistaTransportePublico>();

            ListaTransporte.ForEach(
                t => transportes.Add(
                    new VistaTransportePublico(t.GetType().Name, t.nroTransporte, t.pasajeros)
                )
            );

            if(tipoTransporte != "Todos")
            {
                transportes = transportes.FindAll(t => t.tipoTransporte == tipoTransporte);
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = transportes;
        }
        
        /* Este boton se encarga de mostrar el dataGridView dependiendo de la opcion seleccionada
         * en el radio button(omnibus y taxi)
         */
        public void buttonMostrar_Click(object sender, EventArgs e)
        {
            string tipoTransporte = "";
            if (radioSelectTodos.Checked)
            {
                tipoTransporte = "Todos";
            }
            else if(radioSelectOmnibus.Checked)
            {
                tipoTransporte = "Omnibus";
            } 
            else
            {
                tipoTransporte = "Taxi";
            }
            vistaDataGridView(tipoTransporte);
        }

        public TransportePublico TransporteSeleccionado()
        {
            VistaTransportePublico transporteSeleccionado = (VistaTransportePublico)(dataGridView.SelectedRows[0].DataBoundItem);
            return ListaTransporte.Find(t => t.GetType().Name == transporteSeleccionado.tipoTransporte && t.nroTransporte == transporteSeleccionado.nroTransporte);

        }
        #endregion

        #region Crear nuevo Transporte

        public void buttonCrearTransporte_Click(object sender, EventArgs e)
        {
            panelCrearTransporte.Visible = true;
            panelDetenerTrasnporte.Visible = false;
            panelAvanzarTransporte.Visible = false;
        }

        /* Este boton se encarga de crear un nuevo transporte dependiendo de la opcion seleccionada
         * en el radio button(omnibus y taxi)
         */
        private void buttonCrearT_Click(object sender, EventArgs e)
        {
            string tipo_transporte = "";
            if (radioCrearOmnibus.Checked)
            {
                tipo_transporte = "Omnibus";
            }
            else
            {
                tipo_transporte = "Taxi";
            }
            Crear_Transporte(tipo_transporte);
            vistaDataGridView();
            panelCrearTransporte.Visible = false;
        }
         
        private void buttonCancelarT_Click(object sender, EventArgs e)
        {
            panelCrearTransporte.Visible = false;
        }

        /* Este metodo se encarga de crear un nuevo transporte permitiendo añadiendolo 
         * por su tipo de transporte(Omnibus y Taxi).
         */
        public void Crear_Transporte(string transporte)
        {
            TransportePublico ultimoTransporte = ListaTransporte.Last(t => t.GetType().Name == transporte);

            TransportePublico nuevoTransporte;
            if (transporte == "Omnibus")
            {
                nuevoTransporte = new Omnibus(ultimoTransporte.nroTransporte + 1, 0);
            }
            else
            {
                nuevoTransporte = new Taxi(ultimoTransporte.nroTransporte + 1, 0);
            }
            MessageBox.Show($"Se ha creado el {transporte} satisfactoriamente.");
            panelCrearTransporte.Visible = false;
            ListaTransporte.Add(nuevoTransporte);
            vistaDataGridView();
        }
        #endregion

        #region Avanzar Transporte
        public void buttonAvanzarTransporte_Click(object sender, EventArgs e)
        {
            panelAvanzarTransporte.Visible = true;
            panelDetenerTrasnporte.Visible = false;
            panelCrearTransporte.Visible = false;
        }

        /* Este boton se encarga de actualizar la velocidad del transporte dependiendo de la opcion seleccionada
         * en el radio button(velocidad maxima y velocidad minima)
         */
        private void buttonAvanzarT_Click(object sender, EventArgs e)
        {
            TransportePublico transporte = TransporteSeleccionado();

            if (radioVelocidadMin.Checked)
            {
               MessageBox.Show(transporte.Avanzar(transporte.getVelocidadMin()));
            }
            else
            {
                MessageBox.Show(transporte.Avanzar(transporte.getVelocidadMax()));
            }
            panelAvanzarTransporte.Visible = false;
            vistaDataGridView();
        }

        private void buttonCancelarAT_Click(object sender, EventArgs e)
        {
            panelAvanzarTransporte.Visible = false;
        }
        #endregion

        #region Detener para subir y bajar pasajeros
        public void buttonDetenerTransporte_Click(object sender, EventArgs e)
        {
            panelDetenerTrasnporte.Visible = true;
            panelCrearTransporte.Visible = false;
            panelAvanzarTransporte.Visible = false;
        }

        /* Este boton se encargara de detener el transporte seleccionado en el DataGridView 
         * y actualizar la cantidad de pasajeros que subieron.
         */
        private void buttonSubirPasajeros_Click(object sender, EventArgs e)
        {
            TransportePublico transporte = TransporteSeleccionado();

            if (numericUpDownPasajeros.Value <= 0)
            {
                MessageBox.Show("No se van a subir pasajeros");
            }
            else
            {
                transporte.Detenerse();
                int subirPasajeros = Convert.ToInt32(numericUpDownPasajeros.Value);
                MessageBox.Show(transporte.SubirPasajeros(subirPasajeros));
            }
        
            panelDetenerTrasnporte.Visible = false;
            numericUpDownPasajeros.Value = 0;
            vistaDataGridView();
        }

        /* Este boton se encargara de detener el transporte seleccionado en el DataGridView 
         * y actualizar la cantidad de pasajeros que bajaron.
         */
        private void buttonBajarPasajeros_Click(object sender, EventArgs e)
        {
            TransportePublico transporte = TransporteSeleccionado();

            if (numericUpDownPasajeros.Value <= 0)
            {
                MessageBox.Show("No se van a bajar pasajeros");
            }
            else
            {
                transporte.Detenerse();
                int bajarPasajeros = Convert.ToInt32(numericUpDownPasajeros.Value);
                MessageBox.Show(transporte.BajarPasajeros(bajarPasajeros));
            }

            panelDetenerTrasnporte.Visible = false;
            numericUpDownPasajeros.Value = 0;
            vistaDataGridView();
        }

        private void buttonCancelarDT_Click(object sender, EventArgs e)
        {
            panelDetenerTrasnporte.Visible = false;
        }
        #endregion

        #region Salir
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        #endregion

    }
}
