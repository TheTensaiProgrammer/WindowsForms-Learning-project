using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopwithui
{
    internal class Search
    {
        public void Category_Search(Tree tree, Hash_Table hash, string product_name, string trainer, ListBox list1, ListBox list2, ListBox list3)
        {
            List<string> list = new List<string>();
            Hash_Node a = hash.Search(trainer);
            Console.WriteLine("\noutput result ------------------------------------------------------");
            list = tree.finddate(product_name, a.Section);
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine(list[i]);
                list1.Items.Insert(i,list[i]);
                list2.Items.Insert(i,a.Section);
                list3.Items.Insert(i,a.Price);
            }
        }

        public void Trainer_delete(Tree tree, Hash_Table hash, string trainer, string section, int price)
        {
            List<string> list = new List<string>();
            list = tree.outsection();
            bool last = hash.CheckSection(section);
            if (last)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == section)
                    {
                        MessageBox.Show("Cant remove teacher with section that has student", "Error");
                        return;
                    }
                }
            }
            hash.Delete(trainer, section, price);
        }

        public void Student_add(Tree tree, Hash_Table hash, string student, string section, int day, int month, int year)
        {
            List<string> list = new List<string>();
            list = hash.OutSection();
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == section)
                {
                    tree.Insert(student, section, day, month, year);
                    return;
                }    
            }
            MessageBox.Show("Cant add student without any available teacher", "Error");
            return;
        }
    }
}
