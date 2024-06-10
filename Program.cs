using Assignment6._1._1WithoutKeyValuePair.Controls.Classes;

namespace Assignment6._1._1WithoutKeyValuePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool addHouse = true;
            string userInput = "";

            var houseList = new SingleLinkedList();

            do
            {
                House newHouse = new House(houseList);
                houseList.InsertLast(houseList, newHouse);
                
                Console.WriteLine("Would you like to add another house to the list? Enter Y or N");
                userInput = Console.ReadLine().Trim().ToUpper();
                
                if (userInput == "Y")
                {
                    addHouse = true;
                }
                else if (userInput == "N")
                {
                    addHouse = false;
                }
            } while (addHouse != false);

            userInput = "";

            do
            {
                Console.WriteLine("Please enter the street number of the house for which you would like information.");
                userInput = Console.ReadLine().Trim();
            }while (userInput == "");

            int houseNumber = Convert.ToInt32(userInput);

            houseList.PrintUserSelectedHouseInformation(houseList, houseNumber);
        }
    }
}
