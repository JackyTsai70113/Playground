namespace playground.UnitTest;

public class MaximumStrengthTest3077
{
    [Theory]
    [InlineData("[7,-70,75]", 1, 75)]
    [InlineData("[1,2,3,-1,2]", 3, 22)]
    [InlineData("[-1000000000,-100000000,-10000000,123,234]", 5, -4630000012)]
    [InlineData("[12,-2,-2,-2,-2]", 5, 64)]
    [InlineData("[-1,-2,-3]", 1, -1)]
    [InlineData("[1,2,3,-1,2]", 1, 7)]
    [InlineData("[2,-76,77,-30,5,-96,24]", 3, 497)]
    public void MaximumStrength(string nums, int k, long expected)
    {
        var actual = MaximumStrength3077.MaximumStrength(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}