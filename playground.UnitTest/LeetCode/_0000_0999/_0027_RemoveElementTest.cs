using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0027_RemoveElementTest
{
    [Theory]
    [InlineData("[3,2,2,3]", 3, "[2,2]")]
    [InlineData("[0,1,2,2,3,0,4,2]", 2, "[0,1,3,0,4]")]
    public void RemoveElement(string nums, int val, string expected)
    {
        var actual = nums.ToArr();
        _0027_RemoveElement.RemoveElement(actual, val);
        var expectedArr = expected.ToArr();
        Assert.Equal(expectedArr, actual.Take(expectedArr.Length).ToArray());
    }
}
