using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MiceAndCheeseTest
{
    [Theory]
    [InlineData("[1, 1, 3, 4]", "[4, 4, 1, 1]", 2, 15)]
    [InlineData("[1, 1]", "[1, 1]", 2, 2)]
    [InlineData("[2, 1]", "[1, 2]", 1, 4)]
    public void MiceAndCheese(string reward1, string reward2, int k, int expected)
    {
        int actual = MiceAndCheeseClass.MiceAndCheese(reward1.ToArr(), reward2.ToArr(), k);

        Assert.Equal(expected, actual);
    }
}