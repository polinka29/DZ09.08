// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int digit = (Number/10)%10;
Console.WriteLine(digit);


