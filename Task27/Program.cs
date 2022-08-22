// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void ShowSumEachNumber(int number) 
{  
    int current = 0;
    int res = 0;
    while(number > 0)
    {
        res = number % 10;  
        current = current + res;
        number = number / 10;
    }
    Console.WriteLine(current);
}

Console.WriteLine("Input number ");
int NewNum = Convert.ToInt32(Console.ReadLine());
ShowSumEachNumber(NewNum);