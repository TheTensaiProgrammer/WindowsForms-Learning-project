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
    public partial class UserEdit : Form
    {
        internal UserEdit(Hash_Table hash, Search search, Tree tree)
        {
            InitializeComponent();
            PrintUserData(hash);
            AddButton.Click += (sender, EventArgs) => { AddButton_Click(sender, EventArgs, hash); };
            DeleteButton.Click += (sender, EventArgs) => { DeleteButton_Click(sender, EventArgs, hash, tree, search); };
        }

        private void PrintUserData(Hash_Table hash)
        {
            string trainerinput = "";
            string sectioninput = "";
            int priceinput = 0;
            int x = 0;
            int i = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            while (trainerinput != "hashended" || priceinput != -1 || sectioninput != "hashended")
            {
                trainerinput = hash.ReturnTrainer(x);
                priceinput = hash.ReturnPrice(x);
                sectioninput = hash.ReturnSection(x);
                if ((trainerinput != "hashempty" || priceinput != -2 || sectioninput != "hashempty") && (trainerinput != "hashended" || priceinput != -1 || sectioninput != "hashended"))
                {
                    if (trainerinput != " " && priceinput != 0 && sectioninput != " ")
                    {
                        listBox1.Items.Insert(i, trainerinput);
                        listBox2.Items.Insert(i, sectioninput);
                        listBox3.Items.Insert(i, priceinput);
                        i++;
                    }
                }
                x++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e, Hash_Table hash)
        {
            string Age = PriceBox.Text;
            string Location = SectionBox.Text;
            string Login = TrainerBox.Text;
            bool itsint = int.TryParse(Age, out int priceint);
            bool itsnotstring = string.IsNullOrEmpty(Location);
            bool itsnotstring2 = string.IsNullOrEmpty(Login);
            if (itsint && !itsnotstring && !itsnotstring2 && priceint > 0)
            {
                Hash_Node node = new Hash_Node(TrainerBox.Text, SectionBox.Text, priceint);
                hash.Add(node);
                PrintUserData(hash);
            }
            else
                MessageBox.Show("Input Is Incorrect", "Error");
        }
        private void AddButton_Click_1(object sender, EventArgs e)
        {

        }
        private void DeleteButton_Click(object sender, EventArgs e, Hash_Table hash, Tree tree, Search search)
        {
            string price = PriceBox.Text;
            string section = SectionBox.Text;
            string trainer = TrainerBox.Text;
            bool itsint = int.TryParse(price, out int priceint);
            bool itsnotstring = string.IsNullOrEmpty(section);
            bool itsnotstring2 = string.IsNullOrEmpty(trainer);
            if (itsint && !itsnotstring && !itsnotstring2 && priceint > 0)
            {
                search.Trainer_delete(tree, hash, trainer, section, priceint);
                PrintUserData(hash);
            }
            else
                MessageBox.Show("Input Is Incorrect", "Error");
                
        }
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
