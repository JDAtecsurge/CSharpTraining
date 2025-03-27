//Console.WriteLine("Enter a number");
//string input = Console.ReadLine();
//try
//{
//    int number = ParseStringToInt(input);
//    var result = 10 / number;
//    Console.WriteLine($"10/{number} is" + result);

//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Wrong format. Input string is not parsable to int. " +
//        "Exception message: " + ex.Message);

//}
//catch (DivideByZeroException ex)
//{
//    try
//    {
//       int.Parse("not an int");
//    }
//    catch (FormatException ex2)
//    {

//    }

//    Console.WriteLine("Division by zero is not allowed. " +
//        "Exception message: " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("An error occured. " +
//        "Exception message: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally block is being executed");
//}


//var result = GetFirstElement(new int[0]);

//var person = new Person("John", 234);

//var emptyCollection = new List<int>();

//var firstUsingLinq = emptyCollection.First();


//var numbers = new int[] { 1, 2, 3};
//var fourth = numbers[3];

//bool has7 = CheckIfContains7(7,numbers);

//bool CheckIfContains7(int value, int[] numbers)
//{
//    throw new NotImplementedException();
//}


//RecursiveMethod(11);

//try
//{
//    var result = IsFirstElementPresent(null);    
//}
//catch (ArgumentNullException ex)
//{

//}


//try
//{
//    var dataFromweb = SendHttpRequest("www.someAddress.com/get/someResource");
//}
//catch(HttpRequestException ex) when (ex.Message == "403")
//{
//    Console.WriteLine("It was forbidden to access the resource.");
//    throw;
//}
//catch(HttpRequestException ex) when (ex.Message == "404")
//{
//    Console.WriteLine("The resource was not found.");
//    throw;
//}
//catch(HttpRequestException ex) when (ex.Message.StartsWith("4"))
//{
//    Console.WriteLine("Some kind of client error.");
//    throw;
//}
//catch(HttpRequestException ex) when (ex.Message == "500")
//{
//    Console.WriteLine("The server has experienced an internal error.");
//    throw;
//}

//using System.Runtime.Serialization;

//throw new Exception();

//try
//{
//    ComplexMethod();
//}
//catch(InvalidOperationException ex) when (ex.Message == "Cannot connect to a service.")
//{
//    Console.WriteLine("Check your Internet connection");
//    throw;
//}
//}

try
{
    Run();

}
catch (Exception ex)
{
    Console.WriteLine("An error occured. " + 
        "Exception message: " + ex.Message);
}

Console.ReadKey();


void Run()
{
    try
    {
        Console.WriteLine("Enter a word");
        var word = Console.ReadLine();
        Console.WriteLine("Count of characters is " + word.Length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Exception has beeen thrown with a message" +
            ex.Message);
        throw;
    }   
}


    //[Serializable]
    //public class CustomException : Exception
    //{

    //    public int StatusCode { get; }

    //    protected CustomException(
    //        SerializationInfo info,
    //        StreamingContext context) : base(info, context)
    //    {

    //    }

    //    public CustomException()
    //    {

    //    }
    //    public CustomException(string message, int statusCode) : base(message)
    //    {
    //        StatusCode = statusCode;
    //    }
    //    public CustomException(
    //        string message, 
    //        int statusCode, 
    //        Exception innerException) : base(message, innerException)
    //    {
    //        StatusCode = statusCode;
    //    }

    //    public CustomException(string message) : base(message)
    //    {

    //    }
    //    public CustomException(string message, Exception innerException) 
    //        : base(message, innerException) 
    //    {

    //    }

    //}



    //int ParseStringToInt(string input)
    //{
    //    return int.Parse(input);
    //}

//void RecursiveMethod(int counter)
//{
//    Console.WriteLine("Recursive method is being executed" + "Counter is: " + counter);
//    if (counter < 10)
//    {
//        RecursiveMethod(counter+1);
//    }
//}

    //int GetFirstElement(IEnumerable<int> numbers)
    //{
    //    foreach (var number in numbers)
    //    {
    //        return number;
    //    }

    //    throw new InvalidOperationException("the collection cannot be empty.");
    //}

    //bool IsFirstElementPresent(IEnumerable<int> numbers)
    //{
    //    try
    //    {
    //        var firstElement = GetFirstElement(numbers);
    //        return firstElement > 0;
    //    }
    //    catch (InvalidOperationException ex)
    //    {
    //        Console.WriteLine("the collection is empty ");
    //        return true;
    //    }
    //    catch(NullReferenceException ex)
    //    {
    //        Console.WriteLine("Apllication experienced an error");
    //        //throw;
    //        throw new ArgumentNullException("The collection cannot be null.", ex);
    //    }

    //}

    //void ComplexMethod()
    //{
    //    //step 1: connecting
    //    throw new ConnectionException("Cannot connect to a service.");

    //    //step 2: authorizing
    //    throw new AuthorizationException("Cannot authoruze the user");

    //    //step 3: retrieving data as JSON
    //    throw new DataAccessException("Cannot retrieve data.");

    //    //step 4: parsing the JSON to some C# type
    //    throw new JsonParingException("Cannot parse JSON data.");

    //}


class Person
{
    public string Name { get; }
    public int YearofBirth { get; }

    public Person(string name, int yearofBirth)
    {
        if (name == null)
        {
            throw new ArgumentNullException("The name cannot be null.");
        }

        if (name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if (yearofBirth < 1900 || yearofBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("The year of birth must be " +
                "between 1900 and the current year.");
        }
        Name = name;
        YearofBirth = yearofBirth;
    }

}

