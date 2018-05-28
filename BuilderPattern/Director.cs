namespace BuilderPattern
{
  internal class Director 
  {
    private readonly IBuilder _builder;

    public Director(IBuilder builder)
    {
      _builder = builder;
    }

    public void Construct()
    {
      _builder.Size = 255;
      _builder.Color = "Green";
    }
  }
}