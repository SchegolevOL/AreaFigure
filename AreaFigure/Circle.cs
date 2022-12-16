namespace AreaFigure.Lib
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            if (radius>0)
            {
                _radius = radius;
            }
            else
            {
                _radius = 0;
            }
            
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
