using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Library
{
    class Program
    {
        private static CardCatalog _cardCatalog = null;

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a file name");
            string _filename = Console.ReadLine();

            _cardCatalog = new CardCatalog(_filename);

            


            bool displayMenu = true;
            {
                while (displayMenu)
                {
                    displayMenu = MainMenu();
                }
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("1. List All Books ");
            Console.WriteLine("2. Add A Book ");
            Console.WriteLine("3. Save and Exit ");
            Console.Write("Select a Menu Option ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                _cardCatalog.ListBooks();
                return true;
            }
             else if (choice == "2") 
             {
                 _cardCatalog.AddBook();
                 return true;
             }
              else if (choice == "3")
             {
                 _cardCatalog.Save();
                 return false;
             }
            else
            {
                return true;
            }


        }
    }
}
