namespace playground.UnitTest;

public class DeckRevealedIncreasingTest0950
{
    [Theory]
    [InlineData(new int[] { 17, 13, 11, 2, 3, 5, 7 }, new int[] { 2, 13, 3, 11, 5, 17, 7 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 5, 2, 7, 3, 6, 4, 8 })]
    [InlineData(new int[] { 1, 1000 }, new int[] { 1, 1000 })]
    public void DeckRevealedIncreasing(int[] deck, int[] expected)
    {
        var actual = DeckRevealedIncreasing0950.DeckRevealedIncreasing(deck);
        Assert.Equal(expected, actual);
    }
}
