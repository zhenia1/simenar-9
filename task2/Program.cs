//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

SumFronMToN(m, n);

//вызов функция чисел от M до N
void SumFronMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

//Фунция суммф чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}