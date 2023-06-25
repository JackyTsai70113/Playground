using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class CountRoutesTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 6, 8, 4 }, 1, 3, 5, 4)]
    [InlineData(new int[] { 4, 3, 1 }, 1, 0, 6, 5)]
    [InlineData(new int[] { 5, 2, 1 }, 0, 2, 3, 0)]
    [MemberData(nameof(GetData))]
    public void CountRoutes(int[] locations, int start, int finish, int fuel, int expected)
    {
        var actual = CountRoutesClass.CountRoutes(locations, start, finish, fuel);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> GetData()
    {
        yield return new object[]{
            new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100},
            0,
            99,
            200,
            709861113,
        };
    }
}
