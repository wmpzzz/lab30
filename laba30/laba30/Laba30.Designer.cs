namespace laba30
{
    partial class Laba30
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
            FileMenuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem1 = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            NightThemeToolStripMenuItem = new ToolStripMenuItem();
            FileTextRichTextBox = new RichTextBox();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            Ex3ToolStripMenuItem = new ToolStripMenuItem();
            FileMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem, Ex3ToolStripMenuItem });
            FileMenuStrip.Location = new Point(0, 0);
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(800, 24);
            FileMenuStrip.TabIndex = 0;
            FileMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem1, SaveToolStripMenuItem, CloseToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(133, 22);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem1
            // 
            OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
            OpenToolStripMenuItem1.Size = new Size(133, 22);
            OpenToolStripMenuItem1.Text = "Открыть";
            OpenToolStripMenuItem1.Click += OpenToolStripMenuItem1_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(133, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(133, 22);
            CloseToolStripMenuItem.Text = "Закрыть";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NightThemeToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // NightThemeToolStripMenuItem
            // 
            NightThemeToolStripMenuItem.CheckOnClick = true;
            NightThemeToolStripMenuItem.Name = "NightThemeToolStripMenuItem";
            NightThemeToolStripMenuItem.Size = new Size(145, 22);
            NightThemeToolStripMenuItem.Text = "Ночная тема";
            NightThemeToolStripMenuItem.CheckedChanged += NightThemeToolStripMenuItem_Click;
            // 
            // FileTextRichTextBox
            // 
            FileTextRichTextBox.Dock = DockStyle.Fill;
            FileTextRichTextBox.Location = new Point(0, 24);
            FileTextRichTextBox.Name = "FileTextRichTextBox";
            FileTextRichTextBox.Size = new Size(800, 426);
            FileTextRichTextBox.TabIndex = 1;
            FileTextRichTextBox.Text = "";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // Ex3ToolStripMenuItem
            // 
            Ex3ToolStripMenuItem.Name = "Ex3ToolStripMenuItem";
            Ex3ToolStripMenuItem.Size = new Size(73, 20);
            Ex3ToolStripMenuItem.Text = "Задание 3";
            Ex3ToolStripMenuItem.Click += Ex3ToolStripMenuItem_Click;
            // 
            // Laba30
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileTextRichTextBox);
            Controls.Add(FileMenuStrip);
            MainMenuStrip = FileMenuStrip;
            Name = "Laba30";
            Text = "Лабараторная работа 30";
            FileMenuStrip.ResumeLayout(false);
            FileMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FileMenuStrip;
        private RichTextBox FileTextRichTextBox;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem1;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem NightThemeToolStripMenuItem;
        private ToolStripMenuItem Ex3ToolStripMenuItem;
    }
}
