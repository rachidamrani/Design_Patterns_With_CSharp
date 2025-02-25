using Builder;

Console.WriteLine("---Builder Design Pattern---");

IBuilder builder = new ComplexProductBuilder(); // can be injected by dependency injection
ProductDirector director = new ProductDirector(builder);

director.ConstructProduct();

Product product = builder.Build();

Console.WriteLine(product);