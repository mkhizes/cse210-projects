using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1=new Fraction();
        Console.WriteLine(f1.GetFractionstring());
        Console.WriteLine(f1.GetFractionstring());

        Fraction f2=new Fraction(5);
        Console.WriteLine(f2.GetFractionstring());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3=new Fraction(3,4);
        Console.WriteLine(f3.GetFractionstring());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4=new Fraction(1,3);
        Console.WriteLine(f4.GetFractionstring());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5=new Fraction(2,5);
        Console.WriteLine(f5.GetFractionstring());
        Console.WriteLine(f5.GetDecimalValue());
    }
    
    
}