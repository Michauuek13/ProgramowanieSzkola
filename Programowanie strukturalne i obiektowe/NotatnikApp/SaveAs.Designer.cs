namespace NotatnikApp
{
    partial class SaveAs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            savePathTextBox = new TextBox();
            browsefilesButton = new Button();
            SuspendLayout();
            // 
            // saButton
            // 
            saButton.Location = new Point(153, 149);
            saButton.Name = "saButton";
            saButton.Size = new Size(75, 23);
            saButton.TabIndex = 0;
            saButton.Text = "Zapisz jako";
            saButton.UseVisualStyleBackColor = true;
            saButton.Click += saButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "nazwa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 46);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Podaj nazwe pliku:";
            // 
            // savePathTextBox
            // 
            savePathTextBox.Location = new Point(103, 93);
            savePathTextBox.Name = "savePathTextBox";
            savePathTextBox.Size = new Size(175, 23);
            savePathTextBox.TabIndex = 3;
            savePathTextBox.Text = "ścieżka zapisu";
            // 
            // browsefilesButton
            // 
            browsefilesButton.Location = new Point(153, 120);
            browsefilesButton.Name = "browsefilesButton";
            browsefilesButton.Size = new Size(75, 23);
            browsefilesButton.TabIndex = 4;
            browsefilesButton.Text = "Przeglądaj pliki...";
            browsefilesButton.UseVisualStyleBackColor = true;
            browsefilesButton.Click += browsefilesButton_Click;
            // 
            // SaveAs
            // 
            AcceptButton = saButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(405, 198);
            Controls.Add(browsefilesButton);
            Controls.Add(savePathTextBox);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(saButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveAs";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SaveAs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saButton;
        private TextBox textBox1;
        private Label label1;
        private TextBox savePathTextBox;
        private Button browsefilesButton;
    }
}