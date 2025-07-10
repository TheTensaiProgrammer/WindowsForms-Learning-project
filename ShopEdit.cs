using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopwithui
{
    public partial class ShopEdit : Form
    {
        internal ShopEdit(Tree tree, Hash_Table hash, Search search)
        {
            InitializeComponent();
            PrintShopData(tree);
            AddButton.Click += (sender, EventArgs) => { AddButton_Click(sender, EventArgs, tree, hash, search); };
            DeleteButton.Click += (sender, EventArgs) => { DeleteButton_Click(sender, EventArgs, tree); };
        }

        private void PrintShopData(Tree tree)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            tree.StudentListOut(tree.Root, listBox1);
            tree.SectionListOut(tree.Root, listBox2);
            tree.DateListOut(tree.Root, listBox3);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e, Tree tree, Hash_Table hash, Search search)
        {
            string student = StudentBox.Text;
            string section = SectionBox.Text;
            string date = DateBox.Text;
            bool itsnotstring = string.IsNullOrEmpty(student);
            bool itsnotstring2 = string.IsNullOrEmpty(section);
            bool itsnotstring3 = string.IsNullOrEmpty(date);
            if (!itsnotstring && !itsnotstring2 && !itsnotstring3)
            {
                string fullline = " ";
                string separator = "-";
                fullline = Convert.ToString(date);
                string[] words;
                words = fullline.Split(separator);
                if (words.Length >= 3)
                {
                    bool itsnotstring4 = string.IsNullOrEmpty(words[0]);
                    bool itsnotstring5 = string.IsNullOrEmpty(words[1]);
                    bool itsnotstring6 = string.IsNullOrEmpty(words[2]);
                    if (!itsnotstring6 && !itsnotstring4 && !itsnotstring5)
                    {
                        bool intcheck = int.TryParse(words[0], out int dayout);
                        bool monthcheck = int.TryParse(words[1], out int monthout);
                        bool yearcheck = int.TryParse(words[2], out int yearout);
                        if (intcheck && monthcheck && yearcheck)
                        {
                            search.Student_add(tree, hash, student, section, dayout, monthout, yearout);
                            PrintShopData(tree);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Input Is Incorrect", "Error");
        }
        private void AddButton_Click_1(object sender, EventArgs e)
        {

        }

        private void LocationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShopBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, EventArgs e, Tree tree)
        {
            string student = StudentBox.Text;
            string section = SectionBox.Text;
            string date = DateBox.Text;
            bool itsnotstring = string.IsNullOrEmpty(student);
            bool itsnotstring2 = string.IsNullOrEmpty(section);
            bool itsnotstring3 = string.IsNullOrEmpty(date);
            if (!itsnotstring && !itsnotstring2 && !itsnotstring3)
            {
                string fullline = " ";
                string separator = "-";
                fullline = Convert.ToString(date);
                string[] words;
                words = fullline.Split(separator);
                if (words.Length >= 3)
                {
                    bool itsnotstring4 = string.IsNullOrEmpty(words[0]);
                    bool itsnotstring5 = string.IsNullOrEmpty(words[1]);
                    bool itsnotstring6 = string.IsNullOrEmpty(words[2]);
                    if (!itsnotstring6 && !itsnotstring4 && !itsnotstring5)
                    {
                        bool intcheck = int.TryParse(words[0], out int dayout);
                        bool monthcheck = int.TryParse(words[1], out int monthout);
                        bool yearcheck = int.TryParse(words[2], out int yearout);
                        if (intcheck && monthcheck && yearcheck)
                        {
                            tree.Delete(student, section, dayout, monthout, yearout);
                            PrintShopData(tree);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Input Is Incorrect", "Error");
        }
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
