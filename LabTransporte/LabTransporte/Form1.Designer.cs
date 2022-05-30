namespace LabTransporte
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAvanzarTransporte = new System.Windows.Forms.Button();
            this.buttonDetenerTransporte = new System.Windows.Forms.Button();
            this.radioSelectOmnibus = new System.Windows.Forms.RadioButton();
            this.radioSelectTaxi = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.radioCrearTaxi = new System.Windows.Forms.RadioButton();
            this.radioCrearOmnibus = new System.Windows.Forms.RadioButton();
            this.buttonCrearTransporte = new System.Windows.Forms.Button();
            this.radioSelectTodos = new System.Windows.Forms.RadioButton();
            this.panelAvanzarTransporte = new System.Windows.Forms.Panel();
            this.radioVelocidadMin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.radioVelocidadMax = new System.Windows.Forms.RadioButton();
            this.buttonCancelarAT = new System.Windows.Forms.Button();
            this.buttonAvanzarT = new System.Windows.Forms.Button();
            this.panelDetenerTrasnporte = new System.Windows.Forms.Panel();
            this.numericUpDownPasajeros = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCancelarDT = new System.Windows.Forms.Button();
            this.buttonBajarPasajeros = new System.Windows.Forms.Button();
            this.buttonSubirPasajeros = new System.Windows.Forms.Button();
            this.panelCrearTransporte = new System.Windows.Forms.Panel();
            this.buttonCancelarT = new System.Windows.Forms.Button();
            this.buttonCrearT = new System.Windows.Forms.Button();
            this.buttonMostrarTransporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelAvanzarTransporte.SuspendLayout();
            this.panelDetenerTrasnporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).BeginInit();
            this.panelCrearTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 172);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(471, 362);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nuevo Transporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(395, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Transporte Publico";
            // 
            // buttonAvanzarTransporte
            // 
            this.buttonAvanzarTransporte.Location = new System.Drawing.Point(489, 237);
            this.buttonAvanzarTransporte.Name = "buttonAvanzarTransporte";
            this.buttonAvanzarTransporte.Size = new System.Drawing.Size(142, 32);
            this.buttonAvanzarTransporte.TabIndex = 9;
            this.buttonAvanzarTransporte.Text = "Avanzar Transporte";
            this.buttonAvanzarTransporte.UseVisualStyleBackColor = true;
            this.buttonAvanzarTransporte.Click += new System.EventHandler(this.buttonAvanzarTransporte_Click);
            // 
            // buttonDetenerTransporte
            // 
            this.buttonDetenerTransporte.Location = new System.Drawing.Point(489, 359);
            this.buttonDetenerTransporte.Name = "buttonDetenerTransporte";
            this.buttonDetenerTransporte.Size = new System.Drawing.Size(142, 32);
            this.buttonDetenerTransporte.TabIndex = 10;
            this.buttonDetenerTransporte.Text = "Detener Transporte";
            this.buttonDetenerTransporte.UseVisualStyleBackColor = true;
            this.buttonDetenerTransporte.Click += new System.EventHandler(this.buttonDetenerTransporte_Click);
            // 
            // radioSelectOmnibus
            // 
            this.radioSelectOmnibus.AutoSize = true;
            this.radioSelectOmnibus.Location = new System.Drawing.Point(12, 108);
            this.radioSelectOmnibus.Name = "radioSelectOmnibus";
            this.radioSelectOmnibus.Size = new System.Drawing.Size(81, 20);
            this.radioSelectOmnibus.TabIndex = 11;
            this.radioSelectOmnibus.Text = "Omnibus";
            this.radioSelectOmnibus.UseVisualStyleBackColor = true;
            // 
            // radioSelectTaxi
            // 
            this.radioSelectTaxi.AutoSize = true;
            this.radioSelectTaxi.Location = new System.Drawing.Point(12, 133);
            this.radioSelectTaxi.Name = "radioSelectTaxi";
            this.radioSelectTaxi.Size = new System.Drawing.Size(54, 20);
            this.radioSelectTaxi.TabIndex = 12;
            this.radioSelectTaxi.Text = "Taxi";
            this.radioSelectTaxi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seleccionar Transporte:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(855, 7);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(102, 31);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // radioCrearTaxi
            // 
            this.radioCrearTaxi.AutoSize = true;
            this.radioCrearTaxi.Location = new System.Drawing.Point(6, 51);
            this.radioCrearTaxi.Name = "radioCrearTaxi";
            this.radioCrearTaxi.Size = new System.Drawing.Size(54, 20);
            this.radioCrearTaxi.TabIndex = 16;
            this.radioCrearTaxi.Text = "Taxi";
            this.radioCrearTaxi.UseVisualStyleBackColor = true;
            // 
            // radioCrearOmnibus
            // 
            this.radioCrearOmnibus.AutoSize = true;
            this.radioCrearOmnibus.Checked = true;
            this.radioCrearOmnibus.Location = new System.Drawing.Point(6, 26);
            this.radioCrearOmnibus.Name = "radioCrearOmnibus";
            this.radioCrearOmnibus.Size = new System.Drawing.Size(81, 20);
            this.radioCrearOmnibus.TabIndex = 15;
            this.radioCrearOmnibus.TabStop = true;
            this.radioCrearOmnibus.Text = "Omnibus";
            this.radioCrearOmnibus.UseVisualStyleBackColor = true;
            // 
            // buttonCrearTransporte
            // 
            this.buttonCrearTransporte.Location = new System.Drawing.Point(489, 129);
            this.buttonCrearTransporte.Name = "buttonCrearTransporte";
            this.buttonCrearTransporte.Size = new System.Drawing.Size(142, 32);
            this.buttonCrearTransporte.TabIndex = 17;
            this.buttonCrearTransporte.Text = "CrearTransporte";
            this.buttonCrearTransporte.UseVisualStyleBackColor = true;
            this.buttonCrearTransporte.Click += new System.EventHandler(this.buttonCrearTransporte_Click);
            // 
            // radioSelectTodos
            // 
            this.radioSelectTodos.AutoSize = true;
            this.radioSelectTodos.Checked = true;
            this.radioSelectTodos.Location = new System.Drawing.Point(12, 82);
            this.radioSelectTodos.Name = "radioSelectTodos";
            this.radioSelectTodos.Size = new System.Drawing.Size(68, 20);
            this.radioSelectTodos.TabIndex = 18;
            this.radioSelectTodos.TabStop = true;
            this.radioSelectTodos.Text = "Todos";
            this.radioSelectTodos.UseVisualStyleBackColor = true;
            // 
            // panelAvanzarTransporte
            // 
            this.panelAvanzarTransporte.Controls.Add(this.radioVelocidadMin);
            this.panelAvanzarTransporte.Controls.Add(this.label8);
            this.panelAvanzarTransporte.Controls.Add(this.radioVelocidadMax);
            this.panelAvanzarTransporte.Controls.Add(this.buttonCancelarAT);
            this.panelAvanzarTransporte.Controls.Add(this.buttonAvanzarT);
            this.panelAvanzarTransporte.Location = new System.Drawing.Point(660, 199);
            this.panelAvanzarTransporte.Name = "panelAvanzarTransporte";
            this.panelAvanzarTransporte.Size = new System.Drawing.Size(297, 91);
            this.panelAvanzarTransporte.TabIndex = 19;
            this.panelAvanzarTransporte.Visible = false;
            // 
            // radioVelocidadMin
            // 
            this.radioVelocidadMin.AutoSize = true;
            this.radioVelocidadMin.Checked = true;
            this.radioVelocidadMin.Location = new System.Drawing.Point(6, 30);
            this.radioVelocidadMin.Name = "radioVelocidadMin";
            this.radioVelocidadMin.Size = new System.Drawing.Size(71, 20);
            this.radioVelocidadMin.TabIndex = 22;
            this.radioVelocidadMin.TabStop = true;
            this.radioVelocidadMin.Text = "Minima";
            this.radioVelocidadMin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Seleccionar Velocidad";
            // 
            // radioVelocidadMax
            // 
            this.radioVelocidadMax.AutoSize = true;
            this.radioVelocidadMax.Location = new System.Drawing.Point(6, 55);
            this.radioVelocidadMax.Name = "radioVelocidadMax";
            this.radioVelocidadMax.Size = new System.Drawing.Size(75, 20);
            this.radioVelocidadMax.TabIndex = 21;
            this.radioVelocidadMax.Text = "Maxima";
            this.radioVelocidadMax.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarAT
            // 
            this.buttonCancelarAT.Location = new System.Drawing.Point(152, 49);
            this.buttonCancelarAT.Name = "buttonCancelarAT";
            this.buttonCancelarAT.Size = new System.Drawing.Size(142, 32);
            this.buttonCancelarAT.TabIndex = 22;
            this.buttonCancelarAT.Text = "Cancelar";
            this.buttonCancelarAT.UseVisualStyleBackColor = true;
            this.buttonCancelarAT.Click += new System.EventHandler(this.buttonCancelarAT_Click);
            // 
            // buttonAvanzarT
            // 
            this.buttonAvanzarT.Location = new System.Drawing.Point(152, 11);
            this.buttonAvanzarT.Name = "buttonAvanzarT";
            this.buttonAvanzarT.Size = new System.Drawing.Size(142, 32);
            this.buttonAvanzarT.TabIndex = 21;
            this.buttonAvanzarT.Text = "Ok";
            this.buttonAvanzarT.UseVisualStyleBackColor = true;
            this.buttonAvanzarT.Click += new System.EventHandler(this.buttonAvanzarT_Click);
            // 
            // panelDetenerTrasnporte
            // 
            this.panelDetenerTrasnporte.Controls.Add(this.numericUpDownPasajeros);
            this.panelDetenerTrasnporte.Controls.Add(this.label7);
            this.panelDetenerTrasnporte.Controls.Add(this.buttonCancelarDT);
            this.panelDetenerTrasnporte.Controls.Add(this.buttonBajarPasajeros);
            this.panelDetenerTrasnporte.Controls.Add(this.buttonSubirPasajeros);
            this.panelDetenerTrasnporte.Location = new System.Drawing.Point(660, 296);
            this.panelDetenerTrasnporte.Name = "panelDetenerTrasnporte";
            this.panelDetenerTrasnporte.Size = new System.Drawing.Size(297, 155);
            this.panelDetenerTrasnporte.TabIndex = 20;
            this.panelDetenerTrasnporte.Visible = false;
            // 
            // numericUpDownPasajeros
            // 
            this.numericUpDownPasajeros.Location = new System.Drawing.Point(6, 69);
            this.numericUpDownPasajeros.Name = "numericUpDownPasajeros";
            this.numericUpDownPasajeros.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPasajeros.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pasajeros";
            // 
            // buttonCancelarDT
            // 
            this.buttonCancelarDT.Location = new System.Drawing.Point(152, 113);
            this.buttonCancelarDT.Name = "buttonCancelarDT";
            this.buttonCancelarDT.Size = new System.Drawing.Size(142, 32);
            this.buttonCancelarDT.TabIndex = 23;
            this.buttonCancelarDT.Text = "Cancelar";
            this.buttonCancelarDT.UseVisualStyleBackColor = true;
            this.buttonCancelarDT.Click += new System.EventHandler(this.buttonCancelarDT_Click);
            // 
            // buttonBajarPasajeros
            // 
            this.buttonBajarPasajeros.Location = new System.Drawing.Point(152, 63);
            this.buttonBajarPasajeros.Name = "buttonBajarPasajeros";
            this.buttonBajarPasajeros.Size = new System.Drawing.Size(142, 32);
            this.buttonBajarPasajeros.TabIndex = 24;
            this.buttonBajarPasajeros.Text = "Bajar Pasajero(s)";
            this.buttonBajarPasajeros.UseVisualStyleBackColor = true;
            this.buttonBajarPasajeros.Click += new System.EventHandler(this.buttonBajarPasajeros_Click);
            // 
            // buttonSubirPasajeros
            // 
            this.buttonSubirPasajeros.Location = new System.Drawing.Point(152, 15);
            this.buttonSubirPasajeros.Name = "buttonSubirPasajeros";
            this.buttonSubirPasajeros.Size = new System.Drawing.Size(142, 32);
            this.buttonSubirPasajeros.TabIndex = 24;
            this.buttonSubirPasajeros.Text = "Subir Pasajero(s)";
            this.buttonSubirPasajeros.UseVisualStyleBackColor = true;
            this.buttonSubirPasajeros.Click += new System.EventHandler(this.buttonSubirPasajeros_Click);
            // 
            // panelCrearTransporte
            // 
            this.panelCrearTransporte.Controls.Add(this.buttonCancelarT);
            this.panelCrearTransporte.Controls.Add(this.buttonCrearT);
            this.panelCrearTransporte.Controls.Add(this.radioCrearTaxi);
            this.panelCrearTransporte.Controls.Add(this.radioCrearOmnibus);
            this.panelCrearTransporte.Controls.Add(this.label3);
            this.panelCrearTransporte.Location = new System.Drawing.Point(660, 107);
            this.panelCrearTransporte.Name = "panelCrearTransporte";
            this.panelCrearTransporte.Size = new System.Drawing.Size(297, 86);
            this.panelCrearTransporte.TabIndex = 21;
            this.panelCrearTransporte.Visible = false;
            // 
            // buttonCancelarT
            // 
            this.buttonCancelarT.Location = new System.Drawing.Point(152, 45);
            this.buttonCancelarT.Name = "buttonCancelarT";
            this.buttonCancelarT.Size = new System.Drawing.Size(142, 32);
            this.buttonCancelarT.TabIndex = 27;
            this.buttonCancelarT.Text = "Cancelar";
            this.buttonCancelarT.UseVisualStyleBackColor = true;
            this.buttonCancelarT.Click += new System.EventHandler(this.buttonCancelarT_Click);
            // 
            // buttonCrearT
            // 
            this.buttonCrearT.Location = new System.Drawing.Point(152, 7);
            this.buttonCrearT.Name = "buttonCrearT";
            this.buttonCrearT.Size = new System.Drawing.Size(142, 32);
            this.buttonCrearT.TabIndex = 22;
            this.buttonCrearT.Text = "Ok";
            this.buttonCrearT.UseVisualStyleBackColor = true;
            this.buttonCrearT.Click += new System.EventHandler(this.buttonCrearT_Click);
            // 
            // buttonMostrarTransporte
            // 
            this.buttonMostrarTransporte.Location = new System.Drawing.Point(115, 103);
            this.buttonMostrarTransporte.Name = "buttonMostrarTransporte";
            this.buttonMostrarTransporte.Size = new System.Drawing.Size(96, 32);
            this.buttonMostrarTransporte.TabIndex = 22;
            this.buttonMostrarTransporte.Text = "Mostrar";
            this.buttonMostrarTransporte.UseVisualStyleBackColor = true;
            this.buttonMostrarTransporte.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 546);
            this.Controls.Add(this.buttonMostrarTransporte);
            this.Controls.Add(this.panelCrearTransporte);
            this.Controls.Add(this.panelDetenerTrasnporte);
            this.Controls.Add(this.panelAvanzarTransporte);
            this.Controls.Add(this.radioSelectTodos);
            this.Controls.Add(this.buttonCrearTransporte);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioSelectTaxi);
            this.Controls.Add(this.radioSelectOmnibus);
            this.Controls.Add(this.buttonDetenerTransporte);
            this.Controls.Add(this.buttonAvanzarTransporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelAvanzarTransporte.ResumeLayout(false);
            this.panelAvanzarTransporte.PerformLayout();
            this.panelDetenerTrasnporte.ResumeLayout(false);
            this.panelDetenerTrasnporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasajeros)).EndInit();
            this.panelCrearTransporte.ResumeLayout(false);
            this.panelCrearTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAvanzarTransporte;
        private System.Windows.Forms.Button buttonDetenerTransporte;
        private System.Windows.Forms.RadioButton radioSelectOmnibus;
        private System.Windows.Forms.RadioButton radioSelectTaxi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.RadioButton radioCrearTaxi;
        private System.Windows.Forms.RadioButton radioCrearOmnibus;
        private System.Windows.Forms.Button buttonCrearTransporte;
        private System.Windows.Forms.RadioButton radioSelectTodos;
        private System.Windows.Forms.Panel panelAvanzarTransporte;
        private System.Windows.Forms.Panel panelDetenerTrasnporte;
        private System.Windows.Forms.Button buttonCancelarAT;
        private System.Windows.Forms.Button buttonAvanzarT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCancelarDT;
        private System.Windows.Forms.Button buttonBajarPasajeros;
        private System.Windows.Forms.Button buttonSubirPasajeros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioVelocidadMin;
        private System.Windows.Forms.RadioButton radioVelocidadMax;
        private System.Windows.Forms.Panel panelCrearTransporte;
        private System.Windows.Forms.Button buttonCancelarT;
        private System.Windows.Forms.Button buttonCrearT;
        private System.Windows.Forms.Button buttonMostrarTransporte;
        private System.Windows.Forms.NumericUpDown numericUpDownPasajeros;
    }
}

