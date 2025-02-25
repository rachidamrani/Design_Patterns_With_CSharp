namespace Builder;

public class ProductDirector
{
    private readonly IBuilder _builder;

    public ProductDirector(IBuilder builder)
    {
        _builder = builder;
    }
    public void ConstructProduct()
    {
        _builder.BuildName();
        _builder.BuildDescription();
    }
}