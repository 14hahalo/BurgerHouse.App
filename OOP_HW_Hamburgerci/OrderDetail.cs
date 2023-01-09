using BurgerHouse.App.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BurgerHouse.App
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
        public static BindingList<Order> allOrderList = new BindingList<Order>();

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = LoginScreen.burgerMenuList;
            #region CreateExtra
            /*Checkboxları tek tek yerine foreach ile oluşturdum, metot da kullanılabilirmiş.*/
            foreach (Extras ExtraMaterial in LoginScreen.ExtraMaterialList)
            {
                CheckBox extra = new CheckBox()
                { Height = 20, Width = 120, Text = ExtraMaterial.ExtraMaterialName + " " + ExtraMaterial.ExtraMaterialPrice + " TL", Tag = ExtraMaterial };
                flpExtras.Controls.Add(extra);
            }
            #endregion
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order currentOrder = new Order();
            Order allOrders = new Order();
            currentOrder.SelectedBurgerMenu = (BurgerMenu)cmbMenu.SelectedItem;
            if (rdbBig.Checked == true) { currentOrder.SelectedMenuSize = "Big"; }
            if (rdbMid.Checked == true) { currentOrder.SelectedMenuSize = "Mid"; }
            if (rdbSmall.Checked == true) { currentOrder.SelectedMenuSize = "Small"; }
            currentOrder.SelectedExtras = new List<Extras>();

            foreach (CheckBox ExtraMaterial in flpExtras.Controls)
            {
                if (ExtraMaterial.Checked)
                {
                    currentOrder.SelectedExtras.Add((Extras)(ExtraMaterial.Tag));
                }
            }
            currentOrder.NumberofOrderedMenu = Convert.ToInt32(nudQuantity.Value);
            currentOrder.CostCalculation();
            lsbOrders.Items.Add(currentOrder);
            allOrderList.Add(currentOrder);
            TotalOrderQuantity++;
            endorsement += TotalEndorsement();
            totalSaleProductQuantity++;
        }
        private decimal TotalEndorsement()
        {
            decimal TotalEndorsement = 0;
            foreach (Order currentOrder in lsbOrders.Items)
            {
                TotalEndorsement += currentOrder.TotalCost;
            }
            lblCost.Text = TotalEndorsement.ToString();
            return TotalEndorsement;
        }
        public static decimal endorsement = 0;
        public static int TotalOrderQuantity = 0;
        public static decimal ExtraMaterialIncome = 0;
        public static decimal totalSaleProductQuantity = 0;
        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult complete = MessageBox.Show("Total Cost:" + TotalEndorsement().ToString() + "\nCould you complete this order ?", "Order Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (complete == DialogResult.Yes)
            {
                lsbOrders.Items.Clear();
                TotalEndorsement();
                MessageBox.Show("Order Completed");
            }
            else if (complete == DialogResult.No)
            {
                MessageBox.Show("You're redirected to Main Screen.");
            }
        }
    }
}

