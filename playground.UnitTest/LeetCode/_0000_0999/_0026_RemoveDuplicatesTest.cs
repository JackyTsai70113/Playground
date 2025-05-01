using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0026_RemoveDuplicatesTest
{
    [Theory]
    [InlineData("[1,1,2]", "[1,2]")]
    [InlineData("[0,0,1,1,1,2,2,3,3,4]", "[0,1,2,3,4]")]
    public void RemoveDuplicates(string nums, string expected)
    {
        var actual = nums.ToArr();
        _0026_RemoveDuplicates.RemoveDuplicates(actual);
        var expectedArr = expected.ToArr();
        Assert.Equal(expectedArr, actual.Take(expectedArr.Length));
    }
}
