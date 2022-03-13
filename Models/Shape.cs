namespace WebMVCR11.Models
{
    public class Shape
    {
        public double St { get; set; }
        virtual public string Name
        {
            get { return String.Format("\"Фигура\""); }
        }

        public class Circle : Shape
        {
            override public string Name
            {
                get
                {
                    return String.Format("\"Окружность с радиусом { 0}\"", St);
                }
            }

            public double Area { get; internal set; }
        }
        public class Triangle : Shape
        {
            private object? Stb;
            private object? Stc;

            override public string Name
            {
                get
                {
                    return String.Format("\"Треугольник со сторонами {0}, {1} и { 2}\"", St, Stb, Stc);
                }
            }
        }
    }
}
