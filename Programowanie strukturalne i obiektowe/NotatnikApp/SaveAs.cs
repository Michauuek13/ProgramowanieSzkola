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
        public SaveAs()
        {
            InitializeComponent();
        }

        private void saButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            string fileName = textBox1.Text;
            form.changeFileName(fileName);
            
            
        }
    }
}
