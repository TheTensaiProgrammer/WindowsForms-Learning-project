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
    public partial class Form1 : Form
    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        internal Form1(Tree tree, Hash_Table hash, Search search)
        {
            InitializeComponent();
            PrintUserData(hash);
            PrintShopData(tree);
            button1.Click += (sender, EventArgs) => { button1_Click(sender, EventArgs, hash); };
            button2.Click += (sender, EventArgs) => { button2_Click(sender, EventArgs, tree); };
            UserEdit.Click += (sender, EventArgs) => { UserEdit_Click(sender, EventArgs, hash, tree, search); };
            UserSearch.Click += (sender, EventArgs) => { UserSearch_Click(sender, EventArgs, hash); };
            ShopSearch.Click += (sender, EventArgs) => { ShopSearch_Click(sender, EventArgs, tree); };
            EditShopData.Click += (sender, EventArgs) => { EditShopData_Click(sender, EventArgs, tree, hash, search); };
            SearchButton.Click += (sender, EventArgs) => { SearchButton_Click(sender, EventArgs, tree, hash, search); };
            OpenButton.Click += (sender, EventArgs) => { OpenButton_Click(sender, EventArgs, tree, hash); };
            Save.Click += (sender, EventArgs) => { Save_Click(sender, EventArgs, tree, hash); };
            Debug.Click += (sender, EventArgs) => { Debug_Click(sender, EventArgs, tree, hash); };
        }

        private void PrintUserData(Hash_Table hash)
        {
            string logininput = "";
            string locationinput = "";
            int ageinput = 0;
            int x = 0;
            int i = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            while (logininput != "hashended" || ageinput != -1 || locationinput != "hashended")
            {
                logininput = hash.ReturnTrainer(x);
                ageinput = hash.ReturnPrice(x);
                locationinput = hash.ReturnSection(x);
                if ((logininput != "hashempty" || ageinput != -2 || locationinput != "hashempty") && (logininput != "hashended" || ageinput != -1 || locationinput != "hashended")) 
                {
                    if (logininput != " " && ageinput != 0 && locationinput != " ")
                    {
                        listBox1.Items.Insert(i, logininput);
                        listBox2.Items.Insert(i, locationinput);
                        listBox3.Items.Insert(i, ageinput);
                        i++;
                    }
                }
                x++;
            }
        }
        private void PrintShopData(Tree tree)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            tree.StudentListOut(tree.Root, listBox4);
            tree.SectionListOut(tree.Root, listBox5);
            tree.DateListOut(tree.Root, listBox6);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, Hash_Table hash)
        {
            string logininput = "";
            string locationinput = "";
            int ageinput = 0;
            int x = 0;
            int i = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            while (logininput != "hashended" || ageinput != -1 || locationinput != "hashended")
            {
                logininput = hash.ReturnTrainer(x);
                ageinput = hash.ReturnPrice(x);
                locationinput = hash.ReturnSection(x);
                if ((logininput != "hashempty" || ageinput != -2 || locationinput != "hashempty") && (logininput != "hashended" || ageinput != -1 || locationinput != "hashended"))
                {
                    if (logininput != " " && ageinput != 0 && locationinput != " ")
                    {
                        listBox1.Items.Insert(i, logininput);
                        listBox2.Items.Insert(i, locationinput);
                        listBox3.Items.Insert(i, ageinput);
                        i++;
                    }
                }
                x++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        { }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e, Tree tree)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            tree.StudentListOut(tree.Root, listBox4);
            tree.SectionListOut(tree.Root, listBox5);
            tree.DateListOut(tree.Root, listBox6);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserEdit_Click(object sender, EventArgs e, Hash_Table hash, Tree tree, Search search)
        {
            UserEdit useredit = new UserEdit(hash, search, tree);
            useredit.Show();
        }
        private void UserEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UserSearch_Click(object sender, EventArgs e, Hash_Table hash)
        {
            string NameAsString = LoginBox.Text;
            int ageint;
            bool itsnotstring = string.IsNullOrEmpty(NameAsString);
            if (!itsnotstring)
                hash.SearchAndPrint(LoginBox.Text, listBox1, listBox2, listBox3);
            else
                MessageBox.Show("Input Is Incorrect", "Error") ;
            
        }

        private void UserSearch_Click_1(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ShopSearch_Click(object sender, EventArgs e, Tree tree)
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            string StudentAsString = StudentInput.Text;
            bool studentstring = string.IsNullOrEmpty(StudentAsString);
            if (!studentstring)
                tree.findsectionprint(StudentInput.Text, listBox4, listBox5, listBox6, 0);
            else
                MessageBox.Show("Input Is Incorrect", "Error");
        }
        private void ShopSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void EditShopData_Click(object sender, EventArgs e, Tree tree, Hash_Table hash, Search search)
        {
            ShopEdit shopedit = new ShopEdit(tree, hash, search);
            shopedit.Show();
        }
        private void EditShopData_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e, Tree tree, Hash_Table hash, Search search)
        {
            listBox9.Items.Clear();
            listBox8.Items.Clear();
            listBox7.Items.Clear();
            string NameAsString = LoginSearch.Text;
            string ProductAsString = ProductSearch.Text;
            bool itsnotstring = string.IsNullOrEmpty(NameAsString);
            bool itsnotstring2 = string.IsNullOrEmpty(ProductAsString);
            if (!itsnotstring && !itsnotstring2)
                search.Category_Search(tree, hash, ProductSearch.Text, LoginSearch.Text, listBox8, listBox7, listBox9);
            else
                MessageBox.Show("Input Is Incorrect", "Error");
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            
        }
        private void OpenButton_Click_1(object sender, EventArgs e)
        {

        }
        private void OpenButton_Click(object sender, EventArgs e, Tree tree, Hash_Table hash)
        {
            Form2 form2 = new Form2(tree, hash);
            form2.Show();
        }

        private void Save_Click(object sender, EventArgs e, Tree tree, Hash_Table hash)
        {
            SavePrompt saveprompt = new SavePrompt(tree, hash);
            saveprompt.Show();
        }
        private void Save_Click_1(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Debug_Click_1(object sender, EventArgs e)
        {

        }
        private void Debug_Click(object sender, EventArgs e, Tree tree, Hash_Table hash)
        {
            Debug debug = new Debug(tree, hash);
            debug.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
