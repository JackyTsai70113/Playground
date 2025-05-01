namespace playground.UnitTest;

public class _3212_NumberOfSubmatricesTest
{
    [Theory]
    [InlineData($@"
        [[""Y"",""X"","".""]
        ,[""Y"",""."","".""]]", 2)]
    [InlineData($@"
        [[""X"",""Y"","".""]
        ,[""Y"",""."","".""]]", 3)]
    [InlineData($@"
        [[""X"",""X""]
        ,[""X"",""X""]]", 0)]
    [InlineData($@"
        [[""X"",""X""]
        ,[""X"",""Y""]]", 0)]
    [InlineData($@"
        [[""."","".""]
        ,[""."","".""]]", 0)]
    public void NumberOfAlternatingGroups(string A, int expected)
    {
        var actual = _3212_NumberOfSubmatrices.NumberOfSubmatrices(A.To2dArr<char>());
        Assert.Equal(expected, actual);
    }
}
