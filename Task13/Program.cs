void FindThirdDigit(int x)
{
    if (x > 99) 
    {
        int digit = ((x / 100) % 10);
        Console.WriteLine("Третья цифра: " + digit);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет.");
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirdDigit(number);