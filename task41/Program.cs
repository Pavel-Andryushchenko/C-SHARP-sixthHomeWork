// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetPositiveNumber(double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

double[] InpootArray(int size)
{
    double[] mas = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        mas[i] = Convert.ToDouble(Console.ReadLine());
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Сколбко чисел желаете ввести: ");
double[] array = InpootArray(size);
Console.WriteLine($"{string.Join(", ", array)} -> {GetPositiveNumber(array)}");

