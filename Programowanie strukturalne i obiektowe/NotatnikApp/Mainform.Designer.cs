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
            wklejToolStripMenuItem = new ToolStripMenuItem();
            kopiujToolStripMenuItem = new ToolStripMenuItem();
            cofnijToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            zaznaczWszystkoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            kolorCzcionkiToolStripMenuItem = new ToolStripMenuItem();
            czarnyToolStripMenuItem = new ToolStripMenuItem();
            czerwonyToolStripMenuItem = new ToolStripMenuItem();
            zielonyToolStripMenuItem = new ToolStripMenuItem();
            niebieskiToolStripMenuItem = new ToolStripMenuItem();
            innyToolStripMenuItem = new ToolStripMenuItem();
            rozmiarCzcionkiToolStripMenuItem = new ToolStripMenuItem();
            widokToolStripMenuItem = new ToolStripMenuItem();
            powiększToolStripMenuItem = new ToolStripMenuItem();
            powiększToolStripMenuItem2 = new ToolStripMenuItem();
            zmniejszToolStripMenuItem1 = new ToolStripMenuItem();
            pokażPasekDolnyToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            stworzyłMichałKopacz3CToolStripMenuItem = new ToolStripMenuItem();
            powiększToolStripMenuItem1 = new ToolStripMenuItem();
            zmniejszToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            FontStrip = new ToolStripStatusLabel();
            IloscZnakow = new ToolStripStatusLabel();
            ZoomStrip = new ToolStripStatusLabel();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            mainMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PoleNotatnik
            // 
            PoleNotatnik.BorderStyle = BorderStyle.None;
            PoleNotatnik.Dock = DockStyle.Fill;
            PoleNotatnik.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PoleNotatnik.Location = new Point(0, 24);
            PoleNotatnik.Margin = new Padding(3, 50, 3, 3);
            PoleNotatnik.Name = "PoleNotatnik";
            PoleNotatnik.Size = new Size(985, 504);
            PoleNotatnik.TabIndex = 0;
            PoleNotatnik.Text = "";
            PoleNotatnik.TextChanged += richTextBox1_TextChanged;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, formatToolStripMenuItem, widokToolStripMenuItem, pomocToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(985, 24);
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
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
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
            edycjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wklejToolStripMenuItem, kopiujToolStripMenuItem, cofnijToolStripMenuItem, toolStripMenuItem1, zaznaczWszystkoToolStripMenuItem, toolStripMenuItem3 });
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // wklejToolStripMenuItem
            // 
            wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            wklejToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            wklejToolStripMenuItem.Size = new Size(208, 22);
            wklejToolStripMenuItem.Text = "Wklej";
            // 
            // kopiujToolStripMenuItem
            // 
            kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            kopiujToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopiujToolStripMenuItem.Size = new Size(208, 22);
            kopiujToolStripMenuItem.Text = "Kopiuj";
            // 
            // cofnijToolStripMenuItem
            // 
            cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            cofnijToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cofnijToolStripMenuItem.Size = new Size(208, 22);
            cofnijToolStripMenuItem.Text = "Cofnij";
            cofnijToolStripMenuItem.Click += cofnijToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(205, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            zaznaczWszystkoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            zaznaczWszystkoToolStripMenuItem.Size = new Size(208, 22);
            zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.F5;
            toolStripMenuItem3.Size = new Size(208, 22);
            toolStripMenuItem3.Text = "Godzina";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kolorCzcionkiToolStripMenuItem, rozmiarCzcionkiToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // kolorCzcionkiToolStripMenuItem
            // 
            kolorCzcionkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { czarnyToolStripMenuItem, czerwonyToolStripMenuItem, zielonyToolStripMenuItem, niebieskiToolStripMenuItem, innyToolStripMenuItem });
            kolorCzcionkiToolStripMenuItem.Name = "kolorCzcionkiToolStripMenuItem";
            kolorCzcionkiToolStripMenuItem.Size = new Size(163, 22);
            kolorCzcionkiToolStripMenuItem.Text = "Kolor czcionki";
            // 
            // czarnyToolStripMenuItem
            // 
            czarnyToolStripMenuItem.Name = "czarnyToolStripMenuItem";
            czarnyToolStripMenuItem.Size = new Size(126, 22);
            czarnyToolStripMenuItem.Text = "Czarny";
            czarnyToolStripMenuItem.Click += czarnyToolStripMenuItem_Click;
            // 
            // czerwonyToolStripMenuItem
            // 
            czerwonyToolStripMenuItem.Name = "czerwonyToolStripMenuItem";
            czerwonyToolStripMenuItem.Size = new Size(126, 22);
            czerwonyToolStripMenuItem.Text = "Czerwony";
            czerwonyToolStripMenuItem.Click += czerwonyToolStripMenuItem_Click;
            // 
            // zielonyToolStripMenuItem
            // 
            zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            zielonyToolStripMenuItem.Size = new Size(126, 22);
            zielonyToolStripMenuItem.Text = "Zielony";
            zielonyToolStripMenuItem.Click += zielonyToolStripMenuItem_Click;
            // 
            // niebieskiToolStripMenuItem
            // 
            niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            niebieskiToolStripMenuItem.Size = new Size(126, 22);
            niebieskiToolStripMenuItem.Text = "Niebieski";
            niebieskiToolStripMenuItem.Click += niebieskiToolStripMenuItem_Click;
            // 
            // innyToolStripMenuItem
            // 
            innyToolStripMenuItem.Name = "innyToolStripMenuItem";
            innyToolStripMenuItem.Size = new Size(126, 22);
            innyToolStripMenuItem.Text = "Inny";
            innyToolStripMenuItem.Click += innyToolStripMenuItem_Click;
            // 
            // rozmiarCzcionkiToolStripMenuItem
            // 
            rozmiarCzcionkiToolStripMenuItem.Name = "rozmiarCzcionkiToolStripMenuItem";
            rozmiarCzcionkiToolStripMenuItem.Size = new Size(163, 22);
            rozmiarCzcionkiToolStripMenuItem.Text = "Rozmiar czcionki";
            rozmiarCzcionkiToolStripMenuItem.Click += rozmiarCzcionkiToolStripMenuItem_Click;
            // 
            // widokToolStripMenuItem
            // 
            widokToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { powiększToolStripMenuItem, pokażPasekDolnyToolStripMenuItem });
            widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            widokToolStripMenuItem.Size = new Size(53, 20);
            widokToolStripMenuItem.Text = "Widok";
            // 
            // powiększToolStripMenuItem
            // 
            powiększToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { powiększToolStripMenuItem2, zmniejszToolStripMenuItem1 });
            powiększToolStripMenuItem.Name = "powiększToolStripMenuItem";
            powiększToolStripMenuItem.Size = new Size(144, 22);
            powiększToolStripMenuItem.Text = "Powiększenie";
            // 
            // powiększToolStripMenuItem2
            // 
            powiększToolStripMenuItem2.Name = "powiększToolStripMenuItem2";
            powiększToolStripMenuItem2.Size = new Size(122, 22);
            powiększToolStripMenuItem2.Text = "Powiększ";
            powiększToolStripMenuItem2.Click += powiększToolStripMenuItem2_Click;
            // 
            // zmniejszToolStripMenuItem1
            // 
            zmniejszToolStripMenuItem1.Name = "zmniejszToolStripMenuItem1";
            zmniejszToolStripMenuItem1.Size = new Size(122, 22);
            zmniejszToolStripMenuItem1.Text = "Zmniejsz";
            zmniejszToolStripMenuItem1.Click += zmniejszToolStripMenuItem1_Click;
            // 
            // pokażPasekDolnyToolStripMenuItem
            // 
            pokażPasekDolnyToolStripMenuItem.Checked = true;
            pokażPasekDolnyToolStripMenuItem.CheckState = CheckState.Checked;
            pokażPasekDolnyToolStripMenuItem.Name = "pokażPasekDolnyToolStripMenuItem";
            pokażPasekDolnyToolStripMenuItem.Size = new Size(144, 22);
            pokażPasekDolnyToolStripMenuItem.Text = "Pasek Stanu";
            pokażPasekDolnyToolStripMenuItem.Click += pokażPasekDolnyToolStripMenuItem_Click;
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stworzyłMichałKopacz3CToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // stworzyłMichałKopacz3CToolStripMenuItem
            // 
            stworzyłMichałKopacz3CToolStripMenuItem.Name = "stworzyłMichałKopacz3CToolStripMenuItem";
            stworzyłMichałKopacz3CToolStripMenuItem.Size = new Size(218, 22);
            stworzyłMichałKopacz3CToolStripMenuItem.Text = "Stworzył: Michał Kopacz 3C";
            // 
            // powiększToolStripMenuItem1
            // 
            powiększToolStripMenuItem1.Name = "powiększToolStripMenuItem1";
            powiększToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // zmniejszToolStripMenuItem
            // 
            zmniejszToolStripMenuItem.Name = "zmniejszToolStripMenuItem";
            zmniejszToolStripMenuItem.Size = new Size(180, 22);
            zmniejszToolStripMenuItem.Text = "Zmniejsz";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { FontStrip, IloscZnakow, ZoomStrip });
            statusStrip1.Location = new Point(0, 504);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(985, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // FontStrip
            // 
            FontStrip.Name = "FontStrip";
            FontStrip.Size = new Size(0, 19);
            // 
            // IloscZnakow
            // 
            IloscZnakow.BorderSides = ToolStripStatusLabelBorderSides.Left;
            IloscZnakow.Name = "IloscZnakow";
            IloscZnakow.Size = new Size(4, 19);
            // 
            // ZoomStrip
            // 
            ZoomStrip.BorderSides = ToolStripStatusLabelBorderSides.Left;
            ZoomStrip.Name = "ZoomStrip";
            ZoomStrip.Size = new Size(122, 19);
            ZoomStrip.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 528);
            Controls.Add(statusStrip1);
            Controls.Add(PoleNotatnik);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notatnik";
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripMenuItem powiększToolStripMenuItem;
        private ToolStripMenuItem powiększToolStripMenuItem1;
        private ToolStripMenuItem zmniejszToolStripMenuItem;
        private ToolStripMenuItem powiększToolStripMenuItem2;
        private ToolStripMenuItem zmniejszToolStripMenuItem1;
        private ToolStripMenuItem wklejToolStripMenuItem;
        private ToolStripMenuItem kopiujToolStripMenuItem;
        private ToolStripMenuItem cofnijToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel FontStrip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private ToolStripMenuItem pokażPasekDolnyToolStripMenuItem;
        private ToolStripMenuItem stworzyłMichałKopacz3CToolStripMenuItem;
        private ToolStripStatusLabel IloscZnakow;
        private ToolStripMenuItem kolorCzcionkiToolStripMenuItem;
        private ToolStripMenuItem czarnyToolStripMenuItem;
        private ToolStripMenuItem czerwonyToolStripMenuItem;
        private ToolStripMenuItem zielonyToolStripMenuItem;
        private ToolStripMenuItem niebieskiToolStripMenuItem;
        private ToolStripMenuItem innyToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem rozmiarCzcionkiToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripStatusLabel ZoomStrip;
    }
}