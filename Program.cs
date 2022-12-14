// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res= new int [size];
    for(int i=0; i<size; i++)
    {
        res[i]= new Random(). Next(minValue,maxValue+1);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i=0; i< arr.Length; i++)
    {
        Console.Write ($"{arr[i]} ");
    }
}

int [] array= GetArray(6, -20, 20);
PrintArray (array);

void SumNub( int [] array)
{
    int SumNub=0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2!=0)
        {
            SumNub=SumNub+array[i];
        }
    }
    Console.WriteLine (SumNub);
}
Console.WriteLine();
SumNub (array);
