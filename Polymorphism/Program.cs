//var ingredient = new Ingredient();
//ingredient.Field = 10;

//var cheddar = new Cheddar();

//cheddar.Field = 20;

//Console.WriteLine("value in ingredient is " + ingredient.Field);
//Console.WriteLine("value in cheddar is " + cheddar.Field);

//Console.WriteLine(cheddar.PublicMethod());
//Console.WriteLine(cheddar.ProtectedMethod());

//Console.WriteLine("Varible of Type Cheddar");
//Cheddar cheddar = new Cheddar();
//Console.WriteLine(cheddar.Name);

//Console.WriteLine("Varible of Type Ingredient");
//Ingredient ingredient = new Cheddar();
//Console.WriteLine(ingredient.Name);


//var ingredients = new List<Ingredient>
//{
//    new Cheddar(),new Mozarella(),new TomatoSauce()
//};

//foreach (Ingredient ingredent in ingredients)
//{
//    Console.WriteLine(ingredent.Name);
//}


//var pizza = new Pizza();

//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.ToString());

//int integer = 10;
//decimal b = integer;

//decimal c = 23232.01m;
//int d = (int)c;

//int secondSeasonNum = 4;
//Season summer = (Season)secondSeasonNum;
//Console.WriteLine(summer);



//Ingredient ingredient = new Cheddar(1,12);

//Ingredient randomIngredient = GenerateRandomIngredient();
//Console.WriteLine("Random ingredient is" + randomIngredient);


//Console.WriteLine("is object? " + (ingredient is object));
//Console.WriteLine("is ingredient? " + (ingredient is Ingredient));
//Console.WriteLine("is cheddar? " + (ingredient is Cheddar));
//Console.WriteLine("is mozzarella? " + (ingredient is Mozarella));
//Console.WriteLine("is tomato sauce? " + (ingredient is TomatoSauce));


//if(randomIngredient is Cheddar)
//{
//    Cheddar cheddar = (Cheddar)randomIngredient;
//    Console.WriteLine("Cheddar obejct:" + cheddar);
//}

//Ingredient ingredient = GenerateRandomIngredient();
//Console.WriteLine("Ingredient is " + ingredient);

//Cheddar cheddar = ingredient as Cheddar;

//if (cheddar is not null)
//{
//    Console.WriteLine(cheddar.Name);
//}
//else
//{
//    Console.WriteLine("Conversion failed");
//}

//var cheddar = new Cheddar(2, 12);
//var tomatosauce = new TomatoSauce(1);
//cheddar.Prepare();
//tomatosauce.Prepare();

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(2,10),
//    new Mozarella(2),
//    new TomatoSauce(1)
//};

//foreach(Ingredient ingredient in ingredients)
//{
//    ingredient.Prepare();
//}

//using Polymorphism.Extensions;

//using Polymorphism.Extensions;

//var multilineText = @"aaaaaa
//bbbb
//cccc
//dddd";

//Console.WriteLine("Count of lines is " + multilineText.CountLines());

//Console.WriteLine("Next after spring is " + Season.Spring.Next());
//Console.WriteLine("Next after winter is " + Season.Winter.Next());

//var bakeableDishes = new List<IBakeable>
//{
//    new Pizza(),new Panettone()
//};


//foreach(var bakeableDish in bakeableDishes)
//{
//    Console.WriteLine(bakeableDish.GetInstructions());
//}

using System.Text.Json;

var person = new Person
{
    FirstName = "john",
    lastName = "Smith",
    YearOfBirth = 2000
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON: ");
Console.WriteLine(asJson);

var personJson = "{\"FirstName\":\"john\",\"lastName\":\"Smith\",\"YearOfBirth\":2000}";

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

Console.ReadKey();


Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    if ( number == 1) { return new Cheddar(2, 12); }
    if (number == 2) { return new TomatoSauce(1); }
    else return new Mozarella(2);

}

public class Person
{
    public string FirstName { get; set; }
    public string lastName { get; set; }
    public int YearOfBirth { get; set; }
}


public abstract class Dessert { }

public interface IBakeable
{
    string GetInstructions();
}

public class Panettone : Dessert, IBakeable
{
    public string GetInstructions()
    {
       return "Bake at 180 degrees for 35 mins";
    }
}

public class Pizza : IBakeable
{

    public Ingredient Ingredient;
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string GetInstructions() => "bake at 250 degrees for 10 minute";

    public override string ToString() => $"This is a pizza with {string.Join(",", _ingredients)}";

}
public abstract class Ingredient
{

    public Ingredient(int priceIfExtratopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtratopping = priceIfExtratopping;
    }


    public int PriceIfExtratopping { get; }

    public abstract void Prepare();

    public int Field;

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient";

    public string PublicMethod() => "This method is Public in the Ingredient class.";

    protected string ProtectedMethod() => "This method is Protected in the Ingredient class.";
}


public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtratopping) : base(priceIfExtratopping)
    {
    }

}


public class Cheddar : Ingredient
{

    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Cheddar class");
    }


    public override string Name => $"{base.Name}, more specifically, a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza");
 

    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtratopping) : base(priceIfExtratopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }

    public sealed override void Prepare()
    {
        Console.WriteLine("Cook tomatoes with basil, garlic and salt. " + "Spread on pizza");
    }
}


public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtratopping) : base(priceIfExtratopping)
    {
    }


}



public sealed class Mozarella : Cheese
{
    public Mozarella(int priceIfExtratopping) : base(priceIfExtratopping)
    {
    }

    public override string Name => "Mozarella";
    public bool IsLight { get; }

    public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza");
 
   
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}