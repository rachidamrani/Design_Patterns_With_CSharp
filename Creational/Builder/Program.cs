using Builder;

Console.WriteLine("---Builder Design Pattern---");

Pizza pizza = new Pizza.Builder()
                .SetDough(dough => dough
                        .SetThickness(3)
                        .SetFlour("whole wheat"))
                .SetSauce("Spicy tomato sauce")
                .SetCheese("Vegan cheese")
                .AddTopping("Olives")
                .AddTopping("Onions")
                .Build();

Console.WriteLine(pizza);