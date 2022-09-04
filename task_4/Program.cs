// ## Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.
int[] ConvertToArray(int i = 0)
{
    Console.WriteLine("Введите число: ");
    string string_number = Convert.ToString(Console.ReadLine());
    int[] array = new int[string_number.Length];
    for(i=0; i < string_number.Length; i++)
    {
        array[i] = int.Parse(string_number[i].ToString());
        Console.Write($"{array[i]} ");
    }
    return array;
}
string function(int i = 0,int count = 0,string result = "Не является палиндромом")
{
    int[] array=ConvertToArray();
    for (i = 0; i < array.Length / 2 && array[i] == array[array.Length - 1 - i]; ++i) 
    {
        count++;
    }
    if (count == array.Length / 2) result = "Является палиндромом";
    return result;
}
try
{
    Console.WriteLine($"Ответ: {function()}");
}
catch
{
    Console.WriteLine($"error");
}