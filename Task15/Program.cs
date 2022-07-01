void Dayoff(int dayNumder)
{
    if (dayNumder == 6 || dayNumder == 7)
    {
        Console.WriteLine("Today is a day off.");
    }
    else if (dayNumder >= 1 && dayNumder <= 5)
    {
        Console.WriteLine("No, today is weekdays.");
    }
    else
    {
        Console.WriteLine("Incorrect number, try again.");
    }
}

Console.Write("Input day numder: ");
int number = Convert.ToInt32(Console.ReadLine());
Dayoff(number);