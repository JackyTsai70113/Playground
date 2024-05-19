namespace playground.UnitTest;

public class MaxEnvelopesTest0354
{
    [Theory]
    [InlineData("[[5,4],[6,4],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[6,1],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[7,2],[8,3],[9,4],[6,1],[6,7],[2,3]]", 4)]
    [InlineData("[[4,5],[4,6],[6,7],[2,3],[1,1]]", 4)]
    [InlineData("[[1,1],[1,1],[1,1]]", 1)]
    public void MaxEnvelopes(string A, int expected)
    {
        var actual = MaxEnvelopes0354.MaxEnvelopes(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
