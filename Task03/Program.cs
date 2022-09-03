//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(array[array.Length -1] + "]");
}
int Dif(int[]arr)
{
int max = 0; 
int min = 100;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}    
return max-min;       
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomArray(N, 0, 100);
PrintArray(arr);
int res = Dif(arr);
Console.WriteLine("Разница максимального и минимального:  "+ res);

 
