﻿//Console.WriteLine("Enter a first number");
//var input1 = Console.ReadLine();
//var number1 = int.Parse(input1);
//Console.WriteLine("Enter a second number");
//var input2 = Console.ReadLine();
//var number2 = int.Parse(input2);


//var calculator = new ShapesMeasurementCalculator();

var rectangle1 = new Rectangle(2, 5);
var rectangle2 = new Rectangle(2, 5);
var rectangle3 = new Rectangle(2, 5);


Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);

//Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine(Rectangle.Numberofsides);

//Console.WriteLine("Width is " + rectangle1.Width);
//rectangle1.Width = 15;
//Console.WriteLine("Height is " + rectangle1.GetHeight());
//Console.WriteLine("Circumference is :" + rectangle1.CalculateRectangleCircumference());
//Console.WriteLine("Area is :" + rectangle1.CalcuateRectangleArea());


//Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($"1 + 2 is {Calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 + 2 is {Calculator.Multiply(1, 2)}");


Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;

    
}

class Rectangle
{

    public static int CountOfInstances { get; private set; }
    private static DateTime _firstused;

    static Rectangle()
    {
        _firstused = DateTime.Now;
    }

    public Rectangle(int width, int height)
    {
        Width = GetLengthorDefault(width, nameof(Width));
        _height = GetLengthorDefault(height, nameof(_height));
        ++CountOfInstances;

    }

    public int Width { get; set; }
 


    private int _height;

    



    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if(value > 0)
        {
            _height = value;
        }
    }


    private int GetLengthorDefault(int length, string name)
    {
        const int DefaultValueIfNonPostive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return DefaultValueIfNonPostive;
        }
        return length;
    }

    public int CalculateRectangleCircumference() => 2 * Width + 2 * _height;
    public int CalcuateRectangleArea() => _height * Width;


    public string Description => $"A rectangle with width {Width}" + $"and hegiht {_height}";


    public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";


    public const int Numberofsides = 4;
}



//class ShapesMeasurementCalculator //Expression bodied method
//{
//    public int CalculateRectangleCircumference(Rectangle rectangle) => 2 * rectangle.Width + 2 * rectangle.Height;


//    public int CalcuateRectangleArea(Rectangle rectangle) => rectangle.Height * rectangle.Width;

//}



//class ShapesMeasurementCalculator
//{
//    public int CalculateRectangleCircumference(Rectangle rectangle)
//    {
//        return 2 * rectangle.Width + 2 * rectangle.Height;
//    }

//    public int CalcuateRectangleArea(Rectangle rectangle)
//    {
//        return rectangle.Height * rectangle.Width;
//    }
//}







////var medicalAppointment = new MedicalAppointment(
////    "John Smith", new DateTime(2023, 4, 3));

////medicalAppointment.Reschedule(new DateTime(2023, 4, 5));

////var appointmentTwoweeksFromNow = new MedicalAppointment("Bob Smith", 14);

////var appointmentOneweeksFromNow = new MedicalAppointment("Marga Smith");

//var onlyname = new MedicalAppointment("name only");


//class MedicalAppointmentPrinter
//{
//    public void Print(MedicalAppointment medicaAppointment)
//    {
//        Console.WriteLine("Appointment will take place on " + medicaAppointment.GetDate());
//    }
//}


//class MedicalAppointment
//{
//    public string _patientName;
//    public DateTime _date;

//    public MedicalAppointment(string patientName, DateTime date)
//    {
//        _patientName = patientName;
//        _date = date;
//    }

//    public DateTime GetDate() => _date;

//    //public MedicalAppointment(string patientName) :
//    //    this(patientName, 7)
//    //{

//    //}


//    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
//    {
//        _patientName = patientName;
//        _date = DateTime.Now.AddDays(daysFromNow);
//    }


//    public void Reschedule(DateTime date)
//    {
//        _date = date;
//        var printer = new MedicalAppointmentPrinter();
//        printer.Print(this);
//    }

//    public void OverwriteMonthAndDay(int month, int day)
//    {
//        _date = new DateTime(_date.Year, month, day);
//    }

//    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
//    {
//        _date = new DateTime(
//            _date.Year,
//            _date.Month + monthsToAdd,
//            _date.Day + daysToAdd);
//    }
//}