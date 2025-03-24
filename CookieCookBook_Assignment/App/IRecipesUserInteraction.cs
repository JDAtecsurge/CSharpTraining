using CookieCookBook_Assignment.Recipes.Ingredients;
using CookieCookBook_Assignment.Recipes;

namespace CookieCookBook_Assignment.App;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
