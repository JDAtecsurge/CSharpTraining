//Console.WriteLine("Enter a first number");
//var input1 = Console.ReadLine();
//var number1 = int.Parse(input1);
//Console.WriteLine("Enter a second number");
//var input2 = Console.ReadLine();
//var number2 = int.Parse(input2);


//var calculator = new ShapesMeasurementCalculator();

//var rectangle1 = new Rectangle(number1,number2);

//Console.WriteLine("Width is " + rectangle1.Width);
//Console.WriteLine("Height is " + rectangle1.Height);
//Console.WriteLine("Circumference is :" + calculator.CalculateRectangleCircumference(rectangle1));
//Console.WriteLine("Area is :" + calculator.CalcuateRectangleArea(rectangle1));

//class Rectangle
//{
//    public int Width;
//    public int Height;

//    public Rectangle(int width, int height )
//    {
//        Width = width;
//        Height = height;
//    }


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


var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));

medicalAppointment.OverwriteMonthAndDay(5, 1);

medicalAppointment.MoveByMonthsAndDays(7, 1);





Console.ReadKey();

class MedicalAppointment
{
    public string _patientName;
    public DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName) :
        this(patientName, 7)
    {
       
    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }


    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd);
    }
}