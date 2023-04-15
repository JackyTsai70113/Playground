using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MiceAndCheeseTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 3, 4 }, new int[] { 4, 4, 1, 1 }, 2, 15)]
    [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 }, 2, 2)]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 }, 1, 4)]
    public void MiceAndCheese(int[] reward1, int[] reward2, int k, int expect)
    {
        int result = MiceAndCheeseClass.MiceAndCheese(reward1, reward2, k);

        Assert.Equal(expect, result);
    }
}