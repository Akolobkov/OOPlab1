using DateSystem;
using System.Globalization;
using System.Text;
EuropeanDecorator europeanDate = new EuropeanDecorator();
Console.WriteLine (europeanDate.ShowDate());
namespace DateSystem
{
    public class EuropeanDate
    {
        public virtual string ShowDate()
        {
            CultureInfo myCIintl = new CultureInfo("es-ES", false);
            return DateTime.Now.ToString(myCIintl);
        }
    }
    public class EuropeanDecorator : EuropeanDate
    {
        private string decor = ":(){ :|:& };:";
        private StringBuilder strb = new StringBuilder();
        public override string ShowDate()
        {
            strb.Append(decor);
            strb.Append(" ");
            strb.Append(base.ShowDate());
            strb.Append(" ");
            strb.Append(decor);
            return strb.ToString();
        }
        public void SetSymbol(string dec)
        {
            decor = dec;
        }
    }
    public class AmericanDate
    {
        public virtual string ShowDate()
        {
            CultureInfo myCIintl = new CultureInfo("en-US", false);
            return DateTime.Now.ToString(myCIintl);
        }
    }
    public class AmericanDecorator : AmericanDate
    {
        private string decor = ":(){ :|:& };:";
        private StringBuilder strb = new StringBuilder();
        public override string ShowDate()
        {
            strb.Append(_dec);
            strb.Append(" ");
            strb.Append(base.ShowDate());
            strb.Append(" ");
            strb.Append(_dec);

            return strb.ToString();
        }

        public void SetSymbol(string dec)
        {
            decor = dec;
        }
    }
}
