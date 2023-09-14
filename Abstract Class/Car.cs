namespace Abstract_Class
{
    public abstract class Car
    {
        public int howManyWheels()
        {
            return 4;
        }

        public virtual Color whatColor()
        {
            return Color.Beyaz;
        }

        public abstract Brand whichBrand();
    }
}