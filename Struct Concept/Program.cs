using System;

namespace Struct_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular rec1 = new Rectangular();
            rec1.shortEdge = 3;
            rec1.longEdge = 4;
            Console.WriteLine("The area of the rectangular according to class: {0}", rec1.calculateArea());

            RectangularStruct recStruct1 = new RectangularStruct();
            recStruct1.shortEdge = 3;
            recStruct1.longEdge = 4;
            Console.WriteLine("The area of the rectangular according to struct: {0}", recStruct1.calculateArea());

            RectangularStruct recStruct2;
            recStruct2.shortEdge = 5;
            recStruct2.longEdge = 6;
            Console.WriteLine("The area of the rectangular according to struct: {0}", recStruct2.calculateArea());

            RectangularStruct recStruct3 = new RectangularStruct(7, 10);
            recStruct3.shortEdge = 5;
            recStruct3.longEdge = 6;
            Console.WriteLine("The area of the rectangular according to struct: {0}", recStruct3.calculateArea());
        }
    }

    class Rectangular
    {
        public int shortEdge;
        public int longEdge;

        public Rectangular()
        {
            shortEdge = 7;
            longEdge = 10;
        }
        public long calculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangularStruct
    {
        public int shortEdge;
        public int longEdge;

        public RectangularStruct(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }
        public long calculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }
}
