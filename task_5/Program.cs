// ## Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. N - задается пользователем.
Console.WriteLine("Сколько измерений?");
int N = Convert.ToInt32(Console.ReadLine());
int[] firstArray = new int[N];
int[] secondArray = new int[N];
int i = 0;
double pow = 0;
double sum = 0;
double distance = 0;
for (i=0;i<N;i++)
{
    Console.WriteLine($"Введите  координату первой точки для {i} измерения ");
    firstArray[i] = int.Parse(Console.ReadLine());
}
for (i=0;i<N;i++)
{
    Console.WriteLine($"Введите  координату второй точки для {i} измерения ");
    secondArray[i] = int.Parse(Console.ReadLine());
}
for (i=0;i<N;i++)
{
    pow = Math.Pow(secondArray[i] - firstArray[i],2);
    sum = sum + pow;
}
distance = Math.Round(Math.Sqrt(sum),2);
Console.WriteLine($"Расстояние - {distance}");