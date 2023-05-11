Console.WriteLine("Simula's Test");

ChestState currentState = ChestState.locked;

while (true)
{
    Console.WriteLine($"The chest is now {currentState}. What do you want to do? ");

    string input = Console.ReadLine();

    if(currentState == ChestState.locked && input == "unlock") currentState = ChestState.closed;
    if(currentState == ChestState.closed && input == "open") currentState = ChestState.open;
    if(currentState == ChestState.open &&  input == "close") currentState = ChestState.closed;
    if (currentState == ChestState.closed && input == "lock") currentState= ChestState.locked;
}



enum ChestState
{
    open,
    closed,
    locked
}