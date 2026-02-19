using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Claims;

// Головна програма
class Program
{
    static void Main()
    {
        List<Furniture> furnitureList = new List<Furniture>
        {
            new Chair("Wood"),
            new Table("Metal"),
            new Wardrobe("Oak")
        };

        foreach (Furniture item in furnitureList)
        {
            item.Assemble();
            Console.WriteLine();
        }
    }
}

// Базовий клас
abstract class Furniture
{
    protected string material;

    public Furniture(string material)
    {
        this.material = material;
    }

    public abstract void Assemble();
}