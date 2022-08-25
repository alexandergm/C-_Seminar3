Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = N;
double sqr = Math.Pow(N, 2);

while(sum != 0)
{
    Console.WriteLine("Введите число: ");
    N = Convert.ToInt32(Console.ReadLine());
    sum += N;
    sqr = sqr + Math.Pow(N, 2);
    if(sum == N) break;
}
Console.WriteLine("Сумма квадратов введеных чисел = " + sqr);