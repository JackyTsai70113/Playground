using playground._2100_2199;

namespace playground.UnitTest._2100_2199;

public class _2115_FindAllRecipesTest
{
    [Theory]
    [InlineData(new string[] { "bread" }, $@"
        [[""yeast"",""flour""]]",
        new string[] { "yeast", "flour", "corn" },
        new string[] { "bread" })]
    [InlineData(new string[] { "bread", "sandwich" }, $@"
        [[""yeast"",""flour""]
        ,[""bread"",""meat""]]",
        new string[] { "yeast", "flour", "meat" },
        new string[] { "bread", "sandwich" })]
    [InlineData(new string[] { "bread", "sandwich", "burger" }, $@"
        [[""yeast"",""flour""]
        ,[""bread"",""meat""]
        ,[""sandwich"",""meat"",""bread""]]",
        new string[] { "yeast", "flour", "meat" },
        new string[] { "bread", "sandwich", "burger" })]
    public void FindAllRecipes(string[] recipes, string ings, string[] supplies, string[] expected)
    {
        var actual = _2115_FindAllRecipes.FindAllRecipes(recipes, ings.To2dArr<string>(), supplies);
        Assert.Equal(expected, actual);
    }
}
