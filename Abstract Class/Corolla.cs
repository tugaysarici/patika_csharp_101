namespace Abstract_Class
{
    public class Corolla : ICar
    {
        public int howManyWheels()
        {
            return 4;
        }

        public Color whatColor()
        {
            return Color.Beyaz;
        }

        public Brand whichBrand()
        {
            return Brand.Toyota;
        }
    }
}