using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace shopwithui
{
    class Tree
    {
        public Node _nil = new Node();
        public Node _root;
        static int Size = 0;

        public Node Root
        {
            get
            {
                return _root;
            }
        }
        public Tree()
        {

        }
        public void NilMaker()
        {
            _nil.Left = _nil;
            _nil.Parent = _nil;
            _nil.Right = _nil;
            _root = _nil;
        }
        public bool CheckDate(int day, int month, int year)
        {
            if (year < 0 || year > 2023)
                return false;
            if (month == 2)
            {
                if (day > 0 && day < 29)
                    return true;
                return false;
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 0 && day <= 31)
                    return true;
                return false;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 0 && day <= 30)
                    return true;
                return false;
            }
            return false;
        }
        public void Insert(string student, string section, int day, int month, int year)
        {
            bool ch = CheckDate(day, month, year);
            if (ch)
            {
                Students k = new Students(student, section, day, month, year);
                Node n = new Node(_nil, k, false, _nil, _nil, 1);
                InsertNode(n); 
            }
            return;
        }
        public void ReadManual(string filedate)
        {
            Clean();
            string fullline;
            string newproduct;
            string newsection;
            string newday;
            string newmonth;
            string newyear;
            string separator = ";";
            string firstline;
            using (StreamReader input = new StreamReader(filedate, System.Text.Encoding.Default))
            {
                firstline = input.ReadLine();
                bool itsint = int.TryParse(firstline, out int filesize);
                if (itsint)
                {
                    Size = filesize;
                    for (int i = 0; i < Size; i++)
                    {
                        newproduct = " ";
                        newsection = " ";
                        newday = " ";
                        newmonth = " ";
                        newyear = " ";
                        fullline = " ";
                        string[] words;

                        fullline = input.ReadLine();
                        words = fullline.Split(separator);
                        if (words.Length >= 5)
                        {
                            bool itsnotstring = string.IsNullOrEmpty(words[0]);
                            bool itsnotstring1 = string.IsNullOrEmpty(words[1]);
                            bool itsnotstring2 = string.IsNullOrEmpty(words[2]);
                            bool itsnotstring3 = string.IsNullOrEmpty(words[3]);
                            bool itsnotstring4 = string.IsNullOrEmpty(words[4]);
                            if (!itsnotstring && !itsnotstring1 && !itsnotstring2 && !itsnotstring3 && !itsnotstring4)
                            {
                                newproduct = words[0];
                                newsection = words[1];
                                newday = words[2];
                                newmonth = words[3];
                                newyear = words[4];
                                bool intcheck = int.TryParse(words[2], out int dayout);
                                bool monthcheck = int.TryParse(words[3], out int monthout);
                                bool yearcheck = int.TryParse(words[4], out int yearout);
                                if (intcheck && monthcheck && yearcheck)
                                {
                                    bool check = CheckDate(dayout, monthout, yearout);
                                    if (check)
                                    {
                                        Insert(newproduct, newsection, dayout, monthout, yearout);
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
        public void Save(Node n, string filedate)
        {
            FileStream file = new FileStream(filedate, FileMode.Create, FileAccess.Write);
            using (StreamWriter filewriter = new StreamWriter(file))
            {
                filewriter.WriteLine(Size);
                savehelper(_root, filewriter);
            } 
        }
        public void savehelper(Node n, StreamWriter name)
        {
            if (n != _nil)
            {
                Students p = n.Data;
                name.WriteLine(n.Data.Student + ";" + n.Data.Section + ";" + n.Data.Day + ";" + n.Data.Month + ";" + n.Data.Year);
                savehelper(n.Left, name);
                savehelper(n.Right, name);
            }
        }
        public void Delete(string student, string section, int day, int month, int year)
        {
            bool ch = CheckDate(day, month, year);
            if (ch)
            {
                Students k = new Students(student, section, day, month, year);
                Node n = FindNode(k);
                if (n.Data != null && (n.Data.Student == student && n.Data.Section == section && n.Data.Day == day && n.Data.Month == month && n.Data.Year == year))
                    DeleteNode(n);
            }
        }
        public bool Find(string student, string section, int day, int month, int year)
        {
            Students k = new Students(student, section, day, month, year);
            Node n = FindNode(k);
            if (n.Data != default)
                return true;
            return false;
        }
        public void Draw()
        {
            DrawHelp(_root, 0);
        }
        public void Clean()
        {
            while (_root != _nil)
            {
                DeleteNode(_root);
            }
        }
        private void LeftRotate(Node x)
        {
            Node y = x.Right;
            x.Right = y.Left;

            if (y.Left != _nil)
                y.Left.Parent = x;
            y.Parent = x.Parent;

            if (x.Parent == _nil)
                _root = y;
            else if (x == x.Parent.Left)
                x.Parent.Left = y;
            else
                x.Parent.Right = y;

            y.Left = x;
            x.Parent = y;
        }
        private void RightRotate(Node y)
        {
            Node x = y.Left;
            y.Left = x.Right;

            if (x.Right != _nil)
                x.Right.Parent = y;

            x.Parent = y.Parent;

            if (y.Parent == _nil)
                _root = x;
            else if (y == y.Parent.Right)
                y.Parent.Right = x;
            else
                y.Parent.Left = x;

            x.Right = y;
            y.Parent = x;
        }
        private bool NodeCompare(Students node1, Students node2)
        {
            if (node1 != null && node2 != null)
            {
                if (node1.Day == node2.Day && node1.Month == node2.Month && node1.Year == node2.Year && node1.Student == node2.Student
                    && node1.Section == node2.Section)
                    return true;
            }
            return false;
        }
        private void InsertNode(Node z)
        {
            if (_root != null)
            {
                Node y = _nil;
                Node x = _root;
                while (x != _nil)
                {
                    if (NodeCompare(z.Data, y.Data))
                    {
                        MessageBox.Show("Student already exist", "Error");
                        return;
                    }
                    y = x;
                    if (ProductBigger(x.Data, z.Data))
                        x = x.Left;
                    else if (ProductBigger(z.Data, x.Data))
                        x = x.Right;
                }
                z.Parent = y;
                if (y == _nil)
                    _root = z;
                else if (ProductBigger(y.Data, z.Data))  
                    y.Left = z;
                else
                    y.Right = z;
                z.Left = _nil;
                z.Right = _nil;
                z.Color = false;
                InsertFixup(z);
            }
            else
            {
                _root = z;
                _root.Color = true;
            }
        }
        private void InsertFixup(Node z)
        {
            while (z != _root && z.Parent.Color == false)
            {
                if (z.Parent == z.Parent.Parent.Left)
                {
                    Node y = z.Parent.Parent.Right;
                    if (y != null && y.Color == false)
                    {
                        z.Parent.Color = true;
                        y.Color = true;
                        z.Parent.Parent.Color = false;
                        z = z.Parent.Parent;
                    }
                    else
                    {
                        if (z == z.Parent.Right)
                        {
                            z = z.Parent;
                            LeftRotate(z);
                        }
                        z.Parent.Color = true;
                        z.Parent.Parent.Color = false;
                        RightRotate(z.Parent.Parent);
                    }
                }
                else
                {
                    Node y = z.Parent.Parent.Left;
                    if (y != null && y.Color == false)
                    {
                        z.Parent.Color = true;
                        y.Color = true;
                        z.Parent.Parent.Color = false;
                        z = z.Parent.Parent;
                    }
                    else
                    {
                        if (z == z.Parent.Left)
                        {
                            z = z.Parent;
                            RightRotate(z);
                        }
                        z.Parent.Color = true;
                        z.Parent.Parent.Color = false;
                        LeftRotate(z.Parent.Parent);
                    }
                }
            }
            _root.Color = true;
        }
        private void Transplant(Node u, Node v)
        {
            if (u.Parent == _nil)
                _root = v;
            else if (u == u.Parent.Left)
                u.Parent.Left = v;
            else
                u.Parent.Right = v;
            v.Parent = u.Parent;
        }
        private void DeleteNode(Node z)
        {
            if (z.Count > 1)
            {
                z.Count -= 1;
            }
            else
            {
                Node y = z;
                bool yColor = y.Color;
                Node x;
                if (z.Left == _nil)
                {
                    x = z.Right;
                    Transplant(z, z.Right);
                }
                else if (z.Right == _nil)
                {
                    x = z.Left;
                    Transplant(z, z.Left);
                }
                else
                {
                    y = Minimum(z.Right);
                    yColor = y.Color;
                    x = y.Right;
                    if (y.Parent == z)
                    {
                        x.Parent = y;
                    }
                    else
                    {
                        Transplant(y, y.Right);
                        y.Right = z.Right;
                        y.Right.Parent = y;
                    }
                    Transplant(z, y);
                    y.Left = z.Left;
                    y.Left.Parent = y;
                    y.Color = z.Color;
                }
                if (yColor == true)
                    DeleteFixup(x);
            }
        }
        private void DeleteFixup(Node x)
        {
            while (x != _root && x.Color == true)
            {
                if (x == x.Parent.Left)
                {
                    Node w = x.Parent.Right;
                    if (w.Color == false)
                    {
                        w.Color = true;
                        x.Parent.Color = false;
                        LeftRotate(x.Parent);
                        w = x.Parent.Right;
                    }
                    if (w.Left.Color == true && w.Right.Color == true)
                    {
                        w.Color = false;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Right.Color == true)
                        {
                            w.Left.Color = true;
                            w.Color = false;
                            RightRotate(w);
                            w = x.Parent.Right;
                        }
                        w.Color = x.Parent.Color;
                        x.Parent.Color = true;
                        w.Right.Color = true;
                        LeftRotate(x.Parent);
                        x = _root;
                    }
                }
                else
                {
                    Node w = x.Parent.Left;
                    if (w.Color == false)
                    {
                        w.Color = true;
                        x.Parent.Color = false;
                        RightRotate(x.Parent);
                        w = x.Parent.Left;
                    }
                    if (w.Left.Color == true && w.Right.Color == true)
                    {
                        w.Color = false;
                        x = x.Parent;
                    }
                    else
                    {
                        if (w.Left.Color == true)
                        {
                            w.Right.Color = true;
                            w.Color = false;
                            LeftRotate(w);
                            w = x.Parent.Left;
                        }
                        w.Color = x.Parent.Color;
                        x.Parent.Color = true;
                        w.Left.Color = true;
                        RightRotate(x.Parent);
                        x = _root;
                    }
                }
            }
            x.Color = true;
        }
        public Node FindNode(Students z)
        {
            Node n = _root;
            while ( n.Data != null && (n.Data.Student != z.Student || n.Data.Day != z.Day || n.Data.Month != z.Month || n.Data.Year != z.Year || n.Data.Section != z.Section))
            {
                if (ProductBigger(n.Data, z))                    
                    n = n.Left;
                else
                    n = n.Right;
            }
            return n;
        }
        private Students FindMinimum()
        {
            Node z = Minimum(_root);
            return z.Data;
        }
        private Node Minimum(Node z)
        {
            while (z.Left != _nil)
                z = z.Left;

            return z;
        }
        public void SectionListOut(Node n,ListBox list)
        {
            int x = 0;
            if (n != _nil)
            {
                Students p = n.Data;
                list.Items.Insert(x, p.Section);
                SectionListOut(n.Left, list);
                SectionListOut(n.Right, list);
            }
        }
        public void DateListOut(Node n, ListBox list)
        {
            int x = 0;
            if (n != _nil)
            {
                Students p = n.Data;
                String dateinsert = Convert.ToString(p.Day) + "-" + Convert.ToString(p.Month) + "-" + Convert.ToString(p.Year);
                list.Items.Insert(x, dateinsert);
                DateListOut(n.Left, list);
                DateListOut(n.Right, list);
            }
        }
        public void StudentListOut(Node n, ListBox list)
        {
            int x = 0;
            if (n != _nil)
            {
                Students p = n.Data;
                list.Items.Insert(x, p.Student);
                StudentListOut(n.Left, list);
                StudentListOut(n.Right, list);
            }
        }
        private void DrawHelp(Node root, int h)
        {
            int level = 0;
            if (root != _nil)
            {
                string colorout = "";
                Students p = root.Data;
                DrawHelp(root.Right, h + 8);
                for (int i = 0; i < h; i++)
                    Console.Write(" ");
                
                if (!root.Color)
                    colorout = "Red";
                else
                    colorout = "Black";
                Console.WriteLine(p.Student + " " + p.Section + " " + p.Day + "-" + p.Month + "-" + p.Year + ", count: " + root.Count + " " + colorout);
                DrawHelp(root.Left, h + 8);
            }
        }
        private bool ProductBigger(Students node1, Students node2)
        {
            if (node1.Student != node2.Student)
            {
                if (StringBigger(node1.Student, node2.Student))
                    return true;
                else
                    return false;
            }
            else if (node1.Section != node2.Section)
            {
                if (StringBigger(node1.Section, node2.Section))
                    return true;
                else
                    return false;
            }
            else if (node1.Year != node2.Year)
            {
                if (node1.Year > node2.Year)
                    return true;
                else
                    return false;
            }
            else if (node1.Month != node2.Month)
            {
                if (node1.Month > node2.Month)
                    return true;
                else
                    return false;
            }
            else if (node1.Day != node2.Day)
            {
                if (node1.Day > node2.Day)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        private bool StringBigger(string str1, string str2)
        {
            int intstring1 = 0;
            int intstring2 = 0;
            for (int i = 0; i < str1.Length; i++)
                intstring1 +=  Convert.ToInt32(str1[i]);
            for (int i = 0; i < str2.Length; i++)
                intstring2 += Convert.ToInt32(str2[i]);
            if (str1 != str2)
            {
                if (intstring1 > intstring2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
                return false;
        }
        public void finddatehelp(string student, string section, Node n, List<string> output)
        {
            if (n != _nil)
            {
                Students item = n.Data;
                finddatehelp(student, section, n.Left, output);
                if (n.Data.Student == student && n.Data.Section == section && n != _nil)
                {
                    string outstring = Convert.ToString(n.Data.Day) + "-" + Convert.ToString(n.Data.Month) + "-" + Convert.ToString(n.Data.Year);
                    output.Add(outstring);
                }
                finddatehelp(student, section, n.Right, output);
            }
        }
        public List<string> finddate(string student, string section)
        {
            List<string> list = new List<string>();
            finddatehelp(student, section, _root, list);
            return list;
        }
        public List<string> outsection()
        {
            List<string> list = new List<string>();
            outsectionhelp(_root, list);
            return list;
        }
        public void outsectionhelp(Node n, List<string> output)
        {
            if (n != _nil)
            {
                Students item = n.Data;
                outsectionhelp(n.Left, output);
                output.Add(n.Data.Section);
                outsectionhelp(n.Right, output);
            } 
        }
        public void findsectionprint(string student, ListBox list1, ListBox list2, ListBox list3,int x)
        {
            fsphelper(student,_root,list1,list2,list3,x);
        }
        public void fsphelper(string student, Node n, ListBox list1, ListBox list2, ListBox list3,int x)
        {
            if (n != _nil)
            {
                Students item = n.Data;
                fsphelper(student, n.Left, list1, list2, list3, x);
                if (n.Data.Student == student && n != _nil)
                {
                    string outstring = Convert.ToString(n.Data.Day) + "-" + Convert.ToString(n.Data.Month) + "-" + Convert.ToString(n.Data.Year);
                    list2.Items.Insert(x, n.Data.Section);
                    list3.Items.Insert(x, outstring);
                    list1.Items.Insert(x, n.Data.Student);
                    x++;
                }
                fsphelper(student, n.Right, list1, list2, list3, x);
            }
        }
    }
}

