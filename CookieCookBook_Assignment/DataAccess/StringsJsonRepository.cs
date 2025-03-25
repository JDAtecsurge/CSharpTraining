using System.Text.Json;
using System.Net.Http.Headers;
using CookieCookBook_Assignment.Recipes.Ingredients;

namespace CookieCookBook_Assignment.DataAccess;

public class StringsJsonRepository : StringsRepository
{
    protected override string StringToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}
