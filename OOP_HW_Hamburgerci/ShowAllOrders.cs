using System;
using System.Windows.Forms;

namespace BurgerHouse.App
{
    public partial class ListAllOrders : Form
    {
        public ListAllOrders()
        {
            InitializeComponent();
        }

        public void ListAllOrders_Load(object sender, EventArgs e)
        {
            label3.Text = OrderDetail.TotalOrderQuantity.ToString();
            label2.Text = OrderDetail.endorsement.ToString();
            label4.Text = OrderDetail.ExtraMaterialIncome.ToString();
            label5.Text = OrderDetail.totalSaleProductQuantity.ToString();
            lsbAllOrders.DataSource = OrderDetail.allOrderList;
        }
    }
}
