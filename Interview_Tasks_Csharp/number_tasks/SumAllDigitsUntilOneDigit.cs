namespace Interview_Tasks_Csharp.number_tasks;

public class SumAllDigitsUntilOneDigit
{
    static void SumAllDigitsUntilOne(int n)
    {
        while (n > 9)
        {
            int digit = n, sum = 0;

            while (digit > 0)
            {
                sum += digit % 10;
                digit /= 10;
            }
            Console.WriteLine(sum);

            n = sum;
        }
    }
/*
    static void Main()
    {
        SumAllDigitsUntilOne(797897);
    }*/
}