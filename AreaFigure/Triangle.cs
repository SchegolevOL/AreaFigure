namespace AreaFigure.Lib
{
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            var arrSide = new[] { sideA, sideB, sideC };
            Array.Sort(arrSide);
            if (arrSide[0] <= arrSide[1] + arrSide[2] && arrSide[0]>0 && arrSide[1]>0 && arrSide[2]>0)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
            {
                _sideA = 0;
                _sideB = 0;
                _sideC = 0;
            }

        }

        public double Area()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool CompareRightTriangle()
        {
            
            if (Math.Abs(Math.Pow(_sideC, 2) - (Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2))) < 0.001)
            {
                return true;
            }
            return false;
        }
    }
}
