/*
• An open door can always be closed. 
• A closed (but not locked) door can always be opened.
• A closed door can always be locked.
• A locked door can be unlocked, but a numeric passcode is needed, and the door will only unlock if 
the code supplied matches the door’s current passcode.
• When a door is created, it must be given an initial passcode.
• Additionally, you should be able to change the passcode by supplying the current code and a new 
one. The passcode should only change if the correct, current code is given.

Objectives:
• Define a Door class that can keep track of whether it is locked, open, or closed.
• Make it so you can perform the four transitions defined above with methods. 
• Build a constructor that requires the starting numeric passcode.
• Build a method that will allow you to change the passcode for an existing door by supplying the 
current passcode and new passcode. Only change the passcode if the current passcode is correct.
• Make your main method ask the user for a starting passcode, then create a new Door instance. Allow 
the user to attempt the four transitions described above (open, close, lock, unlock) and change the 
code by typing in text commands.
*/


// Ask for initial passcode
Console.WriteLine("Please set an initial passcode for the doors: ");
int initialPasscode = Convert.ToInt32(Console.ReadLine());

// Create a new door instance using initial passcode
Door door = new Door(initialPasscode);

while (true)
{
    // Ask user for commands
    Console.WriteLine($"The doors are now {door.State}. What would you like to do? (open, close, lock, unlock, change passcode)");
    string? command = Console.ReadLine();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            Console.WriteLine("Please enter the passcode: ");
            int passcode = Convert.ToInt32(Console.ReadLine());
            door.Unlock(passcode);
            break;
        case "change passcode":
            Console.WriteLine("Please enter the current passcode: ");
            int currentPasscode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new passcode: ");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            door.ChangePasscode(currentPasscode, newPasscode);
            break;
    }
}


public class Door
{
    private int _passcode;
    public DoorState State { get; private set; }
    
    public Door(int passcode)
    {
        _passcode = passcode;
        State = DoorState.closed;
    }
    public void Lock()
    { if(State == DoorState.closed) State = DoorState.locked; }
    public void Unlock(int passcode)
    { if(State == DoorState.locked && passcode == _passcode) State = DoorState.closed; }
    public void Close()
    { if(State == DoorState.open) State = DoorState.closed; }
    public void Open()
    { if(State == DoorState.closed) State = DoorState.open; }
    public void ChangePasscode(int oldPasscode, int newPasscode)
    {if(oldPasscode == _passcode) _passcode = newPasscode;} 
}

public enum DoorState  {locked, closed, open};