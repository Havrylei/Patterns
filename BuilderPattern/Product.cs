namespace BuilderPattern
{
  internal class Product
  {
    public int Size { get; private set; }
    public string Color {get; private set; }

    public Product(int size, string color)
    {
      Size = size;
      Color = color;
    } 
  }
}