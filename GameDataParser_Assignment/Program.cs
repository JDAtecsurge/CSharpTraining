using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred. ");
    logger.Log(ex);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();


public class GameDataParserApp
{
    public void Run()
    {

        bool isFileFound = false;
        var fileContents = default(string);
        string fileName = default(string);

        do
        {
            try
            {
                Console.WriteLine("Enter the name of the file you want to read: ");
                fileName = Console.ReadLine();
                fileContents = File.ReadAllText(fileName);
                isFileFound = true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("File name cannot be null.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File name cannot be null.");
            }

        }
        while (!isFileFound);

        List<VideoGame> videoGames = default;

        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"JSON in {fileName} file was not " +
                $"in a valid format. JSON body;");
            Console.WriteLine(fileContents);
            Console.ResetColor();

            throw new JsonException($"{ex.Message} The File is: {fileName}", ex);
        }


        if (videoGames.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Video Games are:");
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame.ToString());
            }
        }
        else
        {
            Console.WriteLine("No video games found in the file.");
        }



    }
}


public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString()
    {
        return $"{Title}, released in ({ReleaseYear}), ratiing : {Rating}";
    }
}

