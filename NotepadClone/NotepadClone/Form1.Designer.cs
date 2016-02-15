namespace NotepadClone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_input = new System.Windows.Forms.RichTextBox();
            this.button_temp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.button_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.button_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.button_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_edit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.button_edit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.button_edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.button_edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_font_type = new System.Windows.Forms.ToolStripMenuItem();
            this.button_font_size = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox_execution = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_input
            // 
            this.TextBox_input.HideSelection = false;
            this.TextBox_input.Location = new System.Drawing.Point(12, 27);
            this.TextBox_input.Name = "TextBox_input";
            this.TextBox_input.Size = new System.Drawing.Size(690, 287);
            this.TextBox_input.TabIndex = 0;
            this.TextBox_input.Text = "";
            // 
            // button_temp
            // 
            this.button_temp.Location = new System.Drawing.Point(627, 1);
            this.button_temp.Name = "button_temp";
            this.button_temp.Size = new System.Drawing.Size(75, 23);
            this.button_temp.TabIndex = 1;
            this.button_temp.Text = "Temp";
            this.button_temp.UseVisualStyleBackColor = true;
            this.button_temp.Click += new System.EventHandler(this.button_test);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_file_new,
            this.button_file_open,
            this.button_file_save,
            this.button_file_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // button_file_new
            // 
            this.button_file_new.Name = "button_file_new";
            this.button_file_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.button_file_new.Size = new System.Drawing.Size(146, 22);
            this.button_file_new.Text = "New";
            this.button_file_new.Click += new System.EventHandler(this.button_file_new_Click);
            // 
            // button_file_open
            // 
            this.button_file_open.Name = "button_file_open";
            this.button_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.button_file_open.Size = new System.Drawing.Size(146, 22);
            this.button_file_open.Text = "Open";
            this.button_file_open.Click += new System.EventHandler(this.button_file_open_Click);
            // 
            // button_file_save
            // 
            this.button_file_save.Name = "button_file_save";
            this.button_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.button_file_save.Size = new System.Drawing.Size(146, 22);
            this.button_file_save.Text = "Save";
            this.button_file_save.Click += new System.EventHandler(this.button_file_save_Click);
            // 
            // button_file_exit
            // 
            this.button_file_exit.Name = "button_file_exit";
            this.button_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.button_file_exit.Size = new System.Drawing.Size(146, 22);
            this.button_file_exit.Text = "Exit";
            this.button_file_exit.Click += new System.EventHandler(this.button_file_exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_edit_undo,
            this.button_edit_cut,
            this.button_edit_copy,
            this.button_edit_paste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // button_edit_undo
            // 
            this.button_edit_undo.Name = "button_edit_undo";
            this.button_edit_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.button_edit_undo.Size = new System.Drawing.Size(144, 22);
            this.button_edit_undo.Text = "Undo";
            // 
            // button_edit_cut
            // 
            this.button_edit_cut.Name = "button_edit_cut";
            this.button_edit_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.button_edit_cut.Size = new System.Drawing.Size(144, 22);
            this.button_edit_cut.Text = "Cut";
            // 
            // button_edit_copy
            // 
            this.button_edit_copy.Name = "button_edit_copy";
            this.button_edit_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.button_edit_copy.Size = new System.Drawing.Size(144, 22);
            this.button_edit_copy.Text = "Copy";
            // 
            // button_edit_paste
            // 
            this.button_edit_paste.Name = "button_edit_paste";
            this.button_edit_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.button_edit_paste.Size = new System.Drawing.Size(144, 22);
            this.button_edit_paste.Text = "Paste";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_font_type,
            this.button_font_size});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // button_font_type
            // 
            this.button_font_type.Name = "button_font_type";
            this.button_font_type.Size = new System.Drawing.Size(128, 22);
            this.button_font_type.Text = "Font-Type";
            // 
            // button_font_size
            // 
            this.button_font_size.Name = "button_font_size";
            this.button_font_size.Size = new System.Drawing.Size(128, 22);
            this.button_font_size.Text = "Font-Size";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_execution
            // 
            this.textBox_execution.Location = new System.Drawing.Point(378, 1);
            this.textBox_execution.Name = "textBox_execution";
            this.textBox_execution.ReadOnly = true;
            this.textBox_execution.Size = new System.Drawing.Size(243, 20);
            this.textBox_execution.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.textBox_execution);
            this.Controls.Add(this.button_temp);
            this.Controls.Add(this.TextBox_input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox_input;
        private System.Windows.Forms.Button button_temp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem button_font_type;
        private System.Windows.Forms.ToolStripMenuItem button_font_size;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button_edit_paste;
        private System.Windows.Forms.ToolStripMenuItem button_edit_copy;
        private System.Windows.Forms.ToolStripMenuItem button_edit_cut;
        private System.Windows.Forms.ToolStripMenuItem button_edit_undo;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button_file_save;
        private System.Windows.Forms.ToolStripMenuItem button_file_open;
        private System.Windows.Forms.ToolStripMenuItem button_file_new;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button_file_exit;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox_execution;
    }
}

