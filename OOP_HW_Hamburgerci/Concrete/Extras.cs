namespace BurgerHouse.App.Concrete
{
    public class Extras
    {
        public string ExtraMaterialName { get; set; }
        public decimal ExtraMaterialPrice { get; set; }
        public override string ToString()
        {
            return ExtraMaterialName + ExtraMaterialPrice;
        }
    }
}
