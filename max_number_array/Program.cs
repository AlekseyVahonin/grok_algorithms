// Максимальный элемент в массиве, рекурсивно.

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

int MaxNumberArray(int[] arr, int sizeArr)
{
    sizeArr -= 1;

    if (sizeArr == 0)
    {
        return arr[sizeArr];
    }
    else
    {
        if (arr[sizeArr] < MaxNumberArray(arr, sizeArr)) return arr[sizeArr] = arr[sizeArr - 1];
        else return arr[sizeArr];
    }
}

int[] array = CreateArrayRndInt(5, 1, 10);

PrintArray(array);
Console.WriteLine();

int result = MaxNumberArray(array, array.Length);
Console.WriteLine($"Максимальный элемент в массиве = {result}");
