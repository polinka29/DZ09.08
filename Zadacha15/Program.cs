// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: monday=1,tuesday=2,wednesday=3;thursday=4,friday=5,saturday=6,sunday=7: ");
string day = Console.ReadLine();
 
if (day == "6")
    Console.WriteLine("выходной");
else if (day == "7")
    Console.WriteLine("выходной");

else
    Console.WriteLine("будни");