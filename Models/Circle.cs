namespace WebMVCR11.Models
{
    public class Circle
    {
        public double St { get; set; }
        public string Name
        {
            get
            {
                return String.Format("\"Окружность с  радиусом { 0}\"", St);
            }
        }
        public Circle (double a)
        {
            St = a;
        }
        public double Dlina
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }
    }
}
