using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

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
