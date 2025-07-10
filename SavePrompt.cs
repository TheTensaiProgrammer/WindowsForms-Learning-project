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
    public partial class SavePrompt : Form
    {
        internal SavePrompt(Tree tree, Hash_Table hash)
        {
            InitializeComponent();
            UserInput.Click += (sender, EventArgs) => { UserInput_Click(sender, EventArgs, hash); };
            ShopInput.Click += (sender, EventArgs) => { ShopInput_Click(sender, EventArgs, tree); };
        }

        private void UserInput_Click(object sender, EventArgs e, Hash_Table hash)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filelocation = saveFileDialog1.FileName;
                hash.Save(filelocation);
            }
        }
        private void UserInput_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ShopInput_Click(object sender, EventArgs e, Tree tree)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filelocation = saveFileDialog1.FileName;
                tree.Save(tree._root, filelocation);
            }
        }
        private void ShopInput_Click_1(object sender, EventArgs e)
        {

        }
    }
}
