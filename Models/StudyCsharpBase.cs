namespace WebMVCR11.Models
{
    public class StudyCsharpBase
    {

        public static string SetStatus(int age)
        {
            string status = "junior developer";
            if ((age > 2) && (age < 7)) status = "middle developer";
            else if ((age >= 7) && (age < 15)) status = "senior developer";
            else if ((age >= 15)) status = "sensei";
            return status;
            
        }
         internal static string SetStatus1(int v)
    {
        throw new NotImplementedException();
    }
    }
   
}