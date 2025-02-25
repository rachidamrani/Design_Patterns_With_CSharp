using Builder;

Console.WriteLine("---Builder Design Pattern---");

Product.Builder builder = new();

builder.BuildName("Simple product");
builder.BuildDescription("Product description");

Product product = builder.Build();

Console.WriteLine(product);