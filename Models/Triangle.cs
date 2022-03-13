namespace WebMVCR11.Models
{
    public class Triangle
    {
        private int v1;
        private int v2;
        private int v3;

        public Triangle(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }

        public string Name
        {
            get
            {
                return String.Format("\"Треугольник со сторонами { 0}, { 1} и { 2}\"", Sta, Stb, Stc);
            }
        }
        public double Perimeter
        {
            get
            {
                double p = Sta + Stb + Stc;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 -
                Sta) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
                return sq;
            }
        }
    }
}
