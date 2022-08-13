namespace ConsoleApp1;

public class Number_SumAllDigitsUntilOneDigit
{
    static void SumAllDigitsUntilOneDigit(int n)
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
        SumAllDigitsUntilOneDigit(797897);
    }*/
}