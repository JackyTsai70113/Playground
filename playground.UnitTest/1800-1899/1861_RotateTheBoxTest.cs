using playground._1800_1899;

namespace playground.UnitTest._1800_1899;

public class _1861_RotateTheBoxTest
{
    [Theory]
    [InlineData($@"
        [[""#"",""."",""#""]]",
        $@"
        [["".""]
        ,[""#""]
        ,[""#""]]")]
    [InlineData($@"
        [[""#"",""."",""*"","".""]
        ,[""#"",""#"",""*"","".""]]",
         $@"
        [[""#"","".""]
        ,[""#"",""#""]
        ,[""*"",""*""]
        ,[""."","".""]]")]
    [InlineData($@"
        [[""#"",""#"",""*"",""."",""*"","".""]
        ,[""#"",""#"",""#"",""*"",""."","".""]
        ,[""#"",""#"",""#"",""."",""#"","".""]]",
        $@"
        [[""."",""#"",""#""]
        ,[""."",""#"",""#""]
        ,[""#"",""#"",""*""]
        ,[""#"",""*"","".""]
        ,[""#"",""."",""*""]
        ,[""#"",""."","".""]]")]
    public void RotateTheBox(string box, string expected)
    {
        var actual = _1861_RotateTheBox.RotateTheBox(box.To2dArr<char>());
        Assert.Equal(expected.To2dArr<char>(), actual);
    }
}
