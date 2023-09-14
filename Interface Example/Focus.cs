namespace Interface_Example
{
    public class Focus : ICar
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
            return Brand.Ford;
        }
    }
}