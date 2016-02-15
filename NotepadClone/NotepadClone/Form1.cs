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
            
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Filter = "Rich Text File|*.rtf";                        

        }

        private void button_file_save_Click(object sender, EventArgs e)
        {

        }

        private void button_file_exit_Click(object sender, EventArgs e)
        {
            DialogResult exitResult = 
                MessageBox.Show("Do you really want to exit", "Exit", MessageBoxButtons.YesNo);

            if (exitResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

            else
            {
             //   
            }

        }

        private void button_edit_undo_Click(object sender, EventArgs e)
        {
            TextBox_input.Undo();
            textBox_execution.Text = "Undo Action Executed";

            /*
            var temp = TextBox_input.RedoActionName;
            Console.WriteLine("action: " + temp);

            var temp2 = TextBox_input.CanRedo;
            Console.WriteLine("Can redo: " + temp2);
            */

        }

        private void button_edit_redo_Click(object sender, EventArgs e)
        {
            TextBox_input.Redo();
            textBox_execution.Text = "Redo Action Executed";

            /*
            var temp = TextBox_input.RedoActionName;
            Console.WriteLine("action: " + temp);

            var temp2 = TextBox_input.CanRedo;
            Console.WriteLine("Can redo: " + temp2);
            */ 

        }
    }
}
