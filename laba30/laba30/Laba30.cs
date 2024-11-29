using System.Windows.Forms;

namespace laba30
{
    public partial class Laba30 : Form
    {
        public Laba30()
        {
            InitializeComponent();
        }
        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }

        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "безымянный";
            FileTextRichTextBox.Text = "";
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OpenFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            FileTextRichTextBox.Text = fileText;
            this.Text = System.IO.Path.GetFileNameWithoutExtension(filename);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
            if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SaveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, FileTextRichTextBox.Text);
        }

        private void NightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NightThemeToolStripMenuItem.Checked)
            {
                FileTextRichTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
                FileTextRichTextBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            }
            else
            {
                FileTextRichTextBox.BackColor = System.Drawing.SystemColors.Window;
                FileTextRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }

        }

        private void Ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex1Form form = new Ex1Form();
            Navigate(this, form);
        }


    }
}
