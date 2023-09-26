using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
  /* public class MessagesEventArgs<T> : EventArgs where T : Product
    {   
        private string Message { get;}

        public MessagesEventArgs(string message)
        {
            Message = message;
        }
    }
    public static class EventMessages
    {
        public event EventHandler<MessagesEventArgs> MessageEvent;
    } */
   public static class CallbackContainer
    {
        public delegate void Callback(string message);
    }
   public static class ConsoleHandlingContainer
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static string ReadStringToLower()
        {
            string tempString = Console.ReadLine();
            return tempString.ToLower();
        }
        public static string UseMainMenu()
        {
            Console.WriteLine("1. Show clothings" +
                              "\n2. Show electronics" +
                              "\n3. Show all stuff" +
                              "\n4. Remove from basket" +
                              "\n5. Show basket" +
                              "\n6. Clear basket" +
                              "\n7. Make order" +
                              "\nq. Quit");
            return ReadStringToLower();
        }
        public static int UseBasket()
        {
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out var basket) )
                {
                    return basket;
                }
                else
                {
                    DisplayMessage("please select number");
                }
            } while (true);
                    
        }
    }
}
