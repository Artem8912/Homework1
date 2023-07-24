Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int Seconddigit(int number)
{
   return (a % 100)/10;
}
int result = Seconddigit(a);
Console.WriteLine($"Вторая цифра числа равна {result}  ");
