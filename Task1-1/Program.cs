// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int num1 = GetValue("Первое число: ");
int num2 = GetValue("Второе число: ");

if (num1 == num2)
    System.Console.WriteLine("Числа равны");

if (num1 > num2)
    System.Console.WriteLine($"Число {num1} больше {num2}");
else
    System.Console.WriteLine($"Число {num2} больше {num1}");
