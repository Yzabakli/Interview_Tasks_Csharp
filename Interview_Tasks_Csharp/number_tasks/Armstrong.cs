namespace Interview_Tasks_Csharp.number_tasks;

public class Armstrong
{
    private static bool IsArmstrong(int number){

        var power = number.ToString().Length;

        var sum = 0;

        for (var i = 0; i < power; i++)
        {
            sum += (int) Math.Pow(Int32.Parse(number.ToString().Substring(i, 1)), power);
        }

        return sum == number;
    }
/*
    private static int Main()
    {
        Console.Write(IsArmstrong(153));
        return 1;
    }*/
}