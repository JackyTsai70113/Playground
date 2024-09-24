using System;
using playground._0400_0499;

namespace playground.UnitTest._0400_0499;

public class _0424_CharacterReplacementTest
{
    [Theory]
    [InlineData("ABAB", 2, 4)]
    [InlineData("AABABBA", 1, 4)]
    public void CharacterReplacement(string nums, int k, int expected)
    {
        var actual = _0424_CharacterReplacement.CharacterReplacement(nums, k);
        Assert.Equal(expected, actual);
    }
}