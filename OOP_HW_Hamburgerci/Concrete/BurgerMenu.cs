namespace BurgerHouse.App.Concrete
{
    public class BurgerMenu
    {
        public string MenuName { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return $"{MenuName} Menü {Price} TL";
        }
    }
}
