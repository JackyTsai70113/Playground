namespace playground.UnitTest;

public class MaximumScoreTest3225
{
    [Theory]
    [InlineData("[[5]]", 0)]
    [InlineData("[[0,5],[0,3]]", 8)]
    [InlineData("[[10,9,0],[7,1,0],[5,20,0]]", 37)]
    [InlineData("[[0,0,0,0,0],[0,0,3,0,0],[0,1,0,0,0],[5,0,0,3,0],[0,0,0,0,2]]", 11)]
    [InlineData("[[10,9,0,0],[7,1,0,8],[5,20,0,11],[0,0,0,1]]", 57)]
    [InlineData("[[10,9,0,0,15],[7,1,0,8,0],[5,20,0,11,0],[0,0,0,1,2],[8,12,1,10,3]]", 94)]
    public void MaximumScore(string A, long expected)
    {
        var actual = MaximumScore3225.MaximumScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
