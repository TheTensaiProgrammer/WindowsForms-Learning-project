using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace shopwithui
{
    public partial class Debug : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        internal Debug(Tree tree, Hash_Table hash)
        {
            InitializeComponent();
            DebugHash.Click += (sender, EventArgs) => { DebugHash_Click(sender, EventArgs, hash); };
            DebugTrees.Click += (sender, EventArgs) => { DebugTrees_Click(sender, EventArgs, tree); };
        }

        private void DebugHash_Click(object sender, EventArgs e, Hash_Table hash)
        {
            AllocConsole();
            Console.WriteLine("Printing Hash Tables");
            Console.WriteLine("-------------------------------------");
            hash.HashPrint();
            Console.WriteLine("-------------------------------------");
        }

        private void DebugTrees_Click(object sender, EventArgs e, Tree tree)
        {
            AllocConsole();
            Console.WriteLine("Printing Trees Tables");
            Console.WriteLine("-------------------------------------");
            tree.Draw();
            Console.WriteLine("-------------------------------------");
        }

        private void DebugHash_Click_1(object sender, EventArgs e)
        {

        }

        private void DebugTrees_Click_1(object sender, EventArgs e)
        {

        }
    }
}
