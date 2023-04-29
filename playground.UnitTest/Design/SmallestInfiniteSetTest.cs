using playground.Design;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Design;

public class SmallestInfiniteSetTest
{
    [Theory]
    [InlineData("[SmallestInfiniteSet, addBack, popSmallest, popSmallest, popSmallest, addBack, popSmallest, popSmallest, popSmallest]", "[[], [2], [], [], [], [1], [], [], []]", "[null, null, 1, 2, 3, null, 1, 4, 5]")]
    public void SmallestInfiniteSetClass(string funcArr, string valArr, string expectedStr)
    {
        var funcs = funcArr.ToArr<string>();

        var vals = valArr.To2dArr<int>();

        SmallestInfiniteSetClass obj = new();
        var expected = expectedStr.ToArr<string>();
        for (int i = 0; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "SmallestInfiniteSet":
                    obj = new SmallestInfiniteSetClass();
                    break;
                case "addBack":
                    obj.AddBack(vals[i][0]);
                    break;
                case "popSmallest":
                    if (expected[i] == null) Assert.Null(obj.PopSmallest());
                    else Assert.Equal(int.Parse(expected[i]), obj.PopSmallest());
                    break;
                default:
                    break;
            }
        }
    }
}
