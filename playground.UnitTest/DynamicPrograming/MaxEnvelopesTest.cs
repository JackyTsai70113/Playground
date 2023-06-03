using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MaxEnvelopesTest
{
    [Theory]
    [InlineData("[[5,4],[6,4],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[6,1],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[7,2],[8,3],[9,4],[6,1],[6,7],[2,3]]", 4)]
    [InlineData("[[4,5],[4,6],[6,7],[2,3],[1,1]]", 4)]
    [InlineData("[[1,1],[1,1],[1,1]]", 1)]
    public void MaxEnvelopes(string g, int expected)
    {
        var actual = MaxEnvelopesClass.MaxEnvelopes(g.To2dArr());
        Assert.Equal(expected, actual);
    }
}
