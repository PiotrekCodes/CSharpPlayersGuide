Console.WriteLine(WelcomeMessage());
Arrow arrow = GetArrowMenu();
Console.WriteLine($"Your arrow will cost {arrow.GetCost()} gold coins.");

Arrow GetArrow()
{
    ArrowHead arrowHead = GetArrowHead();
    Fletching fletching = GetFletching();
    int arrowLength = GetArrowLength();
    return new Arrow(arrowHead, fletching, arrowLength);
}

string WelcomeMessage()
{
    return "Welcome to Vin Fletcher's Arrow Shop";
}

// Menu items for the arrow shop
Arrow GetArrowMenu()
{
    Console.WriteLine("What arrow do you want?");
    Console.WriteLine("1-elite, 2-beginner, 3-marksman or custom?");
    int arrowMenu = Convert.ToInt32(Console.ReadLine());
    
    return arrowMenu switch
    {
        1 => Arrow.CreateEliteArrow(),
        2 => Arrow.CreateBeginnerArrow(),
        3 => Arrow.CreateMarksmanArrow(),
        _ => GetArrow(),
    };
}


int GetArrowLength()
{
    Console.WriteLine("What length do you want your arrow? Please choose between 60cm and 100cm:");
    int arrowLength = Convert.ToInt32(Console.ReadLine());
    if (arrowLength is >= 60 and <= 100)
    {
        return arrowLength;
    }

    Console.WriteLine("Please choose between 60cm and 100cm");
    arrowLength = Convert.ToInt32(Console.ReadLine());
    return arrowLength;
   
}
Fletching GetFletching()
{
    Console.WriteLine("What fletching do you want?");
    Console.WriteLine("plastic, turkey, goose?");
    string fletching = Console.ReadLine();
    return fletching switch
    {
        "plastic" => Fletching.plastic,
        "turkey" => Fletching.turkey,
        "goose" => Fletching.goose,
    };
}
ArrowHead GetArrowHead()
{
    Console.WriteLine("What arrow head do you want?");
    Console.WriteLine("steel, wood, obsidian?");
    string arrowHead = Console.ReadLine();
    return arrowHead switch
    {
        "steel" => ArrowHead.steel,
        "wood" => ArrowHead.wood,
        "obsidian" => ArrowHead.obsidian,
    };
}

;

class Arrow
{
    private ArrowHead arrowHead { get; }
    private Fletching fletching { get; }
    private int arrowLength { get; }
    
    public Arrow(ArrowHead arrowHead, Fletching fletching, int arrowLength)
    {
        this.arrowHead = arrowHead;
        this.fletching = fletching;
        this.arrowLength = arrowLength;
    }
    

    public float GetCost()
    {
        float arrowHeadCost = arrowHead switch
        {
            ArrowHead.steel => 10,
            ArrowHead.wood => 3,
            ArrowHead.obsidian => 5,
        };
        
        float fletchingCost = fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkey => 5,
            Fletching.goose => 3,
        };

        float shaftCost = arrowLength * 0.5f;
        
        return arrowHeadCost + fletchingCost + shaftCost;
    }
    
    // Static Methods To Create Specific Arrows
    public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.steel, Fletching.plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.wood, Fletching.goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.steel, Fletching.goose, 65);

}

enum ArrowHead
{
    steel,
    wood,
    obsidian
}

enum Fletching
{
    plastic,
    turkey,
    goose
}






// THEORY LEVEL 18

// Score score = new Score("R2-D2", 12420, 8);
//
// if(score.EarnedStars())
//     Console.WriteLine($"{score.name} have earned stars");
//
// //if(b.EarnedStars())
//   //  Console.WriteLine($"{b.name} have earned stars");
//
// class Score
// {
//     public string name;
//     public int points;
//     public int level;
//
//     public Score(string name, int points, int level)
//     {
//         this.name = name;
//         this.points = points;
//         this.level = level;
//     }
//
//     public bool EarnedStars() => (points / level) > 1000;
// }