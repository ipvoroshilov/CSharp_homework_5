// # Урок 5. Функции продолжение
// ## Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int N = 0)
{
    Console.Write("Введите размер массива: ");   
    N = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[N];
    for (int i = 0; i < N; ++i) 
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int function(int count = 0)
{
    int[] mas=FillArray();
    foreach (int item in mas)
        {
            if (item%2 == 0) 
            {
                count++;
            }
        }
    return count;
}
Console.WriteLine($"{function()} - ответ");