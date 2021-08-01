using System;

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.Title = "Simulas Soups";

//Variables go here

(Type type, MainIngridient mainIngridient, Seasoning seasoning) order; // Tuple to collect the order
(Type type, MainIngridient mainIngridient, Seasoning seasoning)[] dishes = new (Type type, MainIngridient mainIngridient, Seasoning seasoning)[3]; //Array saving all the orders


//Code goes here

for (int dish = 0; dish < dishes.Length; dish++)
{
    //We ask for the order
    Console.WriteLine($"We're filling Pot {dish + 1}");
    Console.WriteLine("What kind of dish do you want? Soup, Stew or Gumbo?");
    TypeDetect(Console.ReadLine());
    Console.WriteLine("Which Main Ingridient do you want to use? Mushrooms, Chicken, Carrots or Potatoes?");
    MainIngridientDetect(Console.ReadLine());
    Console.WriteLine("And which kind of Seasoning do you want? Spicy, Sweet or Salty?");
    SeasoningDetect(Console.ReadLine());

    // We transfer the order to the array

    dishes[dish].type = order.type;
    dishes[dish].mainIngridient = order.mainIngridient;
    dishes[dish].seasoning = order.seasoning;
}

Console.Clear();

// We print the 3 Dishes we've made
Console.WriteLine("Here's whats in our Pots now: ");
for (int dish = 0; dish < dishes.Length; dish++)
{
    Console.WriteLine($"Pot Number {dish + 1}: {dishes[dish].seasoning} {dishes[dish].mainIngridient} {dishes[dish].type}");
}

//Methods go here

//Turn a type order into the type
void TypeDetect(string input)
{ 
    switch (input)
    {
        case "Soup":
            order.type = Type.soup;
            break;
        case "Stew":
            order.type = Type.stew;
            break;
        case "Gumbo":
            order.type = Type.gumbo;
            break;
        default:
            Console.WriteLine("Please use one of the provided Dishes!");
            TypeDetect(Console.ReadLine());
            break;
    }
}
//Turn a main ingridient order into a Main Ingridient
void MainIngridientDetect(string input)
{
    switch (input)
    {
        case "Mushrooms":
            order.mainIngridient = MainIngridient.mushrooms;
            break;
        case "Chicken":
            order.mainIngridient = MainIngridient.chicken;
            break;
        case "Carrots":
            order.mainIngridient = MainIngridient.carrots;
            break;
        case "Potatoes":
            order.mainIngridient = MainIngridient.potatoes;
            break;
        default:
            Console.WriteLine("Please use one of the provided Dishes!");
            MainIngridientDetect(Console.ReadLine());
            break;
    }
}
//Turn a seasoning order into Seasoning
void SeasoningDetect(string input)
{
    switch (input)
    {
        case "Spicy":
            order.seasoning = Seasoning.spicy;
            break;
        case "Salty":
            order.seasoning = Seasoning.salty;
            break;
        case "Sweet":
            order.seasoning = Seasoning.sweet;
            break;
        default:
            Console.WriteLine("Please use one of the provided Seasonings!");
            SeasoningDetect(Console.ReadLine());
            break;
    }
}

//Classes go here
enum Type
{
    soup,
    stew,
    gumbo
}
enum MainIngridient
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