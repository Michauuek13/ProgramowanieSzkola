namespace FirstWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox = new TextBox();
            button1 = new Button();
            label = new Label();
            boxS = new CheckBox();
            boxW = new CheckBox();
            menuStrip1 = new MenuStrip();
            Sigmatesterlabal = new Label();
            radioTak = new RadioButton();
            radioNie = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            boxLp = new CheckBox();
            Reset = new Button();
            comboBoxZycie = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ScrollBar;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(51, 131);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 16);
            textBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Cross;
            button1.Location = new Point(209, 346);
            button1.Name = "button1";
            button1.Size = new Size(176, 63);
            button1.TabIndex = 1;
            button1.Text = "Sprawdź";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ControlDarkDark;
            label.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(51, 108);
            label.Name = "label";
            label.Size = new Size(82, 20);
            label.TabIndex = 2;
            label.Text = "Podaj imie";
            label.Click += label1_Click;
            // 
            // boxS
            // 
            boxS.AutoSize = true;
            boxS.BackColor = SystemColors.ControlDarkDark;
            boxS.Location = new Point(209, 202);
            boxS.Name = "boxS";
            boxS.Size = new Size(57, 19);
            boxS.TabIndex = 3;
            boxS.Text = "Siebie";
            boxS.UseVisualStyleBackColor = false;
            // 
            // boxW
            // 
            boxW.AutoSize = true;
            boxW.BackColor = SystemColors.ControlDarkDark;
            boxW.Location = new Point(277, 202);
            boxW.Name = "boxW";
            boxW.Size = new Size(84, 19);
            boxW.TabIndex = 4;
            boxW.Text = "Wszystkich";
            boxW.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(910, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // Sigmatesterlabal
            // 
            Sigmatesterlabal.BackColor = SystemColors.ControlDarkDark;
            Sigmatesterlabal.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sigmatesterlabal.Location = new Point(51, 69);
            Sigmatesterlabal.Name = "Sigmatesterlabal";
            Sigmatesterlabal.Size = new Size(183, 30);
            Sigmatesterlabal.TabIndex = 7;
            Sigmatesterlabal.Text = "Sigma tester";
            // 
            // radioTak
            // 
            radioTak.AutoSize = true;
            radioTak.BackColor = SystemColors.ControlDarkDark;
            radioTak.Location = new Point(207, 263);
            radioTak.Name = "radioTak";
            radioTak.Size = new Size(42, 19);
            radioTak.TabIndex = 8;
            radioTak.TabStop = true;
            radioTak.Text = "Tak";
            radioTak.UseVisualStyleBackColor = false;
            // 
            // radioNie
            // 
            radioNie.AutoSize = true;
            radioNie.BackColor = SystemColors.ControlDarkDark;
            radioNie.Location = new Point(277, 263);
            radioNie.Name = "radioNie";
            radioNie.Size = new Size(43, 19);
            radioNie.TabIndex = 9;
            radioNie.TabStop = true;
            radioNie.Text = "Nie";
            radioNie.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 182);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 10;
            label1.Text = "Kogo tolerujesz?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 243);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 11;
            label2.Text = "Oglądasz anime?";
            // 
            // boxLp
            // 
            boxLp.AutoSize = true;
            boxLp.BackColor = SystemColors.ControlDarkDark;
            boxLp.Location = new Point(367, 202);
            boxLp.Name = "boxLp";
            boxLp.Size = new Size(108, 19);
            boxLp.TabIndex = 12;
            boxLp.Text = "Ludzi z plastyka";
            boxLp.UseVisualStyleBackColor = false;
            // 
            // Reset
            // 
            Reset.BackColor = SystemColors.ControlDarkDark;
            Reset.Location = new Point(0, 516);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 13;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // comboBoxZycie
            // 
            comboBoxZycie.BackColor = SystemColors.WindowFrame;
            comboBoxZycie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZycie.FormattingEnabled = true;
            comboBoxZycie.Items.AddRange(new object[] { "Siła", "Masa", "Moc", "Kiełbasa" });
            comboBoxZycie.Location = new Point(210, 131);
            comboBoxZycie.Name = "comboBoxZycie";
            comboBoxZycie.Size = new Size(121, 23);
            comboBoxZycie.TabIndex = 14;
            comboBoxZycie.SelectedIndexChanged += comboBoxZycie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(210, 111);
            label3.Name = "label3";
            label3.Size = new Size(203, 17);
            label3.TabIndex = 15;
            label3.Text = "Co w życiu liczy się najbardziej?";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(910, 540);
            Controls.Add(label3);
            Controls.Add(comboBoxZycie);
            Controls.Add(Reset);
            Controls.Add(boxLp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioNie);
            Controls.Add(radioTak);
            Controls.Add(Sigmatesterlabal);
            Controls.Add(boxW);
            Controls.Add(boxS);
            Controls.Add(label);
            Controls.Add(button1);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sigma Tester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button button1;
        private Label label;
        private CheckBox boxS;
        private CheckBox boxW;
        private MenuStrip menuStrip1;
        private Label Sigmatesterlabal;
        private RadioButton radioTak;
        private RadioButton radioNie;
        private Label label1;
        private Label label2;
        private CheckBox boxLp;
        private Button Reset;
        private ComboBox comboBoxZycie;
        private Label label3;
    }
}