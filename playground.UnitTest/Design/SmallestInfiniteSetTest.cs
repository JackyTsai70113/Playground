using playground.Design;

namespace playground.UnitTest.Design;

public class SmallestInfiniteSetTest
{
    [Theory]
    [InlineData(new string[] { "SmallestInfiniteSet", "addBack", "popSmallest", "popSmallest", "popSmallest", "addBack", "popSmallest", "popSmallest", "popSmallest" }, "[[], [2], [], [], [], [1], [], [], []]", new string[] { null, null, "1", "2", "3", null, "1", "4", "5" })]
    public void SmallestInfiniteSetTest1(string[] funcs, string valArr, string[] expected)
    {
        var vals = valArr.To2dArr();
        SmallestInfiniteSet obj = new();
        for (int i = 0; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "SmallestInfiniteSet":
                    obj = new SmallestInfiniteSet();
                    break;
                case "addBack":
                    obj.AddBack(vals[i][0]);
                    break;
                case "popSmallest":
                    if (expected[i] == null) Assert.Null(obj.PopSmallest());
                    else Assert.Equal(int.Parse(expected[i]), obj.PopSmallest());
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
