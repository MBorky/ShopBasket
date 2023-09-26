using BasketLibrary;
using System.Xml.Serialization;
// See https://aka.ms/new-console-template for more information
ShopManager shopManager = new ShopManager();
ShoppingCart shoppingCart = new ShoppingCart(shopManager);
string choice;
do
{
    choice = ConsoleHandlingContainer.UseMainMenu();
    switch (choice)
    {
        case "1":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList<Clothing>() + "Select the article number to add it to your basket, or press '0' to go back.");
            shoppingCart.AddToBasket(ConsoleHandlingContainer.UseBasket(), ConsoleHandlingContainer.DisplayMessage);
            break;
        case "2":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList<Electronics>() + "Select the article number to add it to your basket, or press '0' to go back.");
            shoppingCart.AddToBasket(ConsoleHandlingContainer.UseBasket(), ConsoleHandlingContainer.DisplayMessage);
            break; 
        case "3":
            ConsoleHandlingContainer.DisplayMessage(shopManager.ProductList() + "Select the article number to add it to your basket, or press '0' to go back.");
            shoppingCart.AddToBasket(ConsoleHandlingContainer.UseBasket(), ConsoleHandlingContainer.DisplayMessage);
            break;
        case "4":
            shoppingCart.RemoveFromBasket(ConsoleHandlingContainer.UseBasket(), ConsoleHandlingContainer.DisplayMessage);
            break;
        case "5":
            ConsoleHandlingContainer.DisplayMessage(shoppingCart.ShowBasket());
            break;
        case "6":
            shoppingCart.RemoveBasket(ConsoleHandlingContainer.DisplayMessage);
            break;
        case "7":
            Order order = new Order(shoppingCart);
            break;
        case "q":
            break;
        default:
            ConsoleHandlingContainer.DisplayMessage("Wrong choice");
            break;
    }
} while (choice != "q");

