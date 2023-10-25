using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class IsSelfCrossingTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 2, 1, 1, 2 }, true)]
    [InlineData(new int[] { 1, 1, 1, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 3, 1, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 3, 1, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 3, 2, 1 }, false)]
    [InlineData(new int[] { 1, 1, 3, 2, 1, 1 }, false)]
    [InlineData(new int[] { 1, 2, 2, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 4, 2, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 3, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 10, 4, 4, 3, 3, 2, 2, 1, 1 }, false)]
    public void IsSelfCrossing(int[] distance, bool expected)
    {
        var actual = IsSelfCrossingClass.IsSelfCrossing(distance);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 4 }, false)]
    [InlineData(new int[] { 2, 1, 1, 2 }, true)]
    [InlineData(new int[] { 1, 1, 1, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 3, 1, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 3, 1, 1 }, false)]
    [InlineData(new int[] { 1, 1, 2, 3, 2, 1 }, false)]
    [InlineData(new int[] { 1, 1, 3, 2, 1, 1 }, false)]
    [InlineData(new int[] { 1, 2, 2, 2, 1, 1 }, true)]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 10, 4, 4, 3, 3, 2, 2, 1, 1 }, false)]
    public void IsSelfCrossing2(int[] distance, bool expected)
    {
        var actual = IsSelfCrossingClass.IsSelfCrossing2(distance);
        Assert.Equal(expected, actual);
    }
}
