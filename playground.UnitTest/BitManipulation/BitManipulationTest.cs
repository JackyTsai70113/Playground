using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class BitManipulationTemplateTest
{
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, 2)]
    [InlineData(5, 2)]
    [InlineData(12, 2)]
    [InlineData(13, 3)]
    public void BitManipulationTemplate(int i, int expected)
    {
        var actual = BitManipulationTemplateClass.GetBitCount(i);
        Assert.Equal(expected, actual);
    }
}
