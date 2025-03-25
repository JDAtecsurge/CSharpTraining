//Console.WriteLine("Enter a number");
//string input = Console.ReadLine();
//try
//{
//    int number = ParseStringToInt(input);
//    var result = 10 / number; 
//    Console.WriteLine($"10/{number} is" + result);

//}
//catch( FormatException ex )
//{
//    Console.WriteLine("Wrong format. Input string is not parsable to int. " + 
//        "Exception message: " + ex.Message);

//}
//catch(DivideByZeroException ex)
//{
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

try
{
    var result = IsFirstElementPresent(null);    
}
catch (ArgumentNullException ex)
{

}




Console.ReadKey();

//int ParseStringToInt(string input)
//{
//    return int.Parse(input);
//}

void RecursiveMethod(int counter)
{
    Console.WriteLine("Recursive method is being executed" + "Counter is: " + counter);
    if (counter < 10)
    {
        RecursiveMethod(counter+1);
    }
}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }

    throw new InvalidOperationException("the collection cannot be empty.");
}

bool IsFirstElementPresent(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("the collection is empty ");
        return true;
    }
    catch(NullReferenceException ex)
    {
        Console.WriteLine("Apllication experienced an error");
        //throw;
        throw new ArgumentNullException("The collection cannot be null.", ex);
    }
    
}

class Person
{
    public string Name { get;}
    public int YearofBirth { get;}

    public Person(string name, int yearofBirth)
    {
        if(name == null)
        {
            throw new ArgumentNullException("The name cannot be null.");
        }

        if (name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if(yearofBirth < 1900 || yearofBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("The year of birth must be " + 
                "between 1900 and the current year.");
        }
        Name = name;
        YearofBirth = yearofBirth;
    }

}