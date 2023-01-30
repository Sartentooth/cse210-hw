using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(3);
        Fraction fraction2 = new Fraction(13,4);
        Fraction fraction3 = new Fraction(1,6);

        fraction.SetTop(2);
        fraction.SetBotton(6);

        fraction3.SetTop(7);
        fraction3.SetBotton(10);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine($"{fraction.GetDecimalValue()}");
        
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");
        
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");

        Console.WriteLine($"{fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");
        
        
       
    }
}