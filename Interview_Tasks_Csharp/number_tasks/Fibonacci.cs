namespace Interview_Tasks_Csharp.number_tasks;

public class Fibonacci
{
    private static int FibonacciNth(int number)
    {
        var j = 0;
        var z = 1;

        for (var i = 1; i < number; i++)
        {
            z += j;

            j = z - j;
        }

        return z;
    }
    
    private static void Main()
    {
        Console.Write(FibonacciNth(10));
    }
}