/*
Задача 64: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до M.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 7"
*/


void NumberNtoMPrint(int numberM, int numberN)
{
    if (numberN > numberM)
    {
        Console.Write($"{numberN}, ");
        NumberNtoMPrint(numberM, numberN - 1);
    }
    if (numberN == numberM)
    {
        Console.Write($"{numberN}.");
    }
}


Console.WriteLine("Введите число М и число N: ");
int numberUserM = Convert.ToInt32(Console.ReadLine());
int numberUserN = Convert.ToInt32(Console.ReadLine());

Console.Write("Обратная последовательность: ");
NumberNtoMPrint(numberUserM, numberUserN);