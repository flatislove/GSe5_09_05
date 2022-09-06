//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadNumber(string s)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите число " + s);
        if (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else if (s == "элементов массива" && number < 0)
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber((i + 1).ToString());
    }
    return array;
}

int CountAboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine($"Количество чисел больше 0 = " + CountAboveZero(GetArray(ReadNumber("элементов массива"))));