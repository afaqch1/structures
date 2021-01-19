using System;

namespace structures
{

    struct Square
    {
        public int length;
        public float area;

        public Square(int l,float a)
        {
            this.length = l;
            this.area = a;
        }

        public void show()
        {
            System.Console.WriteLine(length);
            System.Console.WriteLine(area);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("/////////Create object using new keyword///////////////");
            Square obj = new Square(32,4);
            obj.show();

            System.Console.WriteLine("/////////Create object without new keyword///////////////");
            Square obj1;
            obj1.length = 22;
            obj1.area = 5;
            obj1.show();

        }
    }
}
