Console.WriteLine("Hello Nilo !");
Console.WriteLine("Input the First Number");
string input1 = Console.ReadLine();
Console.WriteLine("Input the Second Number");
string input2 = Console.ReadLine();

int firstNum = int.Parse(input1);
int secondNum = int.Parse(input2);
Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
Console.WriteLine("[D]ivide numbers");

string input = Console.ReadLine();
int result;

if (input == "A" || input == "a")
{
    result = firstNum + secondNum;
    PrintFinalEquation(firstNum, secondNum, result, "+");
}
else if (input == "S" || input == "s")
{
    result = firstNum - secondNum;
    PrintFinalEquation(firstNum, secondNum, result, "-");
}
else if (input == "M" || input == "m")
{
    result = firstNum * secondNum;
    PrintFinalEquation(firstNum, secondNum, result, "*");
}
else if (input == "D" || input == "d")
{
    result = firstNum / secondNum;
    PrintFinalEquation(firstNum, secondNum, result, "/");
}
else
{
    Console.WriteLine("Invalid choice!");
}

void PrintFinalEquation(int num1, int num2, int result, string @operator)
{
    Console.WriteLine(num1 + " " + @operator + " " + num2 + " = " + result);

}


Console.WriteLine("Press any key to close");

Console.ReadKey();