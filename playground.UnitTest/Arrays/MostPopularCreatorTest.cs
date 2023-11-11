using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class MostPopularCreatorTest
{
    [Theory]
    [InlineData(new string[] { "alice", "bob", "alice", "chris" }, new string[] { "one", "two", "three", "four" }, new int[] { 5, 10, 5, 4 }, "[[\"alice\",\"one\"],[\"bob\",\"two\"]]")]
    [InlineData(new string[] { "alice", "alice", "alice" }, new string[] { "a", "b", "c" }, new int[] { 1, 2, 2 }, "[[\"alice\",\"b\"]]")]
    [InlineData(new string[] { "a", "a" }, new string[] { "aa", "a" }, new int[] { 5, 5 }, "[[\"a\",\"a\"]]")]
    public void MostPopularCreator(string[] cr, string[] ids, int[] views, string expectedStr)
    {
        var actual = MostPopularCreatorClass.MostPopularCreator(cr, ids, views);
        var expected = expectedStr.To2dArr<string>();
        Assert.Equal(expected, actual);
    }
}
