namespace NotatnikApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
                changeFileName(Sa.fileName);
            }
        }


        void saveFile(string fileName)
        {
            string fileContent = PoleNotatnik.Text;
            //testWindow(fileContent);
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileName = Path.ChangeExtension(fileName, "txt");
            string filePath = Path.Combine(DesktopPath, fileName);
            File.WriteAllText(filePath, fileContent);
        }

        void checkIfFileExist(string filePath, string fileName)
        {
            if (File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("Czy napewno chcesz nadpisaæ plik?", "Utwórz nowy plik", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    saveFile(fileName);

                }
            }
            else
            {
                saveFile(fileName);
            }
        }

        public void changeFileName(string fileName)
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string fileName = newFileName;
            fileName = Path.ChangeExtension(fileName, "txt");
            string filePath = Path.Combine(DesktopPath, fileName);

            //checkIfFileExist(filePath, fileName);
            checkIfFileExist(filePath, fileName);
        }

        void testWindow(string info)
        {
            MessageBox.Show(info.ToString(), "Utwórz nowy plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        void openFile()
        {

        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}