namespace BuilderPattern
{
  internal class ConcreteBuilder : IBuilder
  {
    public int Size { get; set; }
    public string Color { get; set; }

    public Product GetResult()
    {
      var result = new Product(Size, Color);

      return result;
    }
  }
}