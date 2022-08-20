namespace Interview_Tasks_Csharp.number_tasks;

public class MaximumPossibleValue
{
    static int MaximumPossible(int number)
    {
        string numberToString = "";

        if (number > 0)
        {
            numberToString = number.ToString();

            for (int i = 0; i < numberToString.Length; i++)
            {
                if (int.Parse(numberToString.Substring(i,1)) < 5)
                {
                    return int.Parse(numberToString.Substring(0, i) + "5" + numberToString.Substring(i));
                }
            }
            return int.Parse(numberToString + "5");
        }else if (number < 0)
        {
            numberToString = (-number).ToString();
            
            for (int i = 0; i < numberToString.Length; i++)
            {
                if (int.Parse(numberToString.Substring(i,1)) > 5)
                {
                    return -int.Parse(numberToString.Substring(0, i) + "5" + numberToString.Substring(i));
                }
            }
            return -int.Parse(numberToString + "5");
        }

        return 50;
    }
/*
    static int Main()
    {
        Console.WriteLine(MaximumPossible(123));
        Console.WriteLine(MaximumPossible(-123));
        Console.WriteLine(MaximumPossible(0));
        return 1;
    }*/
}