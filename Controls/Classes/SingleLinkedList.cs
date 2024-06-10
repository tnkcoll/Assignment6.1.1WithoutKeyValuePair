using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1WithoutKeyValuePair.Controls.Classes
{
    internal class SingleLinkedList
    {
        internal Node head;

        //This method creates two new nodes.
        //The first node holds the newly created newHouse object.
        //If the first node, aka "head" is null, it makes the first new node, called newNode, the head node.
        //It then creates the second node and names it "lastNode".
        //It then places the lastNode at the end of the linked list by calling the GetLastNode method.
        //Lastly, the first node that was created by this method is placed at the end of the linkedlist by assigning it to the lastNode.next variable, which is the pointer to the .
        internal void InsertLast(SingleLinkedList SingleLinkedList, House newHouse)
        {
            Node newNode = new Node(newHouse);
            if(SingleLinkedList.head == null)
            {
                SingleLinkedList.head = newNode;
                return;
            }
            Node lastNode = GetLastNode(SingleLinkedList);
            lastNode.next = newNode;
        }

        //This method iterates through the nodes of the linkedlist to find the last node.
        //temp.next is the pointer to the next node.
        //Once temp.next points to a void node, it knows it's at the last node.
        internal Node GetLastNode(SingleLinkedList SingleLinkedList)
        {
            Node temp = SingleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        //This method steps through the items in the linkedlist to find the user's house information based on the number they entered.
        internal void PrintUserSelectedHouseInformation(SingleLinkedList SingleLinkedList, int houseNumber)
        {
            Node temp = SingleLinkedList.head;
            while (temp.next != null)
            {
                if (temp.house.HouseNumber == houseNumber)
                {
                    Console.WriteLine(temp.house.HouseNumber + " " + temp.house.StreetName + ", " + temp.house.Style);
                    break;
                }
                else
                {
                    Console.WriteLine($"There isn't a house in the list with {houseNumber}.");
                }
            }
        }
    }
}
