/* 
2) Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
   Console.WriteLine($"Большее число: {number1}, а меньшее число {number2}"); 
}
else
{
    Console.WriteLine($"Большее число: {number2}, а меньшее число {number1}"); 
}
4) Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write("max = ");
Console.Write(max);
6) Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if ((number1 % 2) == 0)
    Console.WriteLine($"Число: {number1} является четным");
else
{
    Console.WriteLine($"Число: {number1} является не четным");
}

8) Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до (N).
*/

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number1; i++)
    if (i % 2 == 0)
Console.Write(i);

