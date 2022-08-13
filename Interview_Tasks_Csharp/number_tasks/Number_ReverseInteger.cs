namespace ConsoleApp1;

public class Number_ReverseInteger
{
    static int ReverseInteger(int num)
    {
        var temp = 0;

        while (num != 0)
        {
            temp = temp * 10 + num % 10;
            num /= 10;
        }

        return temp;
    }
/*
    private static void Main()
    {
        Console.WriteLine(ReverseInteger(5624647));
    }*/
}