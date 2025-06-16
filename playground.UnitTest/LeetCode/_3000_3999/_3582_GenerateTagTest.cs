using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3582_GenerateTagTest
{
    [Theory]
    [InlineData("hello world", "#helloWorld")]
    [InlineData("  leading space", "#leadingSpace")]
    [InlineData("trailing space  ", "#trailingSpace")]
    [InlineData("  multiple   spaces  ", "#multipleSpaces")]
    [InlineData("special characters !@#$%^&*()", "#specialCharacters")]
    [InlineData("Leetcode daily streak achieved", "#leetcodeDailyStreakAchieved")]
    [InlineData("can I Go There", "#canIGoThere")]
    [InlineData("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh",
        "#hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh")]
    [InlineData("long caption that exceeds the maximum length of one hundred characters, which should be truncated",
                "#longCaptionThatExceedsTheMaximumLengthOfOneHundredCharactersWhichShouldBeTruncated")]
    public void GenerateTag(string caption, string expected)
    {
        var actual = _3582_GenerateTag.GenerateTag(caption);
        Assert.Equal(expected, actual);
    }
}
