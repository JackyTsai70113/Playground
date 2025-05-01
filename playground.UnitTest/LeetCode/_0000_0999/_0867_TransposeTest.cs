using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0867_TransposeTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", "[[1,4,7],[2,5,8],[3,6,9]]")]
    [InlineData("[[1,2,3],[4,5,6]]", "[[1,4],[2,5],[3,6]]")]
    public void Transpose(string n, string expected)
    {
        var actual = _0867_Transpose.Transpose(n.To2dArr());
        var expectedArr = expected.To2dArr();
        Assert.Equal(expectedArr.Length, actual.Length);
        for (int i = 0; i < expectedArr.Length; ++i)
        {
            Assert.True(Enumerable.SequenceEqual(expectedArr[i], actual[i]));
        }
    }
}