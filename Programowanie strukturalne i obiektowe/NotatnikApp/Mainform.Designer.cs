namespace NotatnikApp
{
    partial class MainForm
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
            PoleNotatnik = new RichTextBox();
            mainMenu = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            zapiszJakoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            zamknijToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PoleNotatnik
            // 
            PoleNotatnik.BorderStyle = BorderStyle.None;
            PoleNotatnik.Dock = DockStyle.Fill;
            PoleNotatnik.Location = new Point(0, 24);
            PoleNotatnik.Margin = new Padding(3, 50, 3, 3);
            PoleNotatnik.Name = "PoleNotatnik";
            PoleNotatnik.Size = new Size(1038, 616);
            PoleNotatnik.TabIndex = 0;
            PoleNotatnik.Text = "";
            PoleNotatnik.TextChanged += richTextBox1_TextChanged;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, formatToolStripMenuItem, widokToolStripMenuItem, pomocToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(1038, 24);
            mainMenu.TabIndex = 1;
            mainMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyToolStripMenuItem, otwórzToolStripMenuItem, zapiszToolStripMenuItem, zapiszJakoToolStripMenuItem, toolStripSeparator1, zamknijToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            nowyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nowyToolStripMenuItem.Size = new Size(213, 22);
            nowyToolStripMenuItem.Text = "&Nowy";
            nowyToolStripMenuItem.Click += nowyToolStripMenuItem_Click;
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            otwórzToolStripMenuItem.Size = new Size(213, 22);
            otwórzToolStripMenuItem.Text = "&Otwórz";
            otwórzToolStripMenuItem.Click += otwórzToolStripMenuItem_Click;
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            zapiszToolStripMenuItem.Size = new Size(213, 22);
            zapiszToolStripMenuItem.Text = "&Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            zapiszJakoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            zapiszJakoToolStripMenuItem.Size = new Size(213, 22);
            zapiszJakoToolStripMenuItem.Text = "&Zapisz jako...";
            zapiszJakoToolStripMenuItem.Click += zapiszJakoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(210, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            zamknijToolStripMenuItem.Size = new Size(213, 22);
            zamknijToolStripMenuItem.Text = "&Zamknij";
            zamknijToolStripMenuItem.Click += zamknijToolStripMenuItem_Click;
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 20);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 640);
            Controls.Add(PoleNotatnik);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notatnik";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox PoleNotatnik;
        private MenuStrip mainMenu;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem nowyToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem widokToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}