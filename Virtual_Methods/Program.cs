var numbers = new List<int> { 2, -2, 5, -34, 12, -44, 23, 6 };
bool shallAddPositiveOnly = false;

NumbersSumCalculator calculator = shallAddPositiveOnly ? new PositiveNumbersSumCalculator() : new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is: " + sum);

NumbersSumCalculator cal = new EvenNumbersSumCalculator();
Console.WriteLine("Sum is " + cal.Calculate(numbers));



Console.ReadKey();

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }


}

public class PositiveNumbersSumCalculator
    : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}

public class EvenNumbersSumCalculator
    : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number % 2 == 0 && number > 0;
    }
}
