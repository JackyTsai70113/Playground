namespace playground.Mathematics;

public class IsPrimeClass
{
    private readonly int Max;
    public IsPrimeClass(int max)
    {
        Max = max;
    }

    public bool IsPrime(int number)
    {
        var primeSet = new SortedSet<int>();
        for (int i = 2; i * i <= Max; ++i)
        {
            var isPrime = true;
            foreach (var p in primeSet)
            {
                if (i % p == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                primeSet.Add(i);
            }
        }
        if (number <= (int)Math.Sqrt(Max))
        {
            return primeSet.Contains(number);
        }
        foreach (var prime in primeSet)
        {
            if (prime * prime > number)
            {
                break;
            }
            if (number % prime == 0)
            {
                return false;
            }
        }
        return true;
    }
}