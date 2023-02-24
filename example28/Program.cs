//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
        f *= i;
    // Console.WriteLine(i);
    return f;
}

int result = factorial(num);
Console.WriteLine($"{num} -> {result}");