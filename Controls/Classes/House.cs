using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1WithoutKeyValuePair.Controls.Classes
{
    internal class House
    {
        public int HouseNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Style { get; set; }

        public House(SingleLinkedList houseList)
        {
            HouseNumber = Convert.ToInt32(GetHouseInfoFromUser("Please enter the street number of the house."));
            StreetName = GetHouseInfoFromUser("Please enter the street name of the house.");
            Style = GetHouseInfoFromUser("Please enter the style of the house.");
        }

        static string GetHouseInfoFromUser(string prompt)
        {
            string? userInput = "";
            do
            {
                Console.WriteLine(prompt);
                userInput = Console.ReadLine().Trim();
            } while (userInput == "");

            return userInput;
        }
    }
}
