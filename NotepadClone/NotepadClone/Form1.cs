using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            
        }

        private void button_test(object sender, EventArgs e)
        {
            Console.WriteLine("Temp");
        }

        /// <summary>
        /// Creates a Fresh textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_file_new_Click(object sender, EventArgs e)
        {
            TextBox_input.Text = "";


        }

        private void button_file_open_Click(object sender, EventArgs e)
        {

        }

        private void button_file_save_Click(object sender, EventArgs e)
        {

        }

        private void button_file_exit_Click(object sender, EventArgs e)
        {

        }

       
    }
}
