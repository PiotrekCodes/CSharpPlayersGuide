/*
- Passwords must be at least 6 letters long and no more than 13 letters long.
- Passwords must contain at least one uppercase letter, one lowercase letter, and one number
-  Passwords cannot contain a capital T or an ampersand (&) because Ingelmar in IT has decreed it.
*/
while (true)
{
    Console.WriteLine("Enter a password: ");
    string? password = Console.ReadLine();
    
    if (password == null) break;

    PasswordValidator passwordValidator = new PasswordValidator();
    if (passwordValidator.isValid(password)) Console.WriteLine("This password is valid");
    else Console.WriteLine("This password is invalid");
}

public class PasswordValidator
{

    public bool isValid(string password)
    {
        if (password.Length < 6) return false;
        if (password.Length > 13) return false;
        if(!HasUppercase(password)) return false;
        if(!HasLowercase(password)) return false;
        if(!HasNumber(password)) return false;
        if(Contains(password, 'T')) return false;
        if(Contains(password, '&')) return false;
        
        
            return true;
    }

    public bool HasUppercase(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsUpper(letter)) return true;
        }
        return false;
    }
    
    public bool HasLowercase(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsLower(letter)) return true;
        }
        return false;
    }
    
    public bool HasNumber(string password)
    {
        foreach (char letter in password)
        {
            if (char.IsNumber(letter)) return true;
        }
        return false;
    }

    public bool Contains(string password, char letter)
    {
        foreach (var character in password)
        {
            if (character == letter) return true;
        }
        return false;
    }
    
}