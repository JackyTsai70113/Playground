using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0726_CountOfAtomsTest
{
    [Theory]
    [InlineData("Mg(H2O)N", "H2MgNO")]
    [InlineData("H2O", "H2O")]
    [InlineData("Mg(OH)2", "H2MgO2")]
    [InlineData("K4(ON(SO3)2)2", "K4N2O14S4")]
    [InlineData("((HHe28Be26He)9)34", "Be7956H306He8874")]
    public void CountOfAtoms(string A, string expected)
    {
        var actual = new _0726_CountOfAtoms().CountOfAtoms(A);
        Assert.Equal(expected, actual);
    }
}
