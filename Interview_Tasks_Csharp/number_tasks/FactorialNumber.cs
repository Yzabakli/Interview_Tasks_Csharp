namespace Interview_Tasks_Csharp.number_tasks;

public class FactorialNumber
{
    private static long Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }

        return num * Factorial(num - 1);
    }

    private static long Factorial2(int num)
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
        Console.WriteLine(Factorial(10));
        Console.WriteLine(Factorial2(10));
        return 2;
    }*/
}