﻿using Builder;

Console.WriteLine("---Builder Design Pattern---");

IBuilder builder = new ComplexProductBuilder(); // can be injected by dependency injection

builder.BuildName();
builder.BuildDescription();

Product product = builder.Build();

Console.WriteLine(product);