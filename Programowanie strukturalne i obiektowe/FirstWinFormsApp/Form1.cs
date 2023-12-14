namespace FirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = textBox.Text;
            float sigma = 0;
            string select = comboBoxZycie.Text;
            if (boxS.Checked)
            {
                sigma++;
            }

            if (boxW.Checked)
            {
                sigma++;
            }

            if (boxLp.Checked)
            {
                sigma--;
            }

            if (radioTak.Checked)
            {
                sigma--;
            }

            if (radioNie.Checked)
            {
                sigma++;
            }

            if (select == "Masa")
            {
                sigma--;
            }

            if (select == "Si³a")
            {
                sigma++;
            }

            if (select == "Moc")
            {
                sigma++;
            }

            if (select == "Kie³basa")
            {
                sigma--;
            }

            float sigmaPercent = (sigma / 4) * 100;
            if (sigmaPercent < 0)
            {
                sigmaPercent = 0;
            }

            if (name != "")
                MessageBox.Show($"Witaj {name}! Jesteœ Sigma w {sigmaPercent}%", "Komunikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
            else
            {
                MessageBox.Show("B³¹d, podaj imie!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            radioNie.Checked = false;
            radioTak.Checked = false;
            boxS.Checked = false;
            boxW.Checked = false;
            boxLp.Checked = false;
            textBox.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxZycie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}