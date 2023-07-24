bool Dayoftheweek(int number)
{
    return number > 5;
}

Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
bool result = Dayoftheweek(a);
Console.WriteLine(result ? "Это выходной день" : "Это не выходной день");

