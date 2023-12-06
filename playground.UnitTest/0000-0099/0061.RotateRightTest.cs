namespace playground.UnitTest;

public class RotateRightTest_0061
{
    [Theory]
    [InlineData("[]", 3, "[]")]
    [InlineData("[1]", 1, "[1]")]
    [InlineData("[0,1,2]", 0, "[0,1,2]")]
    [InlineData("[0,1,2]", 4, "[2,0,1]")]
    [InlineData("[1,2,3,4,5]", 2, "[4,5,1,2,3]")]
    public void RotateRight(string head, int k, string expected)
    {
        var actual = RotateRight_0061.RotateRight(head.ToListNode(), k);
        if (!expected.ToArr().Any())
            Assert.Null(actual);
        else
            Assert.Equal(expected, actual.ToString());
    }
}
