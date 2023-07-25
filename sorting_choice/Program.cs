//Сортировка выбором О(n^2)
// 1. Ищем индекс минимального элемента массива A.
// 2. Заполняем новый массив B этим элементом.
// 3. Удаляем индекс из массива A.

int SearchMin(int[] arr) // Функция ищет минимальный элимент массива
{
    int min = arr[0];
    int indexArr = 0;
    int sizeArr = arr.Length;

    for (int i = 0; i < sizeArr; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexArr = i;
        }
    }
    return indexArr; // вернуть индекс минимального
}

void SelectionSort(int[] array, int size) // процедура сортировки выбором
{
    int sizeArr = array.Length;
    int[] newArray = new int[size]; // создаем новый массив
    int index = 0;

    for (int i = 0; i < sizeArr; i++)
    {
        index = SearchMin(array); // ищем индекс минимального значения массива
        newArray[i] = array[index]; // кладем минимальное значение в новый массив
        Console.Write($"{newArray[i]} | "); // выводим значение
        array = array.Where((val, idx) => idx != index).ToArray(); // удаляем индекс минимального элемента из массива
    }
}

int[] arrNotSort = { 2, 6, 1, 0, 9, 8, 8, 10, -1, 56, 3, -9 };
SelectionSort(arrNotSort, arrNotSort.Length);