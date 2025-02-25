using Builder;

Console.WriteLine("---Builder Design Pattern---");

IBuilder builder = new SimpleProductBuilder();
ProductDirector director = new ProductDirector(builder);

director.ConstructProduct();

Product product = builder.Build();

Console.WriteLine(product);