namespace ConsoleApp1;

public class Number_FactorialNumber
{
    private static long FactorialNumber(int num)
    {
        if (num == 0)
        {
            return 1;
        }

        return num * FactorialNumber(num - 1);
    }

    private static long FactorialNumber2(int num)
    {
        var factor = 1;

        while (num >= 2)
        {
            factor *= num;
            num--;
        }
        return factor;
    }
/*
    private static int Main()
    {
        Console.WriteLine(FactorialNumber(10));
        Console.WriteLine(FactorialNumber2(10));
        return 2;
    }*/
}