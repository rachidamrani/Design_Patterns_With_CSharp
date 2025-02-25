using Builder;

Console.WriteLine("---Builder Design Pattern---");

Product.Builder builder = new Product.Builder();

Product product = builder
                    .SetName("Simple product")
                    .SetDescription("Product Description")
                    .Build();

Console.WriteLine(product);