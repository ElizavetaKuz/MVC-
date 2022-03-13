using System.Text;

namespace WebMVCR11.Models
{
    public enum AccountType
    {
        Checking,
        Deposit
    }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;

        public override string ToString()
        {
            string res = String.Format("Номер счета {0}, баланс { 1}, тип { 2}", accNo, accBal, accType);
            return res;
        }
    }



    public class StudyCsharp : StudyCsharpBase
    {
        internal static string SetStatus()
        {
            throw new NotImplementedException();
        }

        public static string ExeSwitch(string status)
        {
            string res;
            switch (status)
            {
                case "junior developer":
                    res = "Набирайся знаний"; break;
                case "middle developer":
                    res = "Набирайся опыта"; break;
                case "senior developer":
                    res = "Руководи другими"; break;
                case "sensei":
                    res = "Учи других"; break;
                default:
                    res = "Не знаю, что делать";
                    break;
            }
            return res;
        }
        public static string GetFunction(double x1, double x2)
        {
            StringBuilder str = new StringBuilder();
            double x = x1;
            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##}; < br > ", x, Math.Pow(x,3));
               
                x = x + 0.5;
            }
            while (x <= x2);
            return str.ToString(); ;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            checked
            {
                for (k = 2; k <= n; ++k)
                {
                    f = f * k;
                }
            }
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
    public class Circle_ : Shape, IComparable<Circle>
    {
        public double Area { get; private set; }

        public int CompareTo(Circle other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }

        int IComparable<Models.Circle>.CompareTo(Models.Circle? other)
        {
            throw new NotImplementedException();
        }
    }
}
