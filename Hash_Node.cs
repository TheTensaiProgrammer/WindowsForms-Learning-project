using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopwithui
{
    internal class Hash_Node
    {
        public string Section;  
        public string Trainer; 
        public int Price;
        public Hash_Node(string trainer, string section, int price)
        {
            Trainer = trainer;
            Section = section;
            Price = price;
        }
        public Hash_Node()
        {
            Trainer = "";
            Section = "";
            Price = 0;
        }
    }
}
