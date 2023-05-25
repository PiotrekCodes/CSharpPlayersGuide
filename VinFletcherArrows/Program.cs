Console.WriteLine(WelcomeMessage());
Arrow arrow = GetArrow();
Console.WriteLine($"Your arrow will cost {arrow.GetCost()}");

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
    public ArrowHead arrowHead;
    public Fletching fletching;
    public int arrowLength;
    
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




// THEORY

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