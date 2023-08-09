// Быстрая сортировка.

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

int[] FastSortingArray(int[] arr)
{

    if (arr.Length < 2)
    {
        return arr;
    }
    else
    {
        int pivot = arr[0];

        int countLess = 0;
        int countGreater = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (pivot >= arr[i]) countLess++;
            else countGreater++;
        }

        int[] less = new int[countLess];
        int[] greater = new int[countGreater];
        int[] pivotArr = new int[1];
        pivotArr[0] = pivot;

        SubArrayLeft(arr, less, pivot);
        SubArrayRight(arr, greater, pivot);

        int[] result = ConcatArr(FastSortingArray(less), pivotArr, FastSortingArray(greater));

        return result;
    }
}

void SubArrayLeft(int[] arr, int[] arrSub, int pivotSub)
{
    int index = 1;
    for (int i = 0; i < arrSub.Length; i++)
    {
        for (int j = index; j < arr.Length; j++)
        {
            if (pivotSub >= arr[j])
            {
                arrSub[i] = arr[j];
                index = j + 1;
                break;
            }
        }
    }
}
void SubArrayRight(int[] arr, int[] arrSub, int pivotSub)
{
    int index = 1;
    for (int i = 0; i < arrSub.Length; i++)
    {
        for (int j = index; j < arr.Length; j++)
        {
            if (pivotSub < arr[j])
            {
                arrSub[i] = arr[j];
                index = j + 1;
                break;
            }
        }
    }
}

T[] ConcatArr<T>(params T[][] arrays)
{
    var result = new T[arrays.Sum(a => a.Length)];
    int offset = 0;
    foreach (T[] array in arrays)
    {
        array.CopyTo(result, offset);
        offset += array.Length;
    }
    return result;
}

int[] array = CreateArrayRndInt(5, 1, 20);

PrintArray(array);
Console.WriteLine();

int[] result = FastSortingArray(array);

PrintArray(result);
Console.WriteLine();