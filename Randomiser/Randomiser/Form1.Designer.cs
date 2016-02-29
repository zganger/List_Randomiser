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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomiser));
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Ramdomise = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.EntryBox = new System.Windows.Forms.TextBox();
            this.NewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.Location = new System.Drawing.Point(12, 12);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(237, 82);
            this.listBoxList.TabIndex = 0;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(255, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(75, 23);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(255, 41);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Ramdomise
            // 
            this.Ramdomise.Location = new System.Drawing.Point(174, 126);
            this.Ramdomise.Name = "Ramdomise";
            this.Ramdomise.Size = new System.Drawing.Size(75, 23);
            this.Ramdomise.TabIndex = 3;
            this.Ramdomise.Text = "Randomise";
            this.Ramdomise.UseVisualStyleBackColor = true;
            this.Ramdomise.Click += new System.EventHandler(this.Ramdomise_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 126);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(93, 126);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // EntryBox
            // 
            this.EntryBox.Location = new System.Drawing.Point(12, 100);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Size = new System.Drawing.Size(237, 20);
            this.EntryBox.TabIndex = 6;
            // 
            // NewList
            // 
            this.NewList.Location = new System.Drawing.Point(255, 71);
            this.NewList.Name = "NewList";
            this.NewList.Size = new System.Drawing.Size(75, 23);
            this.NewList.TabIndex = 7;
            this.NewList.Text = "New List";
            this.NewList.UseVisualStyleBackColor = true;
            this.NewList.Click += new System.EventHandler(this.NewList_Click);
            // 
            // Randomiser
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 162);
            this.Controls.Add(this.NewList);
            this.Controls.Add(this.EntryBox);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Ramdomise);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.listBoxList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randomiser";
            this.Text = "Randomiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Ramdomise;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox EntryBox;
        private System.Windows.Forms.Button NewList;
    }
}

