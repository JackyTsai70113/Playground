namespace playground.UnitTest;

public class MinMovesToCaptureTheQueenTest6
{
    [Theory]
    [InlineData(1, 1, 8, 8, 2, 3, 2)]
    [InlineData(5, 3, 3, 4, 5, 2, 1)]
    [InlineData(5, 3, 5, 1, 5, 2, 1)]
    [InlineData(5, 3, 5, 4, 5, 2, 1)]
    [InlineData(5, 3, 5, 2, 5, 1, 2)]

    [InlineData(5, 3, 1, 2, 3, 3, 1)]
    [InlineData(5, 3, 1, 3, 3, 3, 1)]
    [InlineData(5, 3, 4, 3, 3, 3, 2)]
    [InlineData(5, 3, 6, 3, 3, 3, 1)]

    [InlineData(3, 1, 6, 4, 4, 2, 1)]
    [InlineData(5, 3, 6, 4, 4, 2, 2)]
    [InlineData(7, 5, 6, 4, 4, 2, 1)]
    [InlineData(6, 5, 6, 4, 4, 2, 1)]

    [InlineData(1, 1, 2, 4, 4, 2, 1)]
    [InlineData(1, 5, 2, 4, 4, 2, 1)]
    [InlineData(3, 3, 2, 4, 4, 2, 2)]
    [InlineData(5, 1, 2, 4, 4, 2, 1)]
    public void MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f, int expected)
    {
        var actual = MinMovesToCaptureTheQueen6.MinMovesToCaptureTheQueen(a, b, c, d, e, f);
        Assert.Equal(expected, actual);
    }
}
