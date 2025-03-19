

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



var ingredient = new Ingredient(1);

var cheddar = new Cheddar(2,12);

Console.WriteLine(cheddar);

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() => $"This is a pizza with {string.Join(",", _ingredients)}";

}
public class Ingredient
{

    public Ingredient(int priceIfExtratopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtratopping = priceIfExtratopping;
    }


    public int PriceIfExtratopping { get; }

    public int Field;

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient";

    public string PublicMethod() => "This method is Public in the Ingredient class.";

    protected string ProtectedMethod() => "This method is Protected in the Ingredient class.";
}

public class Cheese : Ingredient
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
}

public class Mozarella : Cheese
{
    public Mozarella(int priceIfExtratopping) : base(priceIfExtratopping)
    {
    }

    public override string Name => "Mozarella";
    public bool IsLight { get; }
}

