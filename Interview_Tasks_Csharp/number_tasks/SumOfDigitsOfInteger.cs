
class Number_SumOfDigitsOfInteger
{
    /*
    static void Main(string[] args)
    {
        Console.WriteLine(GetSum(1234));
    }*/
    static int GetSum(int n)
    {

        int sum = 0;

        while (n > 0)
        {
            sum += n % 10;

            n /= 10;
        }

        return sum;
    }
}