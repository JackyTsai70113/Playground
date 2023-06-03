using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class SearchMatrixTest
{
    [Theory]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 3, true)]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 13, false)]
    [InlineData("[[1],[3]]", 3, true)]
    [InlineData("[[1],[0]]", 0, false)]
    public void SearchMatrix(string A, int target, bool expected)
    {
        var actual = SearchMatrixClass.SearchMatrix(A.To2dArr(), target);
        Assert.Equal(expected, actual);
    }
}
