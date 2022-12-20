namespace AreaFigure.Lib
{
    public class Triangle : Figure, IArea, IСheckSquare
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            var arrSide = new[] { sideA, sideB, sideC };
            Array.Sort(arrSide);
            if (CheckTriangle(arrSide))
            {
                _sideA = arrSide[0];
                _sideB = arrSide[1];
                _sideC = arrSide[2];
            }
            else
            {
                _sideA = 0;
                _sideB = 0;
                _sideC = 0;
            }

        }

        public static bool CheckTriangle(double[] arrSide)
        {
            
            if (arrSide[0] <= arrSide[1] + arrSide[2] && arrSide[0] > 0 && arrSide[1] > 0 && arrSide[2] > 0)
            {
                return true;
            }
            return false;
        }

        public double Area()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool СheckSquare()
        {
            
            if (Math.Abs(Math.Pow(_sideC, 2) - (Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2))) < 0.001)
            {
                return true;
            }
            return false;
        }
    }
}
