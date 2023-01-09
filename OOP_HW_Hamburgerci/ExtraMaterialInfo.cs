using BurgerHouse.App.Concrete;
using System;
using System.Windows.Forms;

namespace BurgerHouse.App
{
    public partial class ExtraMaterialInfo : Form
    {
        public ExtraMaterialInfo()
        {

        }

        private void btnSaveExtraMaterial_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            Extras ExtraMaterial = new Extras();
            ExtraMaterial.ExtraMaterialPrice = Convert.ToDecimal(nudExtraPrice.Value);
            ExtraMaterial.ExtraMaterialName = txtExtraMaterialName.Text;
            LoginScreen.ExtraMaterialList.Add(ExtraMaterial);
            DialogResult save = MessageBox.Show("Succesfully saved.", "Extra Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nudExtraPrice.Value = 0;
            txtExtraMaterialName.Text = string.Empty;
        }
    }
}
