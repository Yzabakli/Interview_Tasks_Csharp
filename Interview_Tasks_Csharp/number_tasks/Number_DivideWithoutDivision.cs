namespace ConsoleApp1;

public class Number_DivideWithoutDivision
{
    private static Dictionary<string, int> Divide(int dividend, int divisor)
    {
        var quotient = 0;

        while (dividend >= divisor)
        {
            dividend -= divisor;
            quotient++;
        }

        var map = new Dictionary<string, int>
        {
            { "Quotient", quotient },
            { "Remainder", dividend }
        };

        return map;
    }
/*
    private static void Main()
    {
        foreach (var (key, value) in Divide(20, 5))
        {
            Console.WriteLine(key + ": " + value);
        }
    }*/
}