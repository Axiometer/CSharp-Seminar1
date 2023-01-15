// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int num1 = GetValue("Первое число: ");
int num2 = GetValue("Второе число: ");
int num3 = GetValue("Третье число: ");

System.Console.WriteLine($"Максимум из {num1}, {num2}, {num3} равнен {Math.Max(num1, Math.Max(num2, num3))}");
