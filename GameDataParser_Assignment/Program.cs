using System.Runtime.InteropServices;
using System.Text.Json;

var userInteractor = new ConsoleUserInteractor();

var app = new GameDataParserApp(userInteractor,
    new GamePrinter(userInteractor),
    new VideoGamesDeserializer(userInteractor),
    new LocalFileReader());
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

    private readonly IUserInteractor _userInteractor;
    private readonly IGamePrinter _gamePrinter;
    private readonly IVideoGamesDeserializer _videoGamesDeserializer;
    private readonly IFileReader _fileReader;

    public GameDataParserApp(
        IUserInteractor userInteractor,
        IGamePrinter gamePrinter,
        IVideoGamesDeserializer videoGamesDeserializer,
        IFileReader fileReader)
    {
        _userInteractor = userInteractor;
        _gamePrinter = gamePrinter;
        _videoGamesDeserializer = videoGamesDeserializer;
        _fileReader = fileReader;
    }


    public void Run()
    {
        string fileName = _userInteractor.ReadValidFilePath();
        var fileContents = _fileReader.Read(fileName); 

        var videoGames = _videoGamesDeserializer.DeserializeFrom(fileName, fileContents);

        _gamePrinter.Print(videoGames);

    }

}

public interface IFileReader
{
    string Read(string fileName);
}

public class LocalFileReader : IFileReader
{
    public string Read(string fileName)
    {
        return File.ReadAllText(fileName);
    }
}

public interface IVideoGamesDeserializer
{
    List<VideoGame> DeserializeFrom(string fileName, string fileContents);
}

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }
    public List<VideoGame> DeserializeFrom(string fileName, string fileContents)
    {

        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {

            _userInteractor.PrintError($"JSON in {fileName} file was not " +
                $"in a valid format. JSON body;");
            _userInteractor.PrintError(fileContents);

            throw new JsonException($"{ex.Message} The File is: {fileName}", ex);
        }
    }
}

public interface IGamePrinter
{
    void Print(List<VideoGame> videoGames);
}

public class GamePrinter : IGamePrinter
{
    private readonly IUserInteractor _userInteractor;

    public GamePrinter(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage(Environment.NewLine + "Loaded games are: ");
            foreach (var videoGame in videoGames)
            {
                _userInteractor.PrintMessage(videoGame.ToString());
            }
        }
        else
        {
            _userInteractor.PrintMessage("No games are present in the input file.");
        }
    }


}


public interface IUserInteractor
{
    string ReadValidFilePath();
    void PrintMessage(string message);
    void PrintError(string message);
}

public class ConsoleUserInteractor : IUserInteractor
{

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    } 
    public void PrintError(string message)
    {
        var originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }
    public string ReadValidFilePath()
    {
        bool isFileValid = false;
        string fileName = default(string);

        do
        {

            Console.WriteLine("Enter the name of the file you want to read: ");
            fileName = Console.ReadLine();

            if (fileName is null)
            {
                Console.WriteLine("File name cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("The file name cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
            }
            else
            {

                isFileValid = true;
            }

        }
        while (!isFileValid);
        return fileName;
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

