/*void FindMiddleNumber(int a)
{
    int b = a / 10;
    int c = b % 10;
    Console.Write("Second number is: " + c);
}

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
FindMiddleNumber(number);*/

int FindMiddleNumber(int a)
{
    int b = a / 10;
    int c = b % 10;
    return c;
}

int result;
Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = FindMiddleNumber(number);
Console.WriteLine("Second number is: " + result);