using System.Numerics;

namespace playground.Mathematics;

public class IsReachableClass
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-point-is-reachable
    /// </summary>
    public static bool IsReachable(int x, int y)
    {
        var gcd = BigInteger.GreatestCommonDivisor(x, y);
        while (gcd % 2 == 0)
            gcd /= 2;
        return gcd == 1;
    }
}

/*
https://leetcode.com/problems/check-if-point-is-reachable/solutions/3082073/java-c-python-1-line-gcd-solution
- Intuition
Try go from (x, y) to (1,1)
Consider the reverse operation of
(x, y - x)
(x - y, y)
(2 * x, y)
(x, 2 * y)

that is
(x, y + x)
(x + y, y)
(x / 2, y) if x % 2 == 0
(x, y / 2) if y % 2 == 0


- Necessary Condition
Assume x and y have a common divisor v bigger than 2,
Since
(x + y) % v == 0
(x / 2) % v == 0 if x is even
(y / 2) % v == 0 if y is even
The new value always can be divided by v

No matter what operation we use,
we can't reach (1,1)

To go from (x,y) to (1,1),
we have the necessary condition :
gcd(x,y) = 2 ^ k

- Sufficient Condition
Assume gcd(x,y) = 2 ^ k
If x is even, we can go (x / 2, y)
If y is even, we can go (x, y / 2)
If both odd and x < y, we can go (x, (x+y)/2)
If both odd and x > y, we can go ((x+y)/2, y)
(x, y) can continue go smaller,
until (x, y) both odd and x == y,
that is x == y == 1

- Conclusion
Based on the Necessary Condition and Sufficient Condition,
we conclude that
"(1, 1) can go forward to (x, y)"
equals to
"(x, y) can go back to (1, 1)"
equals
gcd(x,y) is pow of 2.
*/
