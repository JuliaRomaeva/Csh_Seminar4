// 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// способ без метода(функции)
// Console.Clear();
// Console.Write("Введите число : ");
// string s = Console.ReadLine();
// int l = s.Length;
// Console.Write($" {s} -> {l}");
// 
// способ с использованием функции
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int CountNumbers(int n){
    int count = 0;
   if( n < 0){
    n = n * -1;
   }
   while(n > 0){
    n = n / 10;
    count++;
   }
   return count;
}
int result = CountNumbers(n);
Console.Write($" {n} -> {result}");