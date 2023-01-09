using BurgerHouse.App.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BurgerHouse.App
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            OrderDetail OrderDetail = new OrderDetail();
            OrderDetail.Show();
        }

        private void OrderInformation_Click(object sender, EventArgs e)
        {
            ListAllOrders ShowShoppingCart = new ListAllOrders();
            ShowShoppingCart.Show();
        }

        private void NewMenu_Click(object sender, EventArgs e)
        {
            MenuInfo AddNewMenu = new MenuInfo();
            AddNewMenu.Show();

        }

        private void NewExtraMaterial_Click(object sender, EventArgs e)
        {
            ExtraMaterialInfo AddExtraMaterial = new ExtraMaterialInfo();
            AddExtraMaterial.Show();
        }
        public static List<BurgerMenu> burgerMenuList = new List<BurgerMenu>()
        { new BurgerMenu {MenuName="CheeseBurger(140 gr)",Price=81 },
        new BurgerMenu {MenuName="Konya Küflüsü (140gr)",Price=87 },
        new BurgerMenu {MenuName="Aioli Burger (140 gr)",Price=87 },
        new BurgerMenu {MenuName="Mush Burger (140gr)",Price=89 },
        new BurgerMenu {MenuName="Vişne Tulum (140gr)",Price=89 }
        };
        public static List<Extras> ExtraMaterialList = new List<Extras>()
        { new Extras {ExtraMaterialName="Ranch Sos",ExtraMaterialPrice=5 },
        new Extras {ExtraMaterialName="Hardal Sos",ExtraMaterialPrice=3 },
        new Extras {ExtraMaterialName="Barbekü Sos",ExtraMaterialPrice=5 },
        new Extras {ExtraMaterialName="Acı Sos",ExtraMaterialPrice=3 }
        };

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
