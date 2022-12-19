Console.WriteLine("Введите любое целое число");
int A = Convert.ToInt32(Console.ReadLine());
string B = A.ToString();
if (A > 99)
{
    Console.Write($"Третья цифра из числа {A} слева направо: ");
    Console.WriteLine(B[2]);
}
else
{
    Console.WriteLine ("Нет третьей цифры в данном числе");
}
