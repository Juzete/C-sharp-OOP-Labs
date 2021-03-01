using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public abstract class Product
    {
   
        private float price;
        private static int countProduct;



    protected float Price
    {
        get
        { return price; }
        set
        { price = value; }
    }

    public Product(float price)
    {
        Price = price;
        countProduct++;
    }

    public Product(Product product)
    {
        Price = product.Price;
        countProduct++;
    }


    public override string ToString()
    {
        return $"Количество продукции: {countProduct}\n" +
               $"Цена: {Price}$";
    }
}

public class Unit : Product
{
    private int months;  
    private string size;
    public int Months
    {
        get
        { return months; }
        set
        { months = value; }
    }
    public string Size
    {
        get
        { return size; }
        set
        { size = value; }
    }



    public Unit(float price, int months, string size) : base(price)
    {
        Months = months;
        Size = size;
    }

    public Unit(Unit unit) : base(unit)
    {
        Months = unit.months;
        Size = unit.size;
    }


    public override string ToString()
    {
        return base.ToString() +
            $"\nРазмер: {Size} \n" +
            $"Срок годности: {Months} месяцев\n";
    }
}


public class Toy : Unit
{
    private string colour;
    private string material;
    private bool disassembled;
    private string countrymake;

    protected string Colour
    {
        get
        { return colour; }
        set
        { colour = value; }
    }

    protected string Material
    {
        get
        { return material; }
        set
        { material = value; }
    }

    public string Countrymake
    {
        get
        { return countrymake; }
        set
        { countrymake = value; }
    }

    public bool Disassembled
    {
        get
        { return disassembled; }
        set
        { disassembled = value; }
    }


    public Toy(float price, int months, string size,string countrymake, bool disassembled, string colour, string material) : base(price, months, size)
    {
        Countrymake = countrymake;
        Disassembled = disassembled;
        Colour = colour;
        Material = material;
    }

    public Toy(Toy toy) : base(toy)
    {
        Countrymake = toy.countrymake;
        Disassembled = toy.disassembled;
        Colour = toy.colour;
        Material = toy.material;
    }


    public override string ToString()
    {
        return base.ToString() +
            $"Страна производитель: {Countrymake}\n" +
            $"Цвет: {Colour}\n" +
            $"Материал: {Material}\n" +
            $"Разбираемая: {Disassembled} \n";
    }
}


public class Milk : Unit
{
    private int fat;
    private string countrymake;


    public string Countrymake
    {
        get
        { return countrymake; }
        set
        { countrymake = value; }
    }

    public int Fat
    {
        get
        { return fat; }
        set
        { fat = value; }
    }


    public Milk(float price, int months, string countrymake, string size, int fat) : base(price, months, size)
    {
        Countrymake = countrymake;
        Fat = fat;
    }

    public Milk(Milk milk) : base(milk)
    {
        Countrymake = milk.countrymake;
        Fat = milk.fat;
    }


    public override string ToString()
    {
        return base.ToString() +
            $"Страна производитель: {Countrymake}\n" +
            $"Жирность: {Fat} \n";
    }
}


class Program
    {
        static void Main(string[] args)
        {
        var toy1 = new Toy(100, 36, "Средняя", "Беларусь", true, "Черная", "Пластик");
        var milk1 = new Milk(10, 12, "Россия", "1 литр", 5);
        Console.WriteLine(toy1);
        Console.WriteLine(milk1);
        }
    }

