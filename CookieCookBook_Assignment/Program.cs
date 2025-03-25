using CookieCookBook_Assignment.App;
using CookieCookBook_Assignment.DataAccess;
using CookieCookBook_Assignment.FileAccess;
using CookieCookBook_Assignment.Recipes;
using CookieCookBook_Assignment.Recipes.Ingredients;
using System.Net.Http.Headers;
using System.Text.Json;


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
//cookiesRecipesApp.Run("recipes.json");

