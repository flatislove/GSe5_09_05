//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int ReadNumber(string s)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите переменную " + s);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

void FindPointIntersection(int k1, int b1, int k2, int b2)
{
    double x = 0;
    double y = 0;
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Бесконечное количество точек пересечения");
    }
    else if (b1 == b2)
    {
        x = 0;
        y = b2;
        Console.WriteLine($"x={x} y={y}");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (b1 - b2) / (k2 - k1);
        y = k2 * x + b2;
        Console.WriteLine($"x={x} y={y}");
    }
}

Console.Clear();
FindPointIntersection(ReadNumber("k1"), ReadNumber("b1"), ReadNumber("k2"), ReadNumber("b2"));