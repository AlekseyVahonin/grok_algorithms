// Сумма чисел рандомного массива, рекурсивно.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumArray(int[] arr, int sizeArr)
{
    sizeArr -= 1;
    if (sizeArr < 0) return 0;
    else return arr[sizeArr] + SumArray(arr, sizeArr);
}

int[] array = CreateArrayRndInt(5, 1, 10);

PrintArray(array);
Console.WriteLine();

int result = SumArray(array, array.Length);
Console.WriteLine($"Сумма элементов массива = {result}");
