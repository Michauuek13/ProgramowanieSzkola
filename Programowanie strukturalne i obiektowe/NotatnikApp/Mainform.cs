namespace NotatnikApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FontStatus();
            IloscZnakow.Text = "0 znaków";
            PoleNotatnik.ForeColor = Color.Black;
            ZoomStatus(0);
        }
        public string openedFile = "";
        public int sizeChecker = 2;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            IloscZnakow.Text = PoleNotatnik.Text.Length.ToString() + " znaków";

            FontStatus();
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
            if (openedFile != "")
            {
                fileName = Path.ChangeExtension(fileName, "txt");
                //string filePath = Path.Combine(savePath, fileName);
                File.WriteAllText(openedFile, fileContent);
            }
            else
            {
                fileName = Path.ChangeExtension(fileName, "txt");
                //string filePath = Path.Combine(savePath, fileName);
                File.WriteAllText(savePath, fileContent);
            }
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
            PoleNotatnik.Font = new System.Drawing.Font(PoleNotatnik.Font.FontFamily, PoleNotatnik.Font.Size * 2);
            sizeChecker += 1;
            this.zmniejszToolStripMenuItem1.Enabled = true;
            //FontStatus();
            ZoomStatus(sizeChecker);
            if (sizeChecker == 4)
            {
                this.powiêkszToolStripMenuItem2.Enabled = false;
            }
        }

        private void zmniejszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PoleNotatnik.Font = new System.Drawing.Font(PoleNotatnik.Font.FontFamily, PoleNotatnik.Font.Size / 2);
            sizeChecker -= 1;
            this.powiêkszToolStripMenuItem2.Enabled = true;
            //FontStatus();
            ZoomStatus(sizeChecker);
            if (sizeChecker == 0)
            {
                this.zmniejszToolStripMenuItem1.Enabled = false;
            }
        }

        void FontStatus()
        {
            double fontSizeNum = Math.Round(PoleNotatnik.Font.Size);
            FontStrip.Text = "Czcionka: " + fontSizeNum;
        }

        void ZoomStatus(int zoomNum)
        {
            ZoomStrip.Text = "Zoom: x" + (zoomNum - 2).ToString();
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
            if (poka¿PasekDolnyToolStripMenuItem.Checked == false)
            {
                statusStrip1.Show();
                poka¿PasekDolnyToolStripMenuItem.Checked = true;
                return;
            }

        }

        private void innyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                PoleNotatnik.ForeColor = selectedColor;

            }
        }

        private void czarnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleNotatnik.ForeColor = Color.Black;
        }

        private void czerwonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleNotatnik.ForeColor = Color.Red;
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleNotatnik.ForeColor = Color.Green;
        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleNotatnik.ForeColor = Color.Blue;
        }

        private void rozmiarCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
                PoleNotatnik.Font = selectedFont;
                FontStatus();
            }
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoleNotatnik.Undo();
        }
    }
}