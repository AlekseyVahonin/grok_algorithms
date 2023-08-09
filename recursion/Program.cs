// Вычислить фаториал числа, рекурсивно.

int Fact(int num)
{
    checked
    {
        if (num == 1) return num;
        else return num *= Fact(num - 1);
    }

}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = Fact(number);
Console.WriteLine(result);