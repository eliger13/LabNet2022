namespace Northwind.EF.UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEliminarShipper = new System.Windows.Forms.Button();
            this.ButtonAñadirShipper = new System.Windows.Forms.Button();
            this.ButtonCancelarShipper = new System.Windows.Forms.Button();
            this.dataGridViewShippers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonActualizarShippers = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxShipperCompanyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShipperPhone = new System.Windows.Forms.TextBox();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonCancelarOD = new System.Windows.Forms.Button();
            this.ButtonEliminarOD = new System.Windows.Forms.Button();
            this.ButtonActualizarOD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericODUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.numericODQuantity = new System.Windows.Forms.NumericUpDown();
            this.numericODDiscount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 0;
            // 
            // ButtonEliminarShipper
            // 
            this.ButtonEliminarShipper.Location = new System.Drawing.Point(303, 167);
            this.ButtonEliminarShipper.Name = "ButtonEliminarShipper";
            this.ButtonEliminarShipper.Size = new System.Drawing.Size(86, 38);
            this.ButtonEliminarShipper.TabIndex = 1;
            this.ButtonEliminarShipper.Text = "Delete";
            this.ButtonEliminarShipper.UseVisualStyleBackColor = true;
            this.ButtonEliminarShipper.Click += new System.EventHandler(this.ButtonEliminarShipper_Click);
            // 
            // ButtonAñadirShipper
            // 
            this.ButtonAñadirShipper.Location = new System.Drawing.Point(303, 123);
            this.ButtonAñadirShipper.Name = "ButtonAñadirShipper";
            this.ButtonAñadirShipper.Size = new System.Drawing.Size(86, 38);
            this.ButtonAñadirShipper.TabIndex = 2;
            this.ButtonAñadirShipper.Text = "Add";
            this.ButtonAñadirShipper.UseVisualStyleBackColor = true;
            this.ButtonAñadirShipper.Click += new System.EventHandler(this.ButtonGuardarShipper_Click);
            // 
            // ButtonCancelarShipper
            // 
            this.ButtonCancelarShipper.Location = new System.Drawing.Point(303, 211);
            this.ButtonCancelarShipper.Name = "ButtonCancelarShipper";
            this.ButtonCancelarShipper.Size = new System.Drawing.Size(86, 38);
            this.ButtonCancelarShipper.TabIndex = 3;
            this.ButtonCancelarShipper.Text = "Cancel";
            this.ButtonCancelarShipper.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShippers
            // 
            this.dataGridViewShippers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippers.Location = new System.Drawing.Point(408, 70);
            this.dataGridViewShippers.Name = "dataGridViewShippers";
            this.dataGridViewShippers.RowHeadersWidth = 51;
            this.dataGridViewShippers.RowTemplate.Height = 24;
            this.dataGridViewShippers.Size = new System.Drawing.Size(511, 189);
            this.dataGridViewShippers.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Company Name";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(367, 355);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 51;
            this.dataGridViewOrderDetails.RowTemplate.Height = 24;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(552, 189);
            this.dataGridViewOrderDetails.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order Details";
            // 
            // ButtonActualizarShippers
            // 
            this.ButtonActualizarShippers.Location = new System.Drawing.Point(303, 79);
            this.ButtonActualizarShippers.Name = "ButtonActualizarShippers";
            this.ButtonActualizarShippers.Size = new System.Drawing.Size(86, 38);
            this.ButtonActualizarShippers.TabIndex = 10;
            this.ButtonActualizarShippers.Text = "Update";
            this.ButtonActualizarShippers.UseVisualStyleBackColor = true;
            this.ButtonActualizarShippers.Click += new System.EventHandler(this.ButtonActualizarShippers_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shippers";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(187, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 12;
            // 
            // textBoxShipperCompanyName
            // 
            this.textBoxShipperCompanyName.Location = new System.Drawing.Point(123, 123);
            this.textBoxShipperCompanyName.Name = "textBoxShipperCompanyName";
            this.textBoxShipperCompanyName.Size = new System.Drawing.Size(174, 22);
            this.textBoxShipperCompanyName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone";
            // 
            // textBoxShipperPhone
            // 
            this.textBoxShipperPhone.Location = new System.Drawing.Point(123, 170);
            this.textBoxShipperPhone.Name = "textBoxShipperPhone";
            this.textBoxShipperPhone.Size = new System.Drawing.Size(174, 22);
            this.textBoxShipperPhone.TabIndex = 15;
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(910, 6);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(80, 38);
            this.ButtonSalir.TabIndex = 16;
            this.ButtonSalir.Text = "Exit";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantity";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(171, 408);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 16);
            this.linkLabel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Unit Price";
            // 
            // ButtonCancelarOD
            // 
            this.ButtonCancelarOD.Location = new System.Drawing.Point(262, 465);
            this.ButtonCancelarOD.Name = "ButtonCancelarOD";
            this.ButtonCancelarOD.Size = new System.Drawing.Size(86, 38);
            this.ButtonCancelarOD.TabIndex = 18;
            this.ButtonCancelarOD.Text = "Cancel";
            this.ButtonCancelarOD.UseVisualStyleBackColor = true;
            // 
            // ButtonEliminarOD
            // 
            this.ButtonEliminarOD.Location = new System.Drawing.Point(262, 416);
            this.ButtonEliminarOD.Name = "ButtonEliminarOD";
            this.ButtonEliminarOD.Size = new System.Drawing.Size(86, 38);
            this.ButtonEliminarOD.TabIndex = 25;
            this.ButtonEliminarOD.Text = "Delete";
            this.ButtonEliminarOD.UseVisualStyleBackColor = true;
            // 
            // ButtonActualizarOD
            // 
            this.ButtonActualizarOD.Location = new System.Drawing.Point(262, 372);
            this.ButtonActualizarOD.Name = "ButtonActualizarOD";
            this.ButtonActualizarOD.Size = new System.Drawing.Size(86, 38);
            this.ButtonActualizarOD.TabIndex = 26;
            this.ButtonActualizarOD.Text = "Update";
            this.ButtonActualizarOD.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Discount";
            // 
            // numericODUnitPrice
            // 
            this.numericODUnitPrice.DecimalPlaces = 2;
            this.numericODUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericODUnitPrice.Location = new System.Drawing.Point(107, 382);
            this.numericODUnitPrice.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericODUnitPrice.Name = "numericODUnitPrice";
            this.numericODUnitPrice.Size = new System.Drawing.Size(120, 22);
            this.numericODUnitPrice.TabIndex = 28;
            // 
            // numericODQuantity
            // 
            this.numericODQuantity.Location = new System.Drawing.Point(107, 425);
            this.numericODQuantity.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericODQuantity.Name = "numericODQuantity";
            this.numericODQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericODQuantity.TabIndex = 29;
            // 
            // numericODDiscount
            // 
            this.numericODDiscount.DecimalPlaces = 2;
            this.numericODDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericODDiscount.Location = new System.Drawing.Point(107, 470);
            this.numericODDiscount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericODDiscount.Name = "numericODDiscount";
            this.numericODDiscount.Size = new System.Drawing.Size(120, 22);
            this.numericODDiscount.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-8, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1954, 4);
            this.label9.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericODDiscount);
            this.Controls.Add(this.numericODQuantity);
            this.Controls.Add(this.numericODUnitPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonActualizarOD);
            this.Controls.Add(this.ButtonEliminarOD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonCancelarOD);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.textBoxShipperPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxShipperCompanyName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonActualizarShippers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewShippers);
            this.Controls.Add(this.ButtonCancelarShipper);
            this.Controls.Add(this.ButtonAñadirShipper);
            this.Controls.Add(this.ButtonEliminarShipper);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericODDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEliminarShipper;
        private System.Windows.Forms.Button ButtonAñadirShipper;
        private System.Windows.Forms.Button ButtonCancelarShipper;
        private System.Windows.Forms.DataGridView dataGridViewShippers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonActualizarShippers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxShipperCompanyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShipperPhone;
        private System.Windows.Forms.Button ButtonSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonCancelarOD;
        private System.Windows.Forms.Button ButtonEliminarOD;
        private System.Windows.Forms.Button ButtonActualizarOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericODUnitPrice;
        private System.Windows.Forms.NumericUpDown numericODQuantity;
        private System.Windows.Forms.NumericUpDown numericODDiscount;
        private System.Windows.Forms.Label label9;
    }
}

