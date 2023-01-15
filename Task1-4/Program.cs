// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int num = GetValue("Введите число: ");

System.Console.WriteLine($"Вывод четных чисел от 0 до {num}:");
int i = 0;
while (i < num)
{
    System.Console.Write(i.ToString() + " ");
    i += 2;
}