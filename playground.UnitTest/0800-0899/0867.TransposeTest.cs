namespace playground.UnitTest;

public class TransposeTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", "[[1,4,7],[2,5,8],[3,6,9]]")]
    [InlineData("[[1,2,3],[4,5,6]]", "[[1,4],[2,5],[3,6]]")]
    public void Transpose(string n, string expected)
    {
        var actual = Transpose_0867.Transpose(n.To2dArr());
        var expectedArr = expected.To2dArr();
        Assert.Equal(expectedArr.Length, actual.Length);
        for (int i = 0; i < expectedArr.Length; ++i)
        {
            Assert.True(Enumerable.SequenceEqual(expectedArr[i], actual[i]));
        }
    }
}
