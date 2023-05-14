using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class MiceAndCheeseTest
{
    [Theory]
    [InlineData("[1, 1, 3, 4]", "[4, 4, 1, 1]", 2, 15)]
    [InlineData("[1, 1]", "[1, 1]", 2, 2)]
    [InlineData("[2, 1]", "[1, 2]", 1, 4)]
    public void MiceAndCheese(string a, string b, int k, int expected)
    {
        var reward1 = a.ToArr<int>();
        var reward2 = b.ToArr<int>();
        int actual = MiceAndCheeseClass.MiceAndCheese(reward1, reward2, k);

        Assert.Equal(expected, actual);
    }
}