namespace playground.UnitTest;

public class DecodeAtIndexTest0880
{
    [Theory]
    [InlineData("leet2code3", 10, "o")]
    [InlineData("ha22", 5, "h")]
    [InlineData("a2345678999999999999999", 1, "a")]
    [InlineData("czjkk9elaqwiz7s6kgvl4gjixan3ky7jfdg3kyop3husw3fm289thisef8blt7a7zr5v5lhxqpntenvxnmlq7l34ay3jaayikjps", 768077956, "c")]
    public void DecodeAtIndex(string s, int k, string expected)
    {
        var actual = DecodeAtIndex0880.DecodeAtIndex(s, k);
        Assert.Equal(expected, actual);
    }
}
