
bool isParsingSuccess;
do
{
    Console.WriteLine("Enter num");
    var input = Console.ReadLine();
    isParsingSuccess = int.TryParse(input, out int number);
    if (isParsingSuccess)
    {
        Console.WriteLine("Success number is " + number);
    }
    else
    {
        Console.WriteLine("Not worked");
    }

}
while (!isParsingSuccess);




//var numbers = new[] { 10, -8, 2, 12, -17 };
//int countnonpositive;

//List<int> Getpositive(int[] numbers, out int nonpositive)
//{
//    var result = new List<int>();
//    nonpositive = 0;
//    foreach(var number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//        else
//        {
//            nonpositive++;
//        }
//    }
//    return result;

//}

//var onlypositive = Getpositive(numbers,out countnonpositive);
//foreach(var positive in onlypositive)
//{
//    Console.WriteLine(positive);
//}

//Console.WriteLine(countnonpositive);







//List<string> words = new List<string>
//{
//    "one",
//    "two",
//    "three",
//    "four",
//};

//var moreWords = new[] { "five", "six", "seven" };
//words.AddRange(moreWords);

//Console.WriteLine(words.IndexOf("five"));

//Console.WriteLine(words.Contains("four"));

//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("Remove item");
//words.RemoveAt(3);

//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}

//words.Clear();
//Console.WriteLine(words.Count);









//var words = new[] { "one", "two", "three", "four" };

//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}





//char[,] letters = new char[2, 3];

//letters[0, 0] = 'A';
//letters[0, 1] = 'B';
//letters[0, 2] = 'C';
//letters[1, 0] = 'D';
//letters[1, 1] = 'E';
//letters[1, 2] = 'F';

//var letters2 = new char[,]
//{
//    {'A', 'B', 'C' },
//    { 'D', 'E', 'F'},
//};


//var height = letters.GetLength(0);
//var width = letters.GetLength(1);
//Console.WriteLine("Height is " + height);
//Console.WriteLine("Width is " + width);

//for (var i = 0; i < height; i++)
//{
//    Console.WriteLine("i is " + i);

//    for (var j = 0; j < width; j++)
//    {
//        Console.WriteLine("j is " + j);
//        Console.WriteLine("element is " + letters[i, j]);
//    }
//}





//int[] numbers = new int[] {2,3,4,5,6,7};
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum = sum + numbers[i];

//}
//Console.WriteLine(sum);





//for(var i = 0; i < 20; i++)
//{
//    if (i % 3 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine("i is " + i);

//int number;
//do
//{
//    Console.WriteLine("Enter a number");
//    var input = Console.ReadLine();

//    bool isParsable = input.All(char.IsDigit);
//    if (!isParsable)
//    {
//        number = 0;
//        continue;
//    }

//    number = int.Parse(input);
//}
//while (number<=10);


















//Console.WriteLine("Hello");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");



//var userChoice = Console.ReadLine();


//switch (userChoice)
//{
//    case "S":
//        Console.WriteLine("See all todo");
//        break;
//    case "A":
//        Console.WriteLine("Add todo");
//        break;
//    case "R":
//        Console.WriteLine("Remove todo");
//        break;
//    case "E":
//        Console.WriteLine("Exit");
//        break;
//    default:
//        Console.WriteLine("none of the choice");
//        break;

//}




//Console.WriteLine("Hello World");

//int a = 2, b=2, c = 2;

//Console.WriteLine($"Frist is: {a} second is: {b} third is: {c}");


Console.ReadKey();
