using playground.BinarySearch;
using playground.UnitTest.Utils;

namespace playground.UnitTest.BinarySearch;

public class LongestObstacleCourseAtEachPositionTest
{
    [Theory]
    [InlineData("[1,2,3,2]", "[1,2,3,3]")]
    [InlineData("[2,2,1]", "[1,2,1]")]
    [InlineData("[3,1,5,6,4,2]", "[1,1,2,3,2,2]")]
    [InlineData("[3,1,2]", "[1,1,2]")]
    [InlineData("[3,1,3]", "[1,1,2]")]
    [InlineData("[3,1,4]", "[1,1,2]")]
    [InlineData("[4,5,3,1,2,4]", "[1,2,1,1,2,3]")]
    [InlineData("[5,2,1,3,3,5,2,1,1,2]", "[1,1,1,2,3,4,2,2,3,4]")]
    public void LongestObstacleCourseAtEachPosition(string str, string expected)
    {
        var actual = LongestObstacleCourseAtEachPositionClass.LongestObstacleCourseAtEachPosition(str.ToArr<int>());
        Assert.Equal(expected.ToArr<int>(), actual);
    }

    [Theory]
    [InlineData("[1,2,3,2]", "[1,2,3,3]")]
    [InlineData("[2,2,1]", "[1,2,1]")]
    [InlineData("[3,1,5,6,4,2]", "[1,1,2,3,2,2]")]
    [InlineData("[3,1,2]", "[1,1,2]")]
    [InlineData("[3,1,3]", "[1,1,2]")]
    [InlineData("[3,1,4]", "[1,1,2]")]
    [InlineData("[4,5,3,1,2,4]", "[1,2,1,1,2,3]")]
    [InlineData("[5,2,1,3,3,5,2,1,1,2]", "[1,1,1,2,3,4,2,2,3,4]")]
    [InlineData("[5,1,5,5,1,3,4,5,1,4]", "[1,1,2,3,2,3,4,5,3,5]")]
    [InlineData("[5,3,4,4,4,2,1,1,4,1]", "[1,1,2,3,4,1,1,2,5,3]")]
    public void LongestObstacleCourseAtEachPosition2(string str, string expected)
    {
        var actual = LongestObstacleCourseAtEachPositionClass.LongestObstacleCourseAtEachPosition2(str.ToArr<int>());
        Assert.Equal(expected.ToArr<int>(), actual);
    }
}
