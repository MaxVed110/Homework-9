/*
Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbersMtoN(int numberM, int numberN)
{
    int sum = numberM;
    if (numberM < numberN)
    {
        sum += SumNumbersMtoN(numberM + 1, numberN);
    }
    return sum;
}

Console.WriteLine("Введите число М и число N: ");
int numberUserM = Convert.ToInt32(Console.ReadLine());
int numberUserN = Convert.ToInt32(Console.ReadLine());

int sumUser = SumNumbersMtoN(numberUserM,numberUserN);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {numberUserM} до {numberUserN} равна: {sumUser}");
