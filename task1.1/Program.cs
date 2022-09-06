//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string ReadNumberString()
{
    string numberStr = string.Empty;
    int numberInt = 0;
    while (true)
    {
        Console.WriteLine("Введите число(Выход - нажмите N");
        numberStr = Console.ReadLine();
        if (!(int.TryParse(numberStr, out numberInt)) && (numberStr.ToUpper() != "N"))
        {
            Console.WriteLine("Некорректный ввод");
        }
        else return numberStr;
    }
    return numberStr;
}
bool NumberAboveZero(string number)
{
    int intNumber = Convert.ToInt32(number);
    if (intNumber > 0)
    {
        return true;
    }
    else return false;
}
void PrintActions(int count)
{
    bool flag = true;
    string input = string.Empty;

    while (flag != false)
    {
        input = ReadNumberString();

        if (input.ToUpper() != "N")
        {
            if (NumberAboveZero(input))
            {
                count++;
                Console.WriteLine($"Количество чисел>0 = {count}");
            }
            else
            {
                Console.WriteLine($"Количество чисел>0 = {count}");
            }
        }
        else
        {
            flag = false;
            Console.WriteLine($"Количество чисел>0 = {count}");
        }
    }
}

Console.Clear();
int count = 0;
PrintActions(count);