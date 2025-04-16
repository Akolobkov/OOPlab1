// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
Rational R1 = new Rational(2, -3);
Rational R2 = new Rational(2, 3);
Console.WriteLine(R1.ToString());
Console.WriteLine((R1 - R2).ToString());
Rational R3 = new Rational(2, 3);
Rational R4 = new Rational(3, 1);
Console.WriteLine((R3 * R4).ToString());
Rational R5 = new Rational(4, 3);
Rational R6 = new Rational(3, 1);
Console.WriteLine((R5 / R6).ToString());
Rational R7 = new Rational(3, 6);
Console.WriteLine((-R7).ToString());
Rational R8 = new Rational(4, 3);
Rational R9 = new Rational(8, 5);
Console.WriteLine(R8<=R9);
class Rational
{
    private int Numerator = new int();
    private int Denominator = new int();
    private Rational Normalize()
    {
        int max = new int();
        int fl = new int();
        fl = 0;
        if (Numerator < 0)
        {
            Numerator = Numerator * -1;
            fl = 1;
        }
        max = 1;
        for (int i = Denominator + 1; i > 1; i--)
        {
            if ((Numerator % i == 0) & (Denominator % i == 0))
            {
                max = i;
                break;
            }
        }
        Numerator = Numerator / max;
        Denominator = Denominator / max;
        if (fl == 1)
        {
            Numerator = Numerator * -1;
        }
        Rational r = new Rational(Numerator, Denominator);
        return r;
    }
    public Rational(int numerator, int denominator)
    {
        if (denominator < 0)
        {
            numerator = numerator * -1;
            denominator = denominator * -1;
        }
        if (denominator == 0)
        {
            Console.WriteLine("Делитель не может быть равен 0");
        }
        else
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }
    public string ToString()
    {
        int max = new int();
        int fl = new int();
        fl = 0;
        if (Numerator < 0)
        {
            Numerator = Numerator * -1;
            fl = 1;
        }
        max = 1;
        for (int i = Denominator + 1; i > 1; i--)
        {
            if ((Numerator % i == 0) & (Denominator % i == 0))
            {
                max = i;
                break;
            }
        }
        Numerator = Numerator / max;
        Denominator = Denominator / max;
        if (fl == 1)
        {
            Numerator = Numerator * -1;
        }
        if (Numerator == 0)
            return $"0";
        else if (Denominator == 1)
            return $"{Numerator}";
        else
            return $"{Numerator}/{Denominator}";
    }
    public static Rational operator +(Rational obj1, Rational obj2)
    {
        obj1.Numerator = obj1.Numerator * obj2.Denominator;
        obj2.Numerator = obj2.Numerator * obj1.Denominator;
        obj1.Denominator = obj1.Denominator * obj2.Denominator;
        obj1.Numerator = obj1.Numerator + obj2.Numerator;
        return obj1;
    }
    public static Rational operator -(Rational obj1, Rational obj2)
    {
        obj1.Numerator = obj1.Numerator * obj2.Denominator;
        obj2.Numerator = obj2.Numerator * obj1.Denominator;
        obj1.Denominator = obj1.Denominator * obj2.Denominator;
        obj1.Numerator = obj1.Numerator - obj2.Numerator;

        return obj1;
    }
    public static Rational operator *(Rational obj1, Rational obj2)
    {
        obj1.Numerator = obj1.Numerator * obj2.Numerator;
        obj1.Denominator = obj1.Denominator * obj2.Denominator;
        return obj1;
    }
    public static Rational operator /(Rational obj1, Rational obj2)
    {
        obj1.Numerator = obj1.Numerator * obj2.Denominator;
        obj1.Denominator = obj1.Denominator * obj2.Numerator;
        int max = new int();
        max = 1;
        return obj1;
    }
    public static Rational operator -(Rational obj1)
    {
        obj1.Numerator = -1 * obj1.Numerator;
        return obj1;
    }
    public static bool operator ==(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if (obj1.Numerator == obj2.Denominator & obj1.Denominator == obj2.Denominator)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator !=(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if (obj1.Numerator == obj2.Denominator & obj1.Denominator == obj2.Denominator)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool operator >=(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if ((obj1 - obj2).Numerator >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator <=(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if ((obj1 - obj2).Numerator <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator <(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if ((obj1 - obj2).Numerator < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator >(Rational obj1, Rational obj2)
    {
        obj1 = obj1.Normalize();
        obj2 = obj2.Normalize();
        if ((obj1 - obj2).Numerator > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}