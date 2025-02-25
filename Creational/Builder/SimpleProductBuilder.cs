namespace Builder;

public class SimpleProductBuilder : IBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    
    public void BuildName()
    {
        _name = "Simple product";
    }

    public void BuildDescription()
    {
        _description = "This is a simple product";
    }

    public Product Build()
    {
        return new Product(_name, _description);
    }
}