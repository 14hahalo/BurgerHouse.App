using BurgerHouse.App.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerHouse.App
{
    public partial class MenuInfo : Form
    {
        public MenuInfo()
        {
            InitializeComponent();
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            BurgerMenu burgerAddNewMenu = new BurgerMenu();
            burgerAddNewMenu.Price = Convert.ToDecimal(nudMenuPrice.Value);
            burgerAddNewMenu.MenuName = txtMenuName.Text;
            LoginScreen.burgerMenuList.Add(burgerAddNewMenu);
            DialogResult save= MessageBox.Show("Saved Successfully.","Burger Menu",MessageBoxButtons.OK, MessageBoxIcon.Information);
            nudMenuPrice.Value=0;
            txtMenuName.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
