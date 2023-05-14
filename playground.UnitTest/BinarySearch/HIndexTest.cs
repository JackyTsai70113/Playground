using playground.BinarySearch;
using playground.UnitTest.Utils;

namespace playground.UnitTest.BinarySearch;

public class HIndexTest
{
    [Theory]
    [InlineData("[0,1,3,5,6]", 3)]
    [InlineData("[1,2,100]", 2)]
    [InlineData("[0]", 0)]
    public void HIndex(string str, int expected)
    {
        var actual = HIndexClass.HIndex(str.ToArr<int>());
        Assert.Equal(expected, actual);
    }
}
