(Type type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");
(Type, MainIngredient, Seasoning) GetSoup()
{
    Type type = GetSoupType();
    MainIngredient mainIngredient = GetMainIngredient();
    Seasoning seasoning= GetSeasoning();
    return(type, mainIngredient, seasoning);
}
Type GetSoupType()
{
    Console.WriteLine("Choose a soup type: soup, stew, gumbo: ");
    string soupChoice = Console.ReadLine();
    return soupChoice switch
    {
        "soup" => Type.soup,
        "stew" => Type.stew,
        "gumbo" => Type.gumbo,
        _ => throw new NotImplementedException()
    };
}

MainIngredient GetMainIngredient()
{
    Console.WriteLine("Choose the main ingredient: mushrooms, chicken, carrots, potatoes");
    string ingredientChoice = Console.ReadLine();
    return ingredientChoice switch
    {
        "mushrooms" => MainIngredient.mushrooms,
        "chicken" => MainIngredient.chicken,
        "carrots" => MainIngredient.carrots,
        "potatoes" => MainIngredient.potatoes,
        _ => throw new NotImplementedException()
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet,
    };
}
//  Make a tuple variable to represent a soup composed of the three above enumeration types.

// Define enumerations for the three variations on food: type, main ingredient and seasoning.
enum Type
{
    soup,
    stew,
    gumbo
}

enum MainIngredient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum Seasoning
{
    spicy,
    salty,
    sweet

}