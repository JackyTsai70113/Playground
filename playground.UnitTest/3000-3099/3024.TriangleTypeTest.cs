namespace playground.UnitTest;

public class TriangleTypeTest3024
{
    [Theory]
    [InlineData("[3,3,7]", "none")]
    [InlineData("[3,3,3]", "equilateral")]
    [InlineData("[3,3,4]", "isosceles")]
    [InlineData("[3,4,4]", "isosceles")]
    [InlineData("[3,4,5]", "scalene")]
    public void TriangleType(string A, string expected)
    {
        var actual = TriangleType3024.TriangleType(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
