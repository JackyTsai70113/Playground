namespace playground.UnitTest;

public class MaxPathLengthTest3288
{
    [Theory]
    [InlineData("[[3,1],[2,2],[4,1],[0,0],[5,3]]", 1, 3)]
    [InlineData("[[2,1],[7,0],[5,6]]", 2, 2)]
    [InlineData("[[1,8],[9,8],[9,9]]", 1, 1)]
    [InlineData("[[5,0],[4,9],[9,2]]", 1, 1)]
    [InlineData("[[5,0],[9,3],[9,8]]", 0, 2)]
    [InlineData("[[313980967,13888427],[473620925,693757796],[407503949,713002778],[833031297,798864094],[672541157,478829491],[885972706,982962973],[547347833,726188327],[975269668,853554872],[393978782,293882769],[506907326,462657319],[114562239,221757642]]", 1, 6)]
    public void MaxPathLength(string A, int k, int expected)
    {
        var actual = MaxPathLength3288.MaxPathLength(A.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
