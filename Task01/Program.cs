// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
int[] RandomArray(int size, int firstNumber, int lastNumber)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i]= new Random().Next(firstNumber, lastNumber);
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("["); 
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
 Console.WriteLine(array[array.Length -1] + "]");
}
int FindEvenNumber(int[] array1)
 {
    int result = 0;
        for (int i = 0; i < array1.Length; ++i) {
        if (array1[i]%2 == 0) 
        {
            result++;
        }
   }
    return result;
 }
Console.Write("Введите размер массива: ");   
int N = Convert.ToInt32(Console.ReadLine());
int[] array2 = RandomArray(N, 100, 1000);
PrintArray(array2);
int num = FindEvenNumber(array2);
Console.WriteLine($"количество четных чисел в массиве: " + num);

