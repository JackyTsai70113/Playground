namespace playground.UnitTest.LeetCode._3000_3999;

public class _3242_NeighborSumTest
{
    [Theory]
    [InlineData(new string[] { "neighborSum", "adjacentSum", "adjacentSum", "diagonalSum", "diagonalSum" }, new string[] { "[[0,1,2],[3,4,5],[6,7,8]]", "1", "4", "4", "8" }, "[null,6,16,16,4]")]
    public void NeighborSum(string[] funcs, string[] valStr, string expectedStr)
    {
        var expected = expectedStr.ToArr<int?>();
        var A = valStr[0].To2dArr();
        _3242_NeighborSum obj = new(A);
        int actual;
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "adjacentSum":
                    actual = obj.AdjacentSum(int.Parse(valStr[i]));
                    Assert.Equal(expected[i], actual);
                    break;
                case "diagonalSum":
                    actual = obj.DiagonalSum(int.Parse(valStr[i]));
                    Assert.Equal(expected[i], actual);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
