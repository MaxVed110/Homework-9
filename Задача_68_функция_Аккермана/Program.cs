/*
Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

int functions = 0;
int FunctionsAkkerman(int numberM, int numberN)
{

    if (numberM == 0)
    {
        functions = numberN + 1;
    }
    else
    {
        if (numberM > 0 && numberN == 0)
        {
            FunctionsAkkerman(numberM - 1, 1);
        }
        if (numberM > 0 && numberN > 0)
        {
            FunctionsAkkerman(numberM - 1, FunctionsAkkerman(numberM, numberN - 1));
        }
    }
    return functions;
}

int newFunctions = FunctionsAkkerman(3, 2);
Console.Write(newFunctions);