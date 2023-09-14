namespace Interface_Example
{
    public class Corolla : ICar
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
            return Brand.Toyota;
        }
    }
}