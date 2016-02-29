using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.IO;

namespace Randomiser
{
    public partial class Randomiser : Form
    {
        public Randomiser()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Add(EntryBox.Text);
            EntryBox.Text = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Remove(listBoxList.SelectedItem);
        }

        private void NewList_Click(object sender, EventArgs e)
        {
            listBoxList.Items.Clear();
        }

        private void Ramdomise_Click(object sender, EventArgs e)
        {
            ArrayList randomList = new ArrayList();
            while(listBoxList.Items.Count > 0)
            {
                Random rnd = new Random();
                int r = rnd.Next(listBoxList.Items.Count);
                randomList.Add(listBoxList.Items[r]);
                listBoxList.Items.RemoveAt(r);
            }
            foreach (string s in randomList)
            {
                listBoxList.Items.Add(s);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            string saveLoc = "";
            SaveFileDialog BrowseDialog = new SaveFileDialog();
            if (BrowseDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveLoc.Contains(".txt"))
                {
                    saveLoc = BrowseDialog.FileName;
                }
                else
                {
                    saveLoc = BrowseDialog.FileName + ".txt";
                }
            }
            StreamWriter SaveFile = new StreamWriter(saveLoc);
            foreach (var item in listBoxList.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBoxList.Items.Clear();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBoxList.Items.Add(line);

                    }
                }
            }
        }
    }
}
