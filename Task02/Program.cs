// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
int[] RandomArray(int size, int firstNumber, int lastNumber)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(firstNumber, lastNumber);
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
        Console.WriteLine(array[array.Length - 1] + "]");
}
 int SumUnevenPosition(int[] array1)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array1[i];
        }
    }
    return sum;
}    
    Console.Write("Введите размер массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int[] array2 = RandomArray(N, 10, 100);
    PrintArray(array2);
    int result = SumUnevenPosition(array2);
    Console.WriteLine($"сумму элементов, стоящих на нечётных позициях: " + result);
