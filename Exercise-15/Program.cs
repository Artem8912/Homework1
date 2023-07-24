void Dayoftheweek(int number)
{
    if(number == 6 || number == 7)
    {
           Console.WriteLine("Этот день - выходной"); 
    }
    else
    {
           Console.WriteLine("Этот день - не выходной");  
    }
}

Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
Dayoftheweek(a);


