// See https://aka.ms/new-console-template for more information
Dictionary<double, string> groceryList = new Dictionary<double, string>()
{
    {1.99, "Eggs" },
    {3.29, "Milk" },
    {1.79, "Bread" },
    {1.89, "Chips" },
    {5.99, "Chicken" },
    {7.99, "Beef" },
    {2.99, "Butter" },
    {4.59, "Olive Oil" },
};

void DisplayGroceryList(Dictionary<double, string> groceryList)
{
    Console.Clear();
    Console.WriteLine("These are the available groceries ready for order: ");
    foreach (string item in groceryList.Values)
    {
        Console.WriteLine(item);
    }
}

Console.WriteLine("Hello, welcome to the grocery store. Would you like to view the menu? (y/n)");
string menuReply = Console.ReadLine().ToLower();

if (menuReply == "y")
{
    DisplayGroceryList(groceryList);
}

Console.WriteLine("What would you like to add to your shopping list?");
string newItem = Console.ReadLine().Trim().ToLower();

List<string> shoppingList = new List<string>()
{ ""};

void AddNewShoppingItem(List<string> newItem)
{
    if (groceryList.ContainsKey(newItem)) 
    {
        shoppingList.Add(newItem);
    }
    Console.WriteLine("I'm sorry, that item is not on the menu. Please select an item from the menu. If you would like to view the menu again, please press y.");
        if (menuReply == "y")
            {
            DisplayGroceryList(groceryList);
            }
}

void DisplayShoppingList(List<string> shoppingList)
{
    Console.Clear();
    Console.WriteLine("Your shopping list contains the following items: ");
    foreach (string item in shoppingList)
    {
        Console.WriteLine(item);
    }
}

