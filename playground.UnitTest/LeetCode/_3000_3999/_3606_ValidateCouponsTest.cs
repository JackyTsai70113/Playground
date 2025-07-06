using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3606_ValidateCouponsTest
{
    [Theory]
    [InlineData(new[] { "SAVE20", "", "PHARMA5", "SAVE@20" }, new[] { "restaurant", "grocery", "pharmacy", "restaurant" }, new[] { true, true, true, true }, new[] { "PHARMA5", "SAVE20" })]
    [InlineData(new[] { "GROCERY15", "ELECTRONICS_50", "DISCOUNT10" }, new[] { "grocery", "electronics", "invalid" }, new[] { false, true, true }, new[] { "ELECTRONICS_50" })]
    public void ValidateCoupons(string[] code, string[] businessLine, bool[] isActive, string[] expected)
    {
        // Act
        var actual = _3606_ValidateCoupons.ValidateCoupons(code, businessLine, isActive);

        // Assert
        Assert.Equal(expected, actual);
    }
}
