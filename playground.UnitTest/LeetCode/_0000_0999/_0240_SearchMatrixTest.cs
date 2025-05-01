using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0240_SearchMatrixTest
{
    [Theory]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 1, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 15, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 18, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 5, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 20, false)]
    [InlineData("[[1],[3]]", 3, true)]
    public void SearchMatrix(string A, int target, bool expected)
    {
        var actual = _0240_SearchMatrix.SearchMatrix(A.To2dArr(), target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 1, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 15, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 18, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 5, true)]
    [InlineData("[[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]]", 20, false)]
    [InlineData("[[1],[3]]", 3, true)]
    public void SearchMatrix2(string A, int target, bool expected)
    {
        var actual = _0240_SearchMatrix.SearchMatrix2(A.To2dArr(), target);
        Assert.Equal(expected, actual);
    }
}
