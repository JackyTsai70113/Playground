﻿namespace playground.UnitTest;

public class _2062_CountVowelSubstringsTest
{
    [Theory]
    [InlineData("aeiouu", 2)]
    [InlineData("unicornarihan", 0)]
    [InlineData("cuaieuouac", 7)]
    public void CountVowelSubstrings(string word, int expected)
    {
        var actual = _2062_CountVowelSubstrings.CountVowelSubstrings(word);
        Assert.Equal(expected, actual);
    }
}
