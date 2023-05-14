using playground.BinarySearch;
using playground.UnitTest.Utils;

namespace playground.UnitTest.BinarySearch;

public class SearchMatrixTest
{
    [Theory]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 3, true)]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 13, false)]
    [InlineData("[[1],[3]]", 3, true)]
    public void SearchMatrix(string arr, int target, bool expected)
    {
        var matrix = arr.To2dArr<int>();

        var actual = SearchMatrixClass.SearchMatrix(matrix, target);

        Assert.Equal(actual, expected);
    }
}
