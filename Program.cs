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

// Клас Chair
class Chair : Furniture
{
    public Chair(string material) : base(material) { }

    public override void Assemble()
    {
        Console.WriteLine($"Chair made of {material}:");
        Console.WriteLine("1. Attach legs.");
        Console.WriteLine("2. Fix the seat.");
        Console.WriteLine("3. Secure the backrest.");
    }
}

// Клас Table
class Table : Furniture
{
    public Table(string material) : base(material) { }

    public override void Assemble()
    {
        Console.WriteLine($"Table made of {material}:");
        Console.WriteLine("1. Attach legs to tabletop.");
        Console.WriteLine("2. Tighten screws.");
    }
}

// Клас Wardrobe
class Wardrobe : Furniture
{
    public Wardrobe(string material) : base(material) { }

    public override void Assemble()
    {
        Console.WriteLine($"Wardrobe made of {material}:");
        Console.WriteLine("1. Assemble frame.");
        Console.WriteLine("2. Install shelves.");
        Console.WriteLine("3. Attach doors.");
    }
}