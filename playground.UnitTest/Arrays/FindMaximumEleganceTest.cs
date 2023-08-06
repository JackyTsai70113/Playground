using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class FindMaximumEleganceTest
{
    [Theory]
    [InlineData("[[3,2],[5,1],[10,1]]", 2, 17)]
    [InlineData("[[3,1],[3,1],[2,2],[5,3]]", 3, 19)]
    [InlineData("[[1,1],[2,1],[3,1]]", 3, 7)]
    [InlineData("[[2,2],[8,3],[8,3]]", 2, 17)]
    [InlineData("[[1,2],[10,1]]", 1, 11)]
    public void FindMaximumElegance(string nums, int k, int expected)
    {
        var actual = FindMaximumEleganceClass.FindMaximumElegance(nums.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
