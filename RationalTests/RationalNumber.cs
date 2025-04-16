// See https://aka.ms/new-console-template for more information
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
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
            Assert.Fail();
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
        if (obj1.Numerator == obj2.Numerator & obj1.Denominator == obj2.Denominator)
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
        if (obj1.Numerator == obj2.Numerator & obj1.Denominator == obj2.Denominator)
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