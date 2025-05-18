using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3048_EarliestSecondToMarkIndicesTest
{
    [Theory]
    [InlineData("[2,2,0]", "[2,2,2,2,3,2,2,1]", 8)]
    [InlineData("[1,3]", "[1,1,1,2,1,1,1]", 6)]
    [InlineData("[0,1]", "[2,2,2]", -1)]
    [InlineData("[2,4]", "[1,2,1,2,1,1,2,1,1,1,2]", 8)]
    [InlineData("[3,0,5,2,0,2]", "[3,3,1,5,6,2,4,2,4,4,4,1,3,6,5,1,5,5,1,2,5]", 19)]
    public void EarliestSecondToMarkIndices(string A, string B, int expected)
    {
        var actual = _3048_EarliestSecondToMarkIndices.EarliestSecondToMarkIndices(A.ToArr(), B.ToArr());
        Assert.Equal(expected, actual);
    }
}
