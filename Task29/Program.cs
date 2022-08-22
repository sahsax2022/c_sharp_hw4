// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CrArray(int size)
{
    int[] NewArray = new int[size];
    return NewArray;
}

int[] EnterArrayElements(int[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.WriteLine($"Input {i + 1} array element: "); 
        thisArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return thisArray;
}

void ShowArrayElements(int[] thisArray) 
{  
    Console.Write("[");
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.Write(thisArray[i]);
        if(i < thisArray.Length - 1 )
            Console.Write(", ");    
    }
    Console.Write("]");    
}

Console.WriteLine("Input array size: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowArrayElements(MyArray);