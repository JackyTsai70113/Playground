using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class PredictPartyVictoryTest
{
    [Theory]
    [InlineData("RD", "Radiant")]
    [InlineData("RDD", "Dire")]
    [InlineData("RRDDD", "Radiant")]
    [InlineData("RDRDD", "Radiant")]
    [InlineData("DRRDRDRDRDDRDRDR", "Radiant")]
    public void PredictPartyVictory(string senate, string expected)
    {
        var actual = PredictPartyVictoryClass.PredictPartyVictory(senate);

        Assert.Equal(actual, expected);
    }

    [Theory]
    [InlineData("RD", "Radiant")]
    [InlineData("RDD", "Dire")]
    [InlineData("RRDDD", "Radiant")]
    [InlineData("RDRDD", "Radiant")]
    [InlineData("DRRDRDRDRDDRDRDR", "Radiant")]
    public void PredictPartyVictory2(string senate, string expected)
    {
        var actual = PredictPartyVictoryClass.PredictPartyVictory2(senate);

        Assert.Equal(actual, expected);
    }
}
