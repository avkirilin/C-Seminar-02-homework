Console.WriteLine("Введите любое трехзначное число");
int A = Convert.ToInt32(Console.ReadLine());
if (A > 99 && A < 1000)
{
    int B = (A / 10) % 10;
    Console.WriteLine(B);
}
else
{
    Console.WriteLine($"Введенное число {A} не является трехзначным");
}