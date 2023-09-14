namespace Abstract_Class
{
    public class NewCivic : Car
    {
        public override Brand whichBrand()
        {
            return Brand.Honda;
        }

        public override Color whatColor()
        {
            return Color.Gri;
        }
    }
}