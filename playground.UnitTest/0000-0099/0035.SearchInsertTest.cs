namespace playground.UnitTest;

public class SearchInsertTest0035
{
    [Theory]
    [InlineData("[1,3,5,6]", 0, 0)]
    [InlineData("[1,3,5,6]", 2, 1)]
    [InlineData("[1,3,5,6]", 5, 2)]
    [InlineData("[1,3,5,6]", 7, 4)]
    public void SearchInsert(string nums, int target, int expected)
    {
        var actual = SearchInsert0035.SearchInsert(nums.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
