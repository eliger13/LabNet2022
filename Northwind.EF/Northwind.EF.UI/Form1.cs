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
        bool updateOrderDetail = false;
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

        #region Show Reports-Shippers and Order Details
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
        #endregion

        #region Insert Shipper
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
        #endregion

        #region Update Shipper
        private void ButtonActualizarShippers_Click(object sender, EventArgs e)
        {
            try
            {
                Shippers shipper = (Shippers)(dataGridViewShippers.SelectedRows[0].DataBoundItem);
                if (updateShipper)
                {
                    UpdateShipper(shipper.ShipperID, textBoxShipperCompanyName.Text, textBoxShipperPhone.Text);
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
        public void UpdateShipper(int shipperID, string companyName, string phone)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Update(new Shippers
            {
                ShipperID = shipperID,
                CompanyName = companyName,
                Phone = phone
            });
        }
        #endregion

        #region Delete Shipper
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
        #endregion

        private void ButtonCancelarShipper_Click(object sender, EventArgs e)
        {
            textBoxShipperCompanyName.Text = "";
            textBoxShipperPhone.Text = "";
            ListarShippers();
        }

        #region Update Order Detail
        private void ButtonActualizarOD_Click(object sender, EventArgs e)
        {
            try
            {
                Order_Details order_Details = (Order_Details)(dataGridViewOrderDetails.SelectedRows[0].DataBoundItem);
                if (updateOrderDetail)
                {
                    UpdateOrderDetails(order_Details.OrderID, order_Details.ProductID, Convert.ToDecimal(numericODUnitPrice.Value), ((short)numericODQuantity.Value), ((float)numericODDiscount.Value));
                    MessageBox.Show("The Order has been updated successfully.");
                    ButtonActualizarOD.Text = "Update";
                    updateOrderDetail = false;
                    ListarOrderDetails();
                    numericODUnitPrice.Value = 0;
                    numericODQuantity.Value = 0;
                    numericODDiscount.Value = 0;
                }
                else
                {
                    numericODUnitPrice.Value = order_Details.UnitPrice;
                    numericODQuantity.Value = order_Details.Quantity;
                    numericODDiscount.Value = Convert.ToDecimal(order_Details.Discount);
                    ButtonActualizarOD.Text = "Save";
                    updateOrderDetail = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateOrderDetails(int orderID, int productID, decimal unitPrice, short quantity, float discount)
        {
            Order_DetailsLogic order_DetailsLogic = new Order_DetailsLogic();
            order_DetailsLogic.Update(new Order_Details
            {
                OrderID = orderID,
                ProductID = productID,
                UnitPrice = unitPrice,
                Quantity = quantity,
                Discount = discount
            });
        }
        #endregion

        #region Delete Order Detail
        private void ButtonEliminarOD_Click(object sender, EventArgs e)
        {
            try
            {
                Order_Details order_Details = (Order_Details)(dataGridViewOrderDetails.SelectedRows[0].DataBoundItem);
                if (MessageBox.Show("Do you want to delete this order?", "Question",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DeleteOrderDetail(order_Details.OrderID, order_Details.ProductID);
                    ListarOrderDetails();
                    MessageBox.Show($"The order has been delete successfully.");
                }
                else
                {
                    MessageBox.Show("The order was not deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteOrderDetail(int ordId, int prdId)
        {
            Order_DetailsLogic order_Details = new Order_DetailsLogic();
            order_Details.Delete(ordId, prdId);
        }
        #endregion

        private void ButtonCancelarOD_Click(object sender, EventArgs e)
        {
            numericODUnitPrice.Value = 0;
            numericODQuantity.Value = 0;
            numericODDiscount.Value = 0;
            ListarOrderDetails();
        }

        private void ButtonSalir_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
