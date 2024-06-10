using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1WithoutKeyValuePair.Controls.Classes
{
    internal class Node
    {
        internal House house;
        internal Node next;

        public Node(House h)
        {
            house = h;
            next = null;
        }
    }
}
