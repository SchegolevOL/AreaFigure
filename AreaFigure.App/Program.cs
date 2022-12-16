using AreaFigure.Lib;

IFigure? _figure;

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
        _figure = new Triangle(sideA, sideB, sideC);
        break;
    case "2":
        Console.Write("Введите радиус круга: ");
        var radius = Convert.ToDouble(Console.ReadLine());
        _figure = new Circle(radius);
        break;
    default:
        _figure = null;
        break;
}

Print(_figure);


void Print(IFigure? figure)
{
    Console.WriteLine($"Площадь = {figure?.Area()}");
}