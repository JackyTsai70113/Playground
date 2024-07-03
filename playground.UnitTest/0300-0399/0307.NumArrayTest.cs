namespace playground.UnitTest;

public class NumArrayTest0307
{
    [Theory]
    [InlineData(new string[] { "NumArray", "sumRange", "update", "sumRange", "sumRange", "sumRange" }, new string[] { "[[1, 3, 5]]", "[0, 2]", "[1, 2]", "[0, 2]", "[1, 1]", "[1, 2]" }, "[null, 9, null, 8, 2,7]")]
    public void NumArray(string[] funcs, string[] valArr, string expectedStr)
    {
        NumArray0307 obj = new(valArr[0].To2dArr()[0]);
        var expected = expectedStr.ToArr<int?>();
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "sumRange":
                    var rangeVals = valArr[i].ToArr();
                    var actual = obj.SumRange(rangeVals[0], rangeVals[1]);
                    Assert.Equal(expected[i], actual);
                    break;
                case "update":
                    var updateVals = valArr[i].ToArr();
                    obj.Update(updateVals[0], updateVals[1]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
