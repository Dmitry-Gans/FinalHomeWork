// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.WriteLine("Задайте рамер массива");
int a = int.Parse(Console.ReadLine());
int[] array = ArrayRandom(a);
PrintArray(array);

int[] ArrayRandom(int a)
{
    int[] array = new int[a];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        array[i] = random.Next(1, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}