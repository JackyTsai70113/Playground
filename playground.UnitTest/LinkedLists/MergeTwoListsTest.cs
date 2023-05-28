using playground.LinkedLists;

namespace playground.UnitTest.LinkedLists;

public class MergeTwoListsTest
{
    [Theory]
    [InlineData("[1,2,4]", "[1,3,4]", "[1,1,2,3,4,4]")]
    [InlineData("[]", "[]", "[]")]
    [InlineData("[]", "[0]", "[0]")]
    [InlineData("[0]", "[]", "[0]")]
    public void MergeTwoLists(string list1, string list2, string expected)
    {
        var actual = MergeTwoListsClass.MergeTwoLists(list1.ToListNode(), list2.ToListNode());
        if (expected == "[]")
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
