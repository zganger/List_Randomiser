namespace Randomiser
{
    partial class Randomiser
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.List = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(338, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(13, 28);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(231, 82);
            this.List.TabIndex = 1;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(250, 113);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(13, 116);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(231, 20);
            this.Input.TabIndex = 3;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(250, 57);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 4;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(250, 28);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 5;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(250, 84);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 148);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.List);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Randomiser";
            this.Text = "Randomiser";
            this.Load += new System.EventHandler(this.Randomiser_Load);
            this.Click += new System.EventHandler(this.Randomiser_Click);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Remove;
    }
}

