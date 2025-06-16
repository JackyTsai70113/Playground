using System.Text.Json;
using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0051_SolveNQueensTest
{
    // test _0051_SolveNQueens
    [Theory]
    [InlineData(1, $@"[[""Q""]]")]
    [InlineData(2, $@"[]")]
    [InlineData(3, $@"[]")]
    [InlineData(4, $@"
        [["".Q.."",""...Q"",""Q..."",""..Q.""]
        ,[""..Q."",""Q..."",""...Q"","".Q..""]]")]
    [InlineData(5, $@"
        [[""Q...."",""..Q.."",""....Q"","".Q..."",""...Q.""]
        ,[""Q...."",""...Q."","".Q..."",""....Q"",""..Q..""]
        ,["".Q..."",""...Q."",""Q...."",""..Q.."",""....Q""]
        ,["".Q..."",""....Q"",""..Q.."",""Q...."",""...Q.""]
        ,[""..Q.."",""Q...."",""...Q."","".Q..."",""....Q""]
        ,[""..Q.."",""....Q"","".Q..."",""...Q."",""Q....""]
        ,[""...Q."",""Q...."",""..Q.."",""....Q"","".Q...""]
        ,[""...Q."","".Q..."",""....Q"",""..Q.."",""Q....""]
        ,[""....Q"","".Q..."",""...Q."",""Q...."",""..Q..""]
        ,[""....Q"",""..Q.."",""Q...."",""...Q."","".Q...""]]")]
    public void SolveNQueensTest(int n, string expected)
    {
        var actual = _0051_SolveNQueens.SolveNQueens(n);
        Assert.Equal(expected.To2dArr<string>(), actual);
    }
}