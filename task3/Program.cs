//Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.

int ReadNumber()
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите размерность массива");
        if (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("Некорректный ввод");
        }
        else break;
    }
    return number;
}

string ReadAction()
{
    while (true)
    {
        Console.WriteLine("L - сдвиг влево, R - сдвиг вправо");
        string input = Console.ReadLine().ToUpper();
        if (!input.Equals("L") && !input.Equals("R"))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else
        {
            return input;
        }
    }
}

int[] GetArray(int size, int min, int max)
{
    Random random = new Random();
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result.SetValue(random.Next(min, max + 1), i);
    }
    return result;
}


int[] ShiftArray(string action, int[] array)
{

    int[] shiftArray = new int[array.Length];
    int tmp = 0;
    if (action.Equals("L"))
    {
        tmp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            shiftArray[i] = array[i + 1];
        }
        shiftArray[shiftArray.Length - 1] = tmp;
    }
    else if (action.Equals("R"))
    {
        tmp = array[array.Length - 1];
        for (int i = 0; i < array.Length - 1; i++)
        {
            shiftArray[i + 1] = array[i];
        }
        shiftArray[0] = tmp;
    }
    return shiftArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join("  ", array));
}

Console.Clear();

int[] array = GetArray(ReadNumber(), -10, 10);
PrintArray(array);
int[] newArray = ShiftArray(ReadAction(), array);
PrintArray(newArray);