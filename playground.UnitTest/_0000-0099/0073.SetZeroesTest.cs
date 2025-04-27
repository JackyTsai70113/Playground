namespace playground.UnitTest;

public class SetZeroesTest
{
    [Theory]
    [InlineData("[[1,1,1],[1,0,1],[1,1,1]]", "[[1,0,1],[0,0,0],[1,0,1]]")]
    [InlineData("[[0,1,2,0],[3,4,5,2],[1,3,1,5]]", "[[0,0,0,0],[0,4,5,0],[0,3,1,0]]")]
    public void SetZeroes(string A, string expected)
    {
        var actual = A.To2dArr();
        SetZeroes_0073.SetZeroes(actual);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
