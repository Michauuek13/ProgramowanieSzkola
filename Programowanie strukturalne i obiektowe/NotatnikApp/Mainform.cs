namespace NotatnikApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FontStatus(PoleNotatnik.Font.Size.ToString());
            IloscZnakow.Text = "0 znaków";
        }
        public string openedFile = "";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IloscZnakow.Text = PoleNotatnik.Text.Length.ToString() + " znaków";
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz utworzyæ nowy plik?", "Utwórz nowy plik", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                PoleNotatnik.Clear();
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSaveWindow();
        }

        void showSaveWindow()
        {
            SaveAs Sa = new SaveAs();
            if (Sa.ShowDialog() == DialogResult.OK)
            {
                changeFileName(Sa.fileName, Sa.saveFolder);
            }
        }


        void saveFile(string fileName, string savePath)
        {
            string fileContent = PoleNotatnik.Text;
            //testWindow(fileContent);
            
            fileName = Path.ChangeExtension(fileName, "txt");
            //string filePath = Path.Combine(savePath, fileName);
            File.WriteAllText(savePath, fileContent);
        }

        void checkIfFileExist(string filePath, string fileName)
        {
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("Czy napewno chcesz nadpisaæ plik?", "Utwórz nowy plik", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    saveFile(fileName, filePath);
                }
            }
            else
            {
                saveFile(fileName, filePath);
            }
        }

        public void changeFileName(string fileName, string saveFolder)
        {
            string savePath = saveFolder;
            //string fileName = newFileName;
            fileName = Path.ChangeExtension(fileName, "txt");
            string filePath = Path.Combine(savePath, fileName);
            checkIfFileExist(filePath, fileName);
        }

        void testWindow(string info)
        {
            MessageBox.Show(info.ToString(), "Utwórz nowy plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog open = new OpenDialog();
            open.ShowDialog();
            if (open.DialogResult == DialogResult.OK)
            {
                openFile(open.fileName);
                openedFile = open.fileName;
                this.Text = "Notatnik - " + Path.GetFileNameWithoutExtension(open.fileName);
            }
        }

        void openFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    PoleNotatnik.Text = reader.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("B³¹d, nie znaleziono pliku", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openedFile != "")
            {
                saveFile(openedFile, "");
            }
            else
            {
                showSaveWindow();
            }
        }

        private void powiêkszToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PoleNotatnik.Font = new System.Drawing.Font(PoleNotatnik.Font.FontFamily, PoleNotatnik.Font.Size + 2);
            this.zmniejszToolStripMenuItem1.Enabled = true;
            FontStatus(PoleNotatnik.Font.Size.ToString());
            if (PoleNotatnik.Font.Size == 13)
            {
                this.powiêkszToolStripMenuItem2.Enabled = false;
            }
        }

        private void zmniejszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PoleNotatnik.Font = new System.Drawing.Font(PoleNotatnik.Font.FontFamily, PoleNotatnik.Font.Size - 2);
            this.powiêkszToolStripMenuItem2.Enabled = true;
            FontStatus(PoleNotatnik.Font.Size.ToString());
            if (PoleNotatnik.Font.Size == 5)
            {
                this.zmniejszToolStripMenuItem1.Enabled = false;
            }
        }

        void FontStatus(string fontSize)
        {
            FontStrip.Text = "Czcionka: " + fontSize;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PoleNotatnik.Text += " " + DateTime.Now.ToString();
        }

        private void poka¿PasekDolnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poka¿PasekDolnyToolStripMenuItem.Checked == true)
            {
                statusStrip1.Hide();
                poka¿PasekDolnyToolStripMenuItem.Checked = false;
                return;
            }
            if(poka¿PasekDolnyToolStripMenuItem.Checked == false)
            {
                statusStrip1.Show();
                poka¿PasekDolnyToolStripMenuItem.Checked = true;
                return;
            }

        }
    }
}