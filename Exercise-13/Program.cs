int Thirddigit(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return (number % 100) % 10;
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result = Thirddigit(a);
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра равна {result} ");
}