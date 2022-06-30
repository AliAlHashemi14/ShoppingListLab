Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    {"Bubble Gum", 0.50m },
    {"Potato Chips", 1.00m },
    {"Sprite", 1.50m },
    {"Chocolate Bar", 1.00m },
    {"Skittles", 1.00m },
    {"Coca Cola", 1.50m },
    {"Red Bull", 2.00m },
    {"Hot Cheetos", 1.00m }

};
bool isrunning = true;
List<decimal> shoppingList = new List<decimal>();

//Greet user
Console.WriteLine("Welcome to the store.");


//Do while loop for the shopping portion
do
{
    //Ask user to enter item name, provide entire stock
    Console.WriteLine(" This is what we have in stock: \nBubble Gum - $0.50\nPotato Chips - $1.00\nSprite - $1.50\nChocolate Bar - $1.00\nSkittles - $1.00\nCoca Cola - $1.50\nRed Bull - $2.00\nHot Cheetos - $1.00");
    Console.WriteLine("Please type in the name of an item you'd like to buy:");
    //take and store response
    string choice = Console.ReadLine();

    //foreach to find item and add to total price
    //foreach (KeyValuePair<string, decimal> item in menu)
    //{
    //    if (item.Key.ToLower().Trim() == choice.ToLower().Trim())
    //    {
    //        shoppingList.Add(item.Value);

    //    }

    //}

    if(menu.Keys.Contains(choice) == true)
    {
        shoppingList.Add(menu[choice]);
    }
    else
    {
        Console.WriteLine("item not found");
    }
    
    //logic to exit loop. Price shown at end of checkout
    Console.WriteLine("Would you like to continue shopping or checkout? (y/n)");
    if (Console.ReadLine().ToLower().Trim() == "y")
    {
        continue;

    }
    else
    {
        
        Console.WriteLine("Your total is: $" + shoppingList.Sum());
        Console.Read();
        isrunning = false;
    }
}
while (isrunning == true);