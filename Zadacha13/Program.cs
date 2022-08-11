// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. 645-5; 34-третьей цифры нет; 3456-5

Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int digit = (Number%10);
if (Number/100>0) 
   {
   Console.WriteLine(Number%10);
   }
else
   {
    Console.WriteLine("Третьей цифры нет");
   }