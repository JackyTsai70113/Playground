using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0129_SumNumbersTest
{
    [Theory]
    [InlineData("[1,2,3]", 25)]
    [InlineData("[4,9,0,5,1]", 1026)]
    public void SumNumbers(string root, int expected)
    {
        var actual = _0129_SumNumbers.SumNumbers(root.ToTreeNode());
        Assert.Equal(expected, actual);
    }
}
