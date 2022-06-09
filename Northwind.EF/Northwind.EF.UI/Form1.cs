using System.Collections.Generic;
using System.Windows.Forms;
using Northwind.EF.Logic;
using Northwind.EF.Entities;
using System;

namespace Northwind.EF.UI
{
    public partial class Form1 : Form
    {
        bool updateShipper = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            dataGridViewShippers.ReadOnly = true;
            dataGridViewShippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewShippers.MultiSelect = false;
            ListarShippers();

            dataGridViewOrderDetails.ReadOnly = true;
            dataGridViewOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrderDetails.MultiSelect = false;
            ListarOrderDetails();
        }

        public void ListarShippers()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            dataGridViewShippers.DataSource = null;
            dataGridViewShippers.DataSource = shippersLogic.GetAll();
        }

        public void ListarOrderDetails()
        {
            Order_DetailsLogic order_DetailsLogic = new Order_DetailsLogic();
            dataGridViewOrderDetails.DataSource = null;
            dataGridViewOrderDetails.DataSource = order_DetailsLogic.GetAll();
        }

        private void ButtonGuardarShipper_Click(object sender, System.EventArgs e)
        {
            try
            {
                InsertarShipper(textBoxShipperCompanyName.Text, textBoxShipperPhone.Text);
                ListarShippers();
                textBoxShipperCompanyName.Text = "";
                textBoxShipperPhone.Text = "";
                MessageBox.Show($"The shipper has been added successfully.");
            } 
            // Añadir aca una exepcion personalizada
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertarShipper(string companyName, string phone)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Add(new Shippers
            {
                CompanyName = companyName,
                Phone = phone
            });
        }

        private void ButtonActualizarShippers_Click(object sender, EventArgs e)
        {
            try
            {
                Shippers shipper = (Shippers)(dataGridViewShippers.SelectedRows[0].DataBoundItem);
                if (updateShipper)
                {
                    ActualizarShipper(shipper.ShipperID, textBoxShipperCompanyName.Text, textBoxShipperPhone.Text);
                    MessageBox.Show("The shipper has been updated successfully.");
                    ButtonActualizarShippers.Text = "Update";
                    updateShipper = false;
                    ListarShippers();
                    textBoxShipperCompanyName.Text = "";
                    textBoxShipperPhone.Text = "";
                    ButtonAñadirShipper.Enabled = true;
                }
                else
                {
                    textBoxShipperCompanyName.Text = shipper.CompanyName;
                    textBoxShipperPhone.Text = shipper.Phone;
                    ButtonActualizarShippers.Text = "Save";
                    updateShipper = true;
                    ButtonAñadirShipper.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarShipper(int shipperID, string companyName, string phone)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Update(new Shippers
            {
                ShipperID = shipperID,
                CompanyName = companyName,
                Phone = phone
            });
        }

        private void ButtonEliminarShipper_Click(object sender, EventArgs e)
        {
            try
            {
                Shippers shipper = (Shippers)(dataGridViewShippers.SelectedRows[0].DataBoundItem);
                if (MessageBox.Show("Do you want to delete this shipper?", "Question",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    EliminarShipper(shipper.ShipperID);
                    ListarShippers();
                    MessageBox.Show($"The shipper has been delete successfully.");
                }
                else
                {
                    MessageBox.Show("The shipper was not deleted.");
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("It's not possible to delete the selected shipper because has a related data.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarShipper(int id)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Delete(id);
        }

        private void ButtonSalir_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
