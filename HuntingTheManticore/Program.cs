
// Starting values
int roundNumber = 1;
int manticoreHealth = 10;
int cityHealth = 15;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int player1Choice = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");



// Run the game until city or manticore is destroyed
while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine(getStatusUpdate(roundNumber, cityHealth, manticoreHealth));
    Console.WriteLine("Enter desired canon range: ");
    int rangeChoice = Convert.ToInt32(Console.ReadLine());

    if (rangeChoice > player1Choice) Console.WriteLine("The round OVERSHOT the target!!!");
    
    if (rangeChoice < player1Choice) Console.WriteLine("That round FELL SHORT of the target.");
  
    if (rangeChoice == player1Choice)
    {
        Console.WriteLine("That round was a DIRECT HIT!");
        int damage = cityCannonDamage(roundNumber);
        manticoreHealth -= damage;
    }

    // Every round that Manticore is alive City is loosing 1 health.
    if (manticoreHealth > 0) cityHealth--;
    
    // Move to the next round.
    roundNumber++;

}

bool won = true;
DisplayWinOrLose(won);


// ---------- METHODS ----------

// Get status update of the city and Manticore.
string getStatusUpdate(int round, int city, int manticore)
{
    return $"STATUS: Round: {roundNumber} City: {cityHealth}/15 Manticore: {manticoreHealth}/10\nThe cannon is expected to deal {cityCannonDamage(roundNumber)} damage this round.";
};

// Method to compute cannons damage based on rounds number
int cityCannonDamage(int roundNumber)
{
    int damage;
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0) damage = 10;
    else if (roundNumber % 3 == 0) damage = 3;
    else if (roundNumber % 5 == 0) damage = 3;
    else damage = 1;
 
    return damage;
}

void DisplayWinOrLose(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}