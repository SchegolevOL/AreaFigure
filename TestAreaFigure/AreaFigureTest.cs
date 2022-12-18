using AreaFigure;
using AreaFigure.Lib;

namespace TestAreaFigure
{
    public class AreaFigureTest
    {
        [Fact]
        public void TestCircleArea_Radius_10()
        {
            double r = 10;
            double expected = 314.159;
            var circle = new Circle(r);
            double actual = circle.Area();
            Assert.Equal(Math.Round(expected*1000), Math.Round(actual*1000));
        }

        [Fact]
        public void TestTriangleArea_SideA_5_SideB_10_SideC_8()
        {
            double a = 5;
            double b = 10;
            double c = 8;
            double expected  = 19.8100;
            var triangl = new Triangle(a, b, c);
            var actual = triangl.Area();
            Assert.Equal(Math.Round(expected*1000), Math.Round(actual*1000));
        }
        [Fact]
        public void TestTriangleArea_SideA_0_SideB_0_SideC_0()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double expected = 0;
            var triangl = new Triangle(a, b, c);
            var actual = triangl.Area();
            Assert.Equal(Math.Round(expected * 1000), Math.Round(actual * 1000));
        }

        [Fact]
        public void TestTriangleCompareRightTriangle_True()
        {
            double a = 7;
            double b = 4;
            double c = 8.06225774829855;
            bool expected = true;
            var triangl = new Triangle(a, b, c);
            var actual = triangl.ÑheckSquare();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTriangleCompareRightTriangle_False()
        {
            double a = 7;
            double b = 4;
            double c = 7;
            bool expected = false;
            var triangl = new Triangle(a, b, c);
            var actual = triangl.ÑheckSquare();
            Assert.Equal(expected, actual);
        }
    }
}