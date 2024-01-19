using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotatnikApp
{
    public partial class OpenDialog : Form
    {
        public string fileName { get { return browseTextBox1.Text; } }
        public bool empty = true;
        public OpenDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (empty == false)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                FileError(1);
            }
        }

        void FileError(int errorNum)
        {
            if(errorNum == 1)
            {
                MessageBox.Show("Błąd, wybierz plik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(errorNum == 2) 
            {
                MessageBox.Show("Błąd, wybierz poprawny plik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Wybierz plik";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "Wszystkie pliki (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            { browseTextBox1.Text = openFileDialog1.FileName; 
                string filepath = openFileDialog1.FileName;
                empty = false;
            }
            else
            {
                FileError(1);
            }
        }
    }
}
