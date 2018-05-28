namespace BuilderPattern
{
  internal interface IBuilder
  {
    int Size { get; set; }
    string Color { get; set; }

    Product GetResult();
  }
}