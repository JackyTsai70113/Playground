namespace playground.UnitTest;

public class LongestObstacleCourseAtEachPositionTest_1964
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 2 }, new int[] { 1, 2, 3, 3 })]
    [InlineData(new int[] { 2, 2, 1 }, new int[] { 1, 2, 1 })]
    [InlineData(new int[] { 3, 1, 5, 6, 4, 2 }, new int[] { 1, 1, 2, 3, 2, 2 })]
    [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 3, 1, 3 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 3, 1, 4 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 4, 5, 3, 1, 2, 4 }, new int[] { 1, 2, 1, 1, 2, 3 })]
    [InlineData(new int[] { 5, 2, 1, 3, 3, 5, 2, 1, 1, 2 }, new int[] { 1, 1, 1, 2, 3, 4, 2, 2, 3, 4 })]
    [InlineData(new int[] { 5, 1, 5, 5, 1, 3, 4, 5, 1, 4 }, new int[] { 1, 1, 2, 3, 2, 3, 4, 5, 3, 5 })]
    [InlineData(new int[] { 5, 3, 4, 4, 4, 2, 1, 1, 4, 1 }, new int[] { 1, 1, 2, 3, 4, 1, 1, 2, 5, 3 })]
    public void LongestObstacleCourseAtEachPosition(int[] obstacles, int[] expected)
    {
        var actual = LongestObstacleCourseAtEachPosition1964.LongestObstacleCourseAtEachPosition(obstacles);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 2 }, new int[] { 1, 2, 3, 3 })]
    [InlineData(new int[] { 2, 2, 1 }, new int[] { 1, 2, 1 })]
    [InlineData(new int[] { 3, 1, 5, 6, 4, 2 }, new int[] { 1, 1, 2, 3, 2, 2 })]
    [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 3, 1, 3 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 3, 1, 4 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 4, 5, 3, 1, 2, 4 }, new int[] { 1, 2, 1, 1, 2, 3 })]
    [InlineData(new int[] { 5, 2, 1, 3, 3, 5, 2, 1, 1, 2 }, new int[] { 1, 1, 1, 2, 3, 4, 2, 2, 3, 4 })]
    [InlineData(new int[] { 5, 1, 5, 5, 1, 3, 4, 5, 1, 4 }, new int[] { 1, 1, 2, 3, 2, 3, 4, 5, 3, 5 })]
    [InlineData(new int[] { 5, 3, 4, 4, 4, 2, 1, 1, 4, 1 }, new int[] { 1, 1, 2, 3, 4, 1, 1, 2, 5, 3 })]
    public void LongestObstacleCourseAtEachPosition2(int[] obstacles, int[] expected)
    {
        var actual = LongestObstacleCourseAtEachPosition1964.LongestObstacleCourseAtEachPosition2(obstacles);
        Assert.Equal(expected, actual);
    }
}
