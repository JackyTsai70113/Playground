namespace playground.UnitTest;

public class MergeKListsTest0023
{
    [Theory]
    [InlineData(new string[] { "[1,4,5]", "[1,3,4]", "[2,6]" }, "[1,1,2,3,4,4,5,6]")]
    [InlineData(new string[] { "[]" }, "[]")]
    [InlineData(new string[] { }, "[]")]
    public void MergeKLists(string[] lists, string expected)
    {
        var actual = MergeKLists0023.MergeKLists(lists.Select(x => x.ToListNode()).ToArray());
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
