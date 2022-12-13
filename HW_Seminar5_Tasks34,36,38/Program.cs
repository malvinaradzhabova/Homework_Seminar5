// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2
/* 
class Program 
{
public static void Main(string[]args)
{
    int[]GetArrayOfNumbers(int size, int start,int end)
    {
        int[]RandomArray=new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i]= new Random().Next(start,end+1);
        }
        return RandomArray;
    }

void PrintArray(int[] array1)
{
    for (int i=0; i < array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(array1[i]));
    }
}

int CountOfEven(int[] array2)
{
    int count = 0;
    for (int i = 0; i< array2.Length; i++)
    if (array2[i] % 2==0)
    {
       count++;
    }
    return count;
}


    int[] array2 =new int[4];
    array2 = GetArrayOfNumbers(4,100,999);
    PrintArray(array2);
    Console.WriteLine($"Количество четных чисел в массиве = {CountOfEven(array2)}");
   }
} */





/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* 
class Program 
{
public static void Main(string[]args)
{
    int[]GetArrayOfNumbers(int size, int start,int end)
    {
        int[]RandomArray=new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i]= new Random().Next(start,end+1);
        }
        return RandomArray;
    }

void PrintArray(int[] array1)
{
    for (int i=0; i < array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(array1[i]));
    }
}

int GetSumOfElems(int[] array2)
{
    int sum = 0;
    for (int i = 0; i< array2.Length; i++)
    if (i % 2 == 1)
    {
       sum= sum + array2[i];
    }
    return sum;
}


    int[] array2 =new int[4];
    array2 = GetArrayOfNumbers(4,100,999);
    PrintArray(array2);
    Console.WriteLine($"Сумма нечетных чисел в массиве = {GetSumOfElems(array2)}");
   }
} */


/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


class Program 
{
public static void Main(string[]args)
{
    double[]GetArrayOfNumbers(int size, int start,int end)
    {
        double[]RandomArray=new double[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i]= new Random().Next(start,end+1);
        }
        return RandomArray;
    }

void PrintArray(double[] array1)
{
    for (int i=0; i < array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(array1[i]));
    }
}

double GetDifference(double[] array2)
{
    
    double Max= array2[0];
    double Min= array2[0];   
   
   foreach (var item in array2)
   {
    if (Min > item) Min=item;
    if (Max < item) Max=item;
   
   }
   return Max-Min;
   
}

Console.Write("Введите размер массива: ");
int size =Convert.ToInt32(Console.ReadLine());
double[] array2 =new double[size];

array2 = GetArrayOfNumbers(5,0,999);
PrintArray(array2);
       
Console.WriteLine($"Разница между максимальным и минимальным элементами массива= {GetDifference(array2)}");
   }
} 







