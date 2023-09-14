namespace Interface_Example
{
    public class Civic : ICar
    {
        public int howManyWheels()
        {
            return 4;
        }

        public Color whatColor()
        {
            return Color.Lacivert;
        }

        public Brand whichBrand()
        {
            return Brand.Honda;
        }
    }
}