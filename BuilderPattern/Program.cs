using System;

namespace BuilderPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder); 

            director.Construct();
            Product product = builder.GetResult();

            Console.WriteLine($"Size: {product.Size}\nColor: {product.Color}");
        }
    }
}
