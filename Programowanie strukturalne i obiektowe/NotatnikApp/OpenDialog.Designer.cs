namespace NotatnikApp
{
    partial class OpenDialog
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
            browseTextBox1 = new TextBox();
            BrowserButton = new Button();
            BrowseAcceptButton = new Button();
            SuspendLayout();
            // 
            // browseTextBox1
            // 
            browseTextBox1.BorderStyle = BorderStyle.FixedSingle;
            browseTextBox1.Location = new Point(107, 50);
            browseTextBox1.Name = "browseTextBox1";
            browseTextBox1.Size = new Size(233, 23);
            browseTextBox1.TabIndex = 0;
            // 
            // BrowserButton
            // 
            BrowserButton.Location = new Point(159, 91);
            BrowserButton.Name = "BrowserButton";
            BrowserButton.Size = new Size(116, 23);
            BrowserButton.TabIndex = 1;
            BrowserButton.Text = "Przeglądaj pliki...";
            BrowserButton.UseVisualStyleBackColor = true;
            BrowserButton.Click += BrowserButton_Click;
            // 
            // BrowseAcceptButton
            // 
            BrowseAcceptButton.Location = new Point(179, 154);
            BrowseAcceptButton.Name = "BrowseAcceptButton";
            BrowseAcceptButton.Size = new Size(75, 23);
            BrowseAcceptButton.TabIndex = 2;
            BrowseAcceptButton.Text = "OK";
            BrowseAcceptButton.UseVisualStyleBackColor = true;
            BrowseAcceptButton.Click += button2_Click;
            // 
            // OpenDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 225);
            Controls.Add(BrowseAcceptButton);
            Controls.Add(BrowserButton);
            Controls.Add(browseTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpenDialog";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otwórz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox browseTextBox1;
        private Button BrowserButton;
        private Button BrowseAcceptButton;
    }
}