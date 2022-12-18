using System.ComponentModel;
using AreaFigure.Lib;

Figure? figure;

Console.WriteLine("Выберите тип фигуры");
Console.WriteLine("1. Триугольник");
Console.WriteLine("2. Круг");
var select = Console.ReadLine();
switch (select)
{
    case "1":
        Console.Write("Введите размер стороны A: ");
        var sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите размер стороны B: ");
        var sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите размер стороны C: ");
        var sideC = Convert.ToDouble(Console.ReadLine());

        figure = new Triangle(sideA, sideB, sideC);
        break;
    case "2":
        Console.Write("Введите радиус круга: ");
        var radius = Convert.ToDouble(Console.ReadLine());
        figure = new Circle(radius);
        break;
    default:
        figure = null;
        break;
}

if (figure is not null)
{
    if (figure is IArea a)
    {
        Console.WriteLine($"Area = {a.Area()}");
    }

    if (figure is IСheckSquare c)
    {
        if (c.СheckSquare())
        {
            Console.WriteLine("Треугольник прямоугольный");
        }
        else
        {
            Console.WriteLine("Треугольник не прямоугольный");
        }
    }
    
}

