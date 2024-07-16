namespace playground.UnitTest;

public class GetDirectionsTest2096
{
    [Theory]
    [InlineData("[2,1]", 2, 1, "L")]
    [InlineData("[5,1,2,3,null,6,4]", 3, 6, "UURL")]
    [InlineData("[1,null,10,12,13,4,6,null,15,null,null,5,11,null,2,14,7,null,8,null,null,null,9,3]", 6, 15, "UURR")]
    [InlineData("[5,8,3,1,null,4,7,6,null,null,null,null,null,null,2]", 4, 3, "U")]
    public void GetDirections(string root, int start, int dest, string expected)
    {
        var actual = GetDirections2096.GetDirections(root.ToTreeNode(), start, dest);
        Assert.Equal(expected, actual);
    }
}
