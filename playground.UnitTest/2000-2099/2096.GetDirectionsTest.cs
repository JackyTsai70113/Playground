namespace playground.UnitTest;

public class GetDirectionsTest2096
{
    [Theory]
    [InlineData("[5,1,2,3,null,6,4]", 3, 6, "UURL")]
    [InlineData("[2,1]", 2, 1, "L")]
    public void GetDirections(string root, int start, int dest, string expected)
    {
        var actual = GetDirections2096.GetDirections(root.ToTreeNode(), start, dest);
        Assert.Equal(expected, actual);
    }
}
