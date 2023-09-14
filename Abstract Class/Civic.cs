namespace Abstract_Class
{
    public class Civic : ICar
    {
        public int howManyWheels()
        {
            return 4;
        }

        public Color whatColor()
        {
            return Color.Gri;
        }

        public Brand whichBrand()
        {
            return Brand.Honda;
        }
    }
}