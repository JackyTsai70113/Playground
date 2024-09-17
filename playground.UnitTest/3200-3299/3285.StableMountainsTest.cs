namespace playground.UnitTest;

public class StableMountainsTest3285
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 3, 4 })]
    [InlineData(new int[] { 10, 1, 10, 1, 10 }, 3, new int[] { 1, 3 })]
    [InlineData(new int[] { 10, 1, 10, 1, 10 }, 10, new int[] { })]
    public void StableMountains(int[] height, int threshold, int[] expected)
    {
        var actual = StableMountains3285.StableMountains(height, threshold);
        Assert.Equal(expected, actual);
    }
}
