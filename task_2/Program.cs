// ## Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    for (i = 0; i < mas.Length; ++i) 
    {
        if (i%2!=0) result = result + mas[i];
    }
    return result;
}
Console.WriteLine($"Ответ: {function()}");