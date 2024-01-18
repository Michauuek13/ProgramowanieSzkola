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
                richTextBox1.Clear();
            }

        }

        private void zamknijJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs Sa = new SaveAs();
            Sa.Show();


        }
        public void changeFileName(string newFileName)
        {
            string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = newFileName;
            fileName = Path.ChangeExtension(fileName, "txt");
            string filePath = Path.Combine(DesktopPath, fileName);
            string fileContent = richTextBox1.Text;
            if (File.Exists(filePath))
            {

            }
            else
            {

            }
            
            File.WriteAllText(filePath, fileContent);
        }
    }
}