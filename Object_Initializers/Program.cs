

var person = new Person
{
    Name = "Adam",
    YearofBirth = 1981
};



Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int YearofBirth { get; init; }

  
    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearofBirth = yearOfBirth;
    //}

}