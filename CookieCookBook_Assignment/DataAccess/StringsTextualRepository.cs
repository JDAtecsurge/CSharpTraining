﻿namespace CookieCookBook_Assignment.DataAccess;

public class StringsTextualRepository : StringsRepository
{

    private static readonly string Separator = Environment.NewLine;

    protected override string StringToText(List<string> strings)
    {
        return string.Join(Separator, strings);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }
}
