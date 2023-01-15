// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int num = GetValue("Введите число: ");

if (num % 2 == 0)
    System.Console.WriteLine($"Число {num} четное");
else
    System.Console.WriteLine($"Число {num} нечетное");