// ## Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] FillArray(int N = 0, int i = 0)
{
    Console.Write("Введите размер массива: ");   
    N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    for (i = 0; i < N; ++i) 
    {
        array[i] = new Random().Next(-999, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
int function(int i = 0, int result = 0)
{
    int[] mas=FillArray();
    int min = mas[0];
    int max = mas[0];
    for (i = 0; i < mas.Length; ++i) 
    {
        if (mas[i]<min) min = mas[i];
        if (mas[i]>max) max = mas[i];
    }
    result = max - min;
    return result;
}
Console.WriteLine($"Ответ: {function()}");