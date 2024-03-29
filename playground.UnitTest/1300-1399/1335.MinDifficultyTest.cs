namespace playground.UnitTest;

public class MinDifficultyTest1335
{
    [Theory]
    [InlineData("[6,5,4,3,2,1]", 2, 7)]
    [InlineData("[9,9,9]", 4, -1)]
    [InlineData("[1,1,1]", 3, 3)]
    [InlineData("[380,302,102,681,863,676,243,671,651,612,162,561,394,856,601,30,6,257,921,405,716,126,158,476,889,699,668,930,139,164,641,801,480,756,797,915,275,709,161,358,461,938,914,557,121,964,315]", 10, 3807)]
    public void MinDifficulty(string A, int d, int expected)
    {
        var actual = MinDifficulty1335.MinDifficulty(A.ToArr(), d);
        Assert.Equal(expected, actual);
    }
}
