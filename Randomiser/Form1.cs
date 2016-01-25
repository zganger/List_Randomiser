using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace Randomiser
{
    public partial class Randomiser : Form
    {
        public ArrayList list = new ArrayList();
        public Randomiser()
        {
            InitializeComponent();
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
            SaveFileDialog ExportDialog = new SaveFileDialog();
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void Input_Click(object sender, EventArgs e)
        {
            if (Input.Text == "Input") { Input.Text = ""; }
        }

        private void Randomiser_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
        }

        private void Randomiser_Load(object sender, EventArgs e)
        {
            Input.Text = "Input";
        }

        private void Import_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
            OpenFileDialog ImportDialog = new OpenFileDialog();
            if (ImportDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
            List.Items.Remove(List.SelectedItem);
            list.Remove(List.SelectedItem);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
            if (Input.Text != "" && Input.Text != "Input")
            {
                List.Items.Add(Input.Text);
                list.Add(Input.Text);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void List_Click(object sender, EventArgs e)
        {
            if (Input.Text == "") { Input.Text = "Input"; }
        }
    }
}