using playground.Backtracking;

namespace playground.UnitTest.Backtracking;

public class PermuteTest
{
    [Theory]
    [InlineData("[1,2,3]", "[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,2,1],[3,1,2]]")]
    [InlineData("[0,1]", "[[0,1],[1,0]]")]
    public void Permute(string str, string str2)
    {
        var arr = str.ToArr();
        var actual = PermuteClass.Permute(arr);
        var expected = str2.To2dArr<int>();
        Assert.Equal(expected, actual.ToArray());
    }
}
