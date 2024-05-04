namespace playground.UnitTest;

public class AddTwoNumbersTest0002
{
    [Theory]
    [InlineData("[2,4,3]", "[5,6,4]", "[7,0,8]")]
    [InlineData("[0]", "[0]", "[0]")]
    [InlineData("[9,9,9,9,9,9,9]", "[9,9,9,9]", "[8,9,9,9,0,0,0,1]")]
    public void AddTwoNumbers(string l1, string l2, string expected)
    {
        var actual = AddTwoNumbers0002.AddTwoNumbers(l1.ToListNode(), l2.ToListNode());
        Assert.Equal(expected.ToString(), actual.ToString());
    }
}
