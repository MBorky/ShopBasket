using BasketLibrary;
using System.Xml.Serialization;
// See https://aka.ms/new-console-template for more information
ShopManager shopManager = new ShopManager();
ShoppingCart shopingCart = new ShoppingCart(shopManager);
string choice;
do
{
    choice = ConsoleHandlingContainer.UseMainMenu();
    switch (choice)
    {
        case "1":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList<Clothing>() + "Select the article number to add it to your basket, or press '0' to go back.");
            break;
        case "2":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList<Electronics>() + "Select the article number to add it to your basket, or press '0' to go back.");
            break; 
        case "3":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList() + "Select the article number to add it to your basket, or press '0' to go back.");
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            Order order = new Order(shopingCart);
            break;
        case "q":
            break;
        default:
            ConsoleHandlingContainer.DisplayMessage("Wrong choice");
            break;
    }
} while (choice != "q");

