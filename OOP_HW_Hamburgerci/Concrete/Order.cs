using System.Collections.Generic;

namespace BurgerHouse.App.Concrete
{
    public class Order
    {
        public BurgerMenu SelectedBurgerMenu { get; set; }
        /*ekstra malzemeler zaten liste olarak tanımlı, ancak sipariş alındığında siparişi alınan ekstra malzemeleri tutmak için ayrı bir liste gerekti*/
        public List<Extras> SelectedExtras { get; set; }
        public int NumberofOrderedMenu { get; set; }
        public string SelectedMenuSize { get; set; }
        public decimal TotalCost { get; set; }
        public void CostCalculation()
        {
            TotalCost = 0;
            TotalCost += SelectedBurgerMenu.Price;
            /*Menü Sizeuna göre, liste fiyatına artı Costlar eklendi*/
            if (SelectedMenuSize == "Big") { TotalCost += 20; }
            if (SelectedMenuSize == "Mid") { TotalCost += 10; }
            if (SelectedMenuSize == "Small") { TotalCost += 0; }

            foreach (Extras ExtraMaterial in SelectedExtras)
            {/*Sipariş Costı hesaplanırken ekstra malzemeler için dönen foreach'ten faydalanıp Total ekstra malzeme gelirini de hesaplattık*/
                OrderDetail.ExtraMaterialIncome += ExtraMaterial.ExtraMaterialPrice;
                TotalCost += ExtraMaterial.ExtraMaterialPrice;
            }
            TotalCost *= NumberofOrderedMenu;
        }
        public override string ToString()
        {/*Herhangi bir ekstra malzeme yoksa listbox'ta görünüm formatı ayarlanacak*/
            if (SelectedExtras.Count < 1) return string.Format("{0} Menu,x{1} Quantity,{2} Size,Total:{3}", SelectedBurgerMenu.MenuName, NumberofOrderedMenu, SelectedMenuSize, TotalCost.ToString());
            else
            {/*Ekstra malzeme var olursaki listbox formatı*/
                string ExtraMaterials = null;
                foreach (Extras extraMaterial in SelectedExtras)
                { ExtraMaterials += extraMaterial.ExtraMaterialName + "-"; }

                ExtraMaterials = ExtraMaterials.Trim('-');
                return string.Format("{0} Menu,x{1} Quantity,{2} Size,[{3}],Total:{4}", SelectedBurgerMenu.MenuName, NumberofOrderedMenu, SelectedMenuSize, ExtraMaterials, TotalCost.ToString());
            }
        }
    }
}
