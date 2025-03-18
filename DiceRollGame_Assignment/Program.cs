Random random = new Random();
int dice = random.Next(1, 7);

var dicerollgame = new DiceRollGame();
dicerollgame.SetDiceNumber(dice);

dicerollgame.PlayGame();
Console.ReadKey();
