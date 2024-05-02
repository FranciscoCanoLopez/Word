using Microsoft.Office.Interop.Word;
using WordApplication = Microsoft.Office.Interop.Word.Application;

namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNselectfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                Description = "Select the folder",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.Desktop
            };
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            TXTFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTFolder.Text) || string.IsNullOrWhiteSpace(TBFileName.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar el documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            WordApplication ObjApplication = new WordApplication();
            Document ObjDocument = new Document();

            Paragraph ObjParagraph = ObjDocument.Content.Paragraphs.Add(Type.Missing);
            ObjParagraph.Range.Font.Size = 12;
            ObjParagraph.Range.Font.Color = WdColor.wdColorBlack;
            ObjParagraph.Range.Text = TBtext.Text;
            ObjParagraph.Range.InsertParagraphAfter();

            ObjDocument.SaveAs2(TXTFolder.Text + "\\" + TBFileName.Text + ".docx");
            ObjDocument.Close();
        }
    }
}
