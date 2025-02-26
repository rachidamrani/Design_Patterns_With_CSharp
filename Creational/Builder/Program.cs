using Builder;

Console.WriteLine("---Builder Design Pattern---");

/*
1. Identify the distinct steps
2. Define each step as an interface
3. Add a method (one or more) that move you to the next step
4. Have the last step build the underlying product
5. Implement the interfaces in the builder
6. Add an entry point in the builder, that returns the first step
*/

Pizza pizza = Pizza.Builder.Start()
                .SetDough(dough => dough
                        .SetThickness(4)
                        .SetFlour("whole wheat"))
                .SetSauce("Spicy tomato sauce")
                .SetCheese("Vegan cheese")
                .AddTopping("Olives")
                .AddTopping("Onions")
                .Build();

Console.WriteLine(pizza);