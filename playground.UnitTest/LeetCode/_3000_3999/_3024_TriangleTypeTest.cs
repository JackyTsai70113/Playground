namespace playground.UnitTest;

public class _3024_TriangleTypeTest
{
    [Theory]
    [InlineData("[3,3,7]", "none")]
    [InlineData("[3,3,3]", "equilateral")]
    [InlineData("[3,3,4]", "isosceles")]
    [InlineData("[3,4,4]", "isosceles")]
    [InlineData("[3,4,5]", "scalene")]
    public void TriangleType(string A, string expected)
    {
        var actual = _3024_TriangleType.TriangleType(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
