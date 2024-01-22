using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NotatnikApp
{
    public partial class SaveAs : Form
    {
        public string fileName { get { return textBox1.Text; } }
        public string saveFolder { get { return savePathTextBox.Text; } }
        public bool empty = true;
        public SaveAs()
        {
            InitializeComponent();
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            if (empty == false)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Błąd, wybierz folder zapisu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MainForm form = new MainForm();
            //string fileName = textBox1.Text;
            //form.changeFileName(fileName);
            //this.Close();
        }

        private void browsefilesButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Zapisz jako";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string saveFolder1 = dialog.SelectedPath;
                if (saveFolder != null)
                {
                    savePathTextBox.Text = saveFolder1;
                    empty = false;
                }
                else
                {
                    MessageBox.Show("Błąd, wybierz folder zapisu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
