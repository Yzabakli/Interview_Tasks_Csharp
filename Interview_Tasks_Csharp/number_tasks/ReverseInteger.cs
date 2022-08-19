namespace Interview_Tasks_Csharp.number_tasks;

public class ReverseInteger
{
    static int Reverse(int num)
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
        Console.WriteLine(Reverse(5624647));
    }*/
}