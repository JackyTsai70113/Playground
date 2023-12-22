using playground.LinkedLists;

namespace playground.UnitTest.LinkedLists;

public class PrintLinkedListTest
{
    [Theory]
    [InlineData(0, 3, "ABC")]
    [InlineData(1, 10, "AABCBABCC")]
    [InlineData(2, 21, "AAABCBABCCBAABCBABCCC")]
    [InlineData(50, 100, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABCBABCCBAABCBABCCCBAAABCBABCCBAABCBABCCCCBAAAABCB")]
    public void Test(int n, int k, string expected)
    {
        var actual = PrintLinkedListClass.PrintLinkedList(n, k);
        Assert.Equal(expected, actual);
    }
}
