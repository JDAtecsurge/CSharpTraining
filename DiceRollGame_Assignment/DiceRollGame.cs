public class DiceRollGame
{
    private int diceNumber;
    private int NumberOfTries;
    public void SetDiceNumber(int value)
    {
        diceNumber = value;
    }
    public void PlayGame()
    {
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        while (NumberOfTries < 3)

        {
            Console.WriteLine("Enter a Number: ");
            var userInput = Console.ReadLine();
            bool isNum = int.TryParse(userInput, out int number);
            if (isNum == false)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {
                if (number == diceNumber)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong number!");
                    NumberOfTries++;
                    if (NumberOfTries == 3)
                    {
                        Console.WriteLine("You lose :(");
                    }
                }
            }
        }
    }
}