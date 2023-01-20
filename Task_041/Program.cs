// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел:");
string[] numbers = Console.ReadLine().Split(' ');

int count = 0;
foreach (var number in numbers)
{
    int num = int.Parse(number);
    if (num > 0) count++;
}
Console.WriteLine($"Вы ввели {count} чисел больше нуля.");