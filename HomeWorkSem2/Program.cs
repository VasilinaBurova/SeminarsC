 // First task
 // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
 {
    int result;
    if(num <= 999 && num >= 100)
    {
        int sot = num / 100;
        int ed = num % 10;
        result = sot * 10 + ed;
        return result;
    }
    else
    {
        return -1;
    }
    return result;
 }
 Console.Write("Input three-digit num: ");
 int num = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(CutNumber(num));
*/


//Second task

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int CutNumber(int num)
{
    while(num > 999)
    {
        num = num / 10;
    }
        if(num >= 100)
        {
            num = num % 10;
        }
        else
        {
            return -1;
        }
    return num;
}

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CutNumber(num));
*/

// Three task

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string Week(int num)
{
    if(num < 8 && num >= 1)
    {
        if(num <= 5)
        {
            return "false";
        }
        else
        {
            return "true";
        }
    }
    return "Input correct number!";
}

Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week(num1));
*/