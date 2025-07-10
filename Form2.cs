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
    public partial class Form2 : Form
    {
        internal Form2(Tree tree, Hash_Table hash)
        {
            InitializeComponent();
            UserInput.Click += (sender, EventArgs) => { UserInput_Click(sender, EventArgs, hash); };
            ShopInput.Click += (sender, EventArgs) => { ShopInput_Click(sender, EventArgs, tree); };
        }

        private void UserInput_Click_1(object sender, EventArgs e)
        {

        }
        private void UserInput_Click(object sender, EventArgs e, Hash_Table hash)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filelocation = "";
                filelocation = openFileDialog1.FileName;
                hash.ReadManual(filelocation);
            }
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ShopInput_Click(object sender, EventArgs e, Tree tree)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filelocation = "";
                filelocation = openFileDialog1.FileName;
                tree.ReadManual(filelocation);
            }
        }
        private void ShopInput_Click_1(object sender, EventArgs e)
        {

        }
    }
}
