// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void ShowExponentiationNumber(int number1, int number2) 
{
    int res = number1;
    for(int current = 1; current < number2 ; current++)
        res = res * number1;    
    Console.WriteLine(res);
}

Console.WriteLine("Input A number ");
int NewNumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B number ");
int NewNumB = Convert.ToInt32(Console.ReadLine());

ShowExponentiationNumber(NewNumA, NewNumB);