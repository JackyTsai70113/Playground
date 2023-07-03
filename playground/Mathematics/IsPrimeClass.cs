namespace playground.Mathematics;

public class IsPrimeClass
{
    private readonly bool[] isPrime;
    public IsPrimeClass(int n)
    {
        isPrime = Enumerable.Repeat(true, n).ToArray();
        for (int i = 2; i < n; i++)
        {
            if (!isPrime[i])
                continue;
            for (int j = 2 * i; j < n; j += i)
                isPrime[j] = false;
        }
    }

    public bool IsPrime(int number)
    {
        return number < isPrime.Length && isPrime[number];
    }
}