using playground.Stacks;

namespace playground.UnitTest.Stacks;

public class LengthLongestPathTest
{
    [Theory]
    [InlineData("dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext", 20)]
    [InlineData("dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext", 32)]
    [InlineData("a", 0)]
    public void LengthLongestPath(string a, int expected)
    {
        var actual = LengthLongestPathClass.LengthLongestPath(a);
        Assert.Equal(expected, actual);
    }
}
