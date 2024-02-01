namespace playground.UnitTest;

public class SearchMatrixTest0074
{
    [Theory]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 3, true)]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 13, false)]
    public void SearchMatrix(string nums, int target, bool expected)
    {
        var actual = SearchMatrix0074.SearchMatrix(nums.To2dArr(), target);
        Assert.Equal(expected, actual);
    }
}
