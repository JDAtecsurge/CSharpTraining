using CookieCookBook_Assignment.App;
using CookieCookBook_Assignment.DataAccess;
using CookieCookBook_Assignment.FileAccess;
using CookieCookBook_Assignment.Recipes;
using CookieCookBook_Assignment.Recipes.Ingredients;
using System.Net.Http.Headers;
using System.Text.Json;

try
{
    const FileFormat Format = FileFormat.Json;

    IStringsRepository stringsRepository = Format == FileFormat.Json ?
        new StringsJsonRepository() :
        new StringsTextualRepository();

    const string FileName = "recipes";
    var fileMetaData = new FileMetaData(FileName, Format);


    var ingredientsRegister = new IngredientsRegister();

    var cookiesRecipesApp = new CookiesRecipesApp(
            new RecipesRepository(
                new StringsJsonRepository(),
                ingredientsRegister),
            new RecipesConsoleUserInteraction(
                ingredientsRegister));

    cookiesRecipesApp.Run(fileMetaData.ToPath());
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);

    Console.WriteLine("Press any key to close.");
    Console.ReadKey();  
}
