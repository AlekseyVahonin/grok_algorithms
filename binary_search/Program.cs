﻿int BinarySearch(int[] list, int item)
{
    int low = 0; // начало массива
    int higth = list.Length - 1; //количество элементов массива -1, так как индекс массива начинается от 0
    while (low <= higth) //пока начало не будет равно концу или меньше массива
    {
        int index = (low + higth) / 2; // делим массив на попалам вычисляя середину
        int guess = list[index]; // берем значение элемента с середины массива
        if (item == guess) // сравниваем искомый элемент с средним элементом массива
        {
            return index; // возвращаем индекс искомого элемента
        }
        if (guess > item) // если средний элемент больше искомого
        {
            higth = index - 1; // ставим конец массива в стредний элемент и смещаем на 1(конец массива как бы затирается)
        }
        else
        {
            low = index + 1; // в противном случае если средний элемент меньше искомого, смещаем начало к среднему элементу
                            // и прибавляем еще 1 смещение(начало массива как бы затирается)
        }
    }
    return -1; //если искомого значения нет выводим -1
}

int[] array = { 1, 3, 4, 5, 6, 7, 8, 9, 11};
int result = BinarySearch(array, 10);
Console.WriteLine(result);
