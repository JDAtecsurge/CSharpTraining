namespace CookieCookBook_Assignment.DataAccess;

public abstract class StringsRepository : IStringsRepository
{

    public List<string> Read(string filePath)
    {
        if (File.Exists(filePath))
        {
            var fileContents = File.ReadAllText(filePath);
            return TextToStrings(fileContents);
        }

        return new List<string>();
    }

    protected abstract List<string> TextToStrings(string filePath);
   

    public void Write(string filePath, List<string> strings) =>
        File.WriteAllText(filePath, StringToText(strings));

    protected abstract string StringToText(List<string> strings);

}
