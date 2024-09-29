using playground._0600_0699;

namespace playground.UnitTest._0600_0699;

public class _0641_MyCircularDequeTest
{
    [Theory]
    [InlineData(
        new string[] { "MyCircularDeque", "insertLast", "insertLast", "insertFront", "insertFront", "getRear", "isFull", "deleteLast", "insertFront", "getFront" },
        "[[3],[1],[2],[3],[4],[],[],[],[4],[]]",
        new object[] { null, true, true, true, false, 2, true, true, true, 4 })]
    [InlineData(
        new string[] { "MyCircularDeque", "insertFront", "getFront", "isEmpty", "deleteFront", "insertLast", "getRear", "insertLast", "insertFront", "deleteLast", "insertLast", "isEmpty" },
        "[[8],[5],[],[],[],[3],[],[7],[7],[],[4],[]]",
        new object[] { null, true, 5, false, true, true, 3, true, true, true, true, false })]
    [InlineData(
        new string[] { "MyCircularDeque", "insertFront", "insertFront", "insertLast", "deleteFront", "deleteLast", "deleteFront", "deleteLast", "getFront", "getRear" },
        "[[2],[5],[4],[3],[],[],[],[],[],[]]",
        new object[] { null, true, true, false, true, true, false, false, -1, -1 })]
    public void MyCircularDeque(string[] funcs, string valStr, object[] expected)
    {
        var vals = valStr.To2dArr();
        _0641_MyCircularDeque obj = new(vals[0][0]);
        for (int i = 1; i < funcs.Length; ++i)
        {
            switch (funcs[i])
            {
                case "insertFront":
                    Assert.Equal(obj.InsertFront(vals[i][0]), expected[i]);
                    break;
                case "insertLast":
                    Assert.Equal(obj.InsertLast(vals[i][0]), expected[i]);
                    break;
                case "deleteFront":
                    Assert.Equal(obj.DeleteFront(), expected[i]);
                    break;
                case "deleteLast":
                    Assert.Equal(obj.DeleteLast(), expected[i]);
                    break;
                case "getFront":
                    Assert.Equal(obj.GetFront(), expected[i]);
                    break;
                case "getRear":
                    Assert.Equal(obj.GetRear(), expected[i]);
                    break;
                case "isEmpty":
                    Assert.Equal(obj.IsEmpty(), expected[i]);
                    break;
                case "isFull":
                    Assert.Equal(obj.IsFull(), expected[i]);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
