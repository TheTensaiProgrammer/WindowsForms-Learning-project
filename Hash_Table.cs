using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopwithui
{
    internal class Hash_Table
    {
        //Инициализация массива
        static int Size = 15;
        Hash_Node[] Nodes = new Hash_Node[Size];
        int Hashsize = Size;
        Hash_Node[] Hash = new Hash_Node[Size];
        int[] Status = new int[Size];
        int Count = 0;

        //Change with your data file name.
        //you know what this shit useless.
        public void Read()
        {
            string fullline;
            string newtrainer;
            string newsection;
            string newprice;
            string separator = ";";
            using (StreamReader input = new StreamReader(@"..\..\..\User_data.txt", System.Text.Encoding.Default))
            {
                Size = Convert.ToInt32(input.ReadLine());
                for (int i = 0; i < Size; i++)
                {
                    newtrainer = " ";
                    newsection = " ";
                    newprice = " ";
                    fullline = " ";
                    string[] words;


                    fullline = input.ReadLine();
                    words = fullline.Split(separator);

                    newtrainer = words[0];
                    newsection = words[1];
                    newprice = words[2];

                    ConsoleAdd(newtrainer, newsection, Convert.ToInt32(newprice));
                }
            }
        }

        public void ReadManual(string filelocation)
        {
            //Hash = new Hash_Node[Hashsize];
            string fullline;
            string newtrainer;
            string newsection;
            string newprice;
            string separator = ";";
            using (StreamReader input = new StreamReader(filelocation, System.Text.Encoding.Default))
            {
                string firstline = input.ReadLine();
                bool itsint1 = int.TryParse(firstline, out int filesize);
                if (itsint1)
                {
                    Size = filesize;
                    for (int i = 0; i < Size; i++)
                    {
                        newtrainer = " ";
                        newsection = " ";
                        newprice = " ";
                        fullline = " ";
                        string[] words;


                        fullline = input.ReadLine();
                        words = fullline.Split(separator);
                        if (words.Length >= 3)
                        {
                            bool itsnotstring = string.IsNullOrEmpty(words[0]);
                            bool itsnotstring1 = string.IsNullOrEmpty(words[1]);
                            bool itsnotstring2 = string.IsNullOrEmpty(words[2]);
                            if (!itsnotstring && !itsnotstring1 && !itsnotstring2)
                            {
                                newtrainer = words[0];
                                newsection = words[1];
                                newprice = words[2];

                                bool itsint = int.TryParse(words[2], out int age);
                                if (itsint)
                                {
                                    ConsoleAdd(newtrainer, newsection, Convert.ToInt32(newprice));
                                }
                                else
                                {
                                    MessageBox.Show("Input Is Incorrect", "Error");
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Input Is Incorrect", "Error");
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input Is Incorrect", "Error");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Input Is Incorrect", "Error");
                }
            }
        }

        public void Save(string filelocation)
        {
            int actualsize = 0;
            for (int i = 0; i < Hashsize; i++)
            {
                if (Hash[i] != null)
                {
                    if (Hash[i].Section != " " && Hash[i].Price != 0 && Hash[i].Trainer != " ")
                        actualsize++;
                }

            }
            FileStream file = new FileStream(filelocation, FileMode.Create, FileAccess.Write);
            using (StreamWriter filewriter = new StreamWriter(file))
            {
                filewriter.WriteLine(actualsize);
                for (int i = 0; i < Hashsize; i++)
                {
                    if (Hash[i] != null)
                    {
                        if (Hash[i].Section != " " && Hash[i].Price != 0 && Hash[i].Trainer != " ")
                            filewriter.WriteLine(Hash[i].Section + ";" + Hash[i].Trainer + ";" + Hash[i].Price);
                    }
                        
                }
            }
        }
        private int Hash1(string n)
        {
            int k = 0;
            string h = "";
            for (int i = 0; i < n.Length; i++)
            {
                //h += Convert.ToString(Convert.ToInt32(n[i]));
                k += Convert.ToInt32(n[i]);
            }
            return k % Hashsize;
        }
        private int Collision(int x, int repeat)
        {
            return (x + repeat) % Hashsize;
        }
        public void Add(Hash_Node n)
        {
            int x = Hash1(n.Trainer);
            if (Count == Hashsize)
            {
                MessageBox.Show("Hash is full", "Error");
                return;
            }
            for (int i = 0;  i < Hashsize; i++)
            {
                if (Status[x] == 1)
                {
                    if (Hash[x].Trainer == n.Trainer)
                    {
                        MessageBox.Show("Trainer already exist", "Error");
                        return;
                    }
                }
                else if (Status[x] == 0)
                {
                    Hash[x] = n;
                    Status[x] = 1;
                    Count++;
                    return;
                }
                x = Collision(x, i + 1);
            }
        }
        public void ConsoleAdd(string trainer, string section, int price)
        {
            Hash_Node n = new Hash_Node(trainer, section, price);
            Add(n);
        }
        public Hash_Node Search(string n)
        {
            int x = Hash1(n);
            for (int i = 0; i < Hashsize; i++)
            {
                if (Status[x] == 1)
                {
                    if (Hash[x].Trainer == n)
                        return Hash[x];
                }
                else
                    return null;
                x = Collision(x, i + 1);
            }
            return null;
        }
        public void SearchAndPrint(string n, ListBox list1, ListBox list2, ListBox list3)
        {
            list1.Items.Clear();
            list2.Items.Clear();
            list3.Items.Clear();
            int x = Hash1(n);
            for (int i = 0; i < Hashsize; i++)
            {
                if (Status[x] == 1)
                {
                    if (Hash[x].Trainer == n)
                    {
                        list1.Items.Add(Hash[x].Trainer);
                        list2.Items.Add(Hash[x].Section);
                        list3.Items.Add(Hash[x].Price);
                        return;
                    }
                }
                x = Collision(x, i + 1);
            }
        }
        public void SearchPrint(string n)
        {
            Hash_Node k = Search(n);
            if (k != null)
                Console.WriteLine(k.Trainer + " " + k.Section + " " + k.Price);
        }
        public void Delete(string n, string y, int z)
        {
            int x = Hash1(n);
            for (int i = 0; i < Hashsize; i++)
            {
                if (Status[x] == 1)
                {
                    if (Hash[x].Trainer == n && Hash[x].Section == y && Hash[x].Price == z)
                    {
                        Status[x] = 0;
                        Hash[x].Trainer = "";
                        Hash[x].Section= "";
                        Hash[x].Price = 0;
                        Count--;
                    }
                }
                else
                    return;
                x = Collision(x, i + 1);
            }
        }
        public void HashPrint()
        {
            string hashout;
            int prehash, posthash, repeat;
            for (int i = 0; i < Hashsize; i++)
                if (Hash[i] != null)
                {
                    prehash = 0;
                    posthash = 0;
                    hashout = "";
                    repeat = 0;
                    if (Hash[i].Trainer != "" && Hash[i].Section != "" && Hash[i].Price != 0)
                    {
                        prehash = Hash1(Hash[i].Trainer);
                        posthash = prehash;
                        hashout += prehash;
                        while (posthash != i)
                        {
                            repeat++;
                            posthash = Collision(posthash, repeat);
                            hashout += ", " + posthash;
                        }
                        Console.WriteLine(i + ". " + Hash[i].Trainer + " " + Hash[i].Section+ " " + Hash[i].Price+ " " + Status[i] + " (" + hashout + ")");
                    }
                        
                    else
                        Console.WriteLine(i + ".");
                }
                else
                    Console.WriteLine(i + ".");
        }
        public String ReturnTrainer(int x)
        {
            if (x < Hashsize)
            {
                if (Hash[x] != null)
                    return Hash[x].Trainer;
                else
                    return "hashempty";
            }
            return "hashended";
        }
        public String ReturnSection(int x)
        {
            if (x < Hashsize)
            {
                if (Hash[x] != null)
                    return Hash[x].Section;
                else
                    return "hashempty";
            }
            return "hashended";
        }
        public int ReturnPrice(int x)
        {
            if (x < Hashsize)
            {
                if (Hash[x] != null)
                    return Hash[x].Price;
                else
                    return -2;
            }
            return -1;
        }

        public bool CheckSection(string section)
        {
            int repeat = 0;
            for(int i = 0; i < Hashsize; i++)
            {
                if (Hash[i] != null && Hash[i].Section == section)
                    repeat++;
            }
            if (repeat > 1)
                return false;
            return true;
        }

        public List<string> OutSection()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < Hashsize; i++)
            {
                if (Hash[i] != null)
                    list.Add(Hash[i].Section);
            }
            return list;
        }
    }
}
