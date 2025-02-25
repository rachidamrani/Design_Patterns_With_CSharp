using Builder;

Console.WriteLine("---Builder Design Pattern---");

Dough dough = new Dough.Builder()
                .SetThickness(3)
                .SetFlour("Whole wheat")
                .Build();


Pizza pizza = new Pizza.Builder()
                .SetDough(dough)
                .SetSauce("Spicy tomato sauce")
                .SetCheese("Vegan cheese")
                .AddTopping("Olives")
                .AddTopping("Onions")
                .Build();

Console.WriteLine(pizza);