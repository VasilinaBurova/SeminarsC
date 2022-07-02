/*
int FindMaxPart(int num)
{
    int dec, ed;

    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}
Console.Write("Input two-digit numer: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not a two-digit!");
}
else
{
    Console.WriteLine($"Bigger number of {a} is {result}");
}
*/

// Second task

/*


int CutNum()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Current number is {num}");

    int sot, ed, result;
    sot = num / 100;
    ed = num % 10;
    result = sot * 10 + ed;
    return result;
}
Console.WriteLine(CutNum());

*/


// therd task

/*
int num1, num2, ost;

Console.Write("num1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("num2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num2 % num1 == 0)
{
    Console.WriteLine("True");
}
else
{
    ost = num2 % num1;
    Console.WriteLine($"{ost}");
}
*/

// Fourth task

/*
int num;

Console.Write("num: ");
num = Convert.ToInt32(Console.ReadLine());
if(num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

// ЗАДАЧА Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

