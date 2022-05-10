namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            OpenBtn.Click +=  OpenBtn_Click;
            SaveBtn.Click += SaveBtn_Click;
            ContentFld.TextChanged += ContentFld_Click;
            SelectBtn.Click += SelectBtn_Click;
            FontNum.ValueChanged += FontNum_ValueChanged;

        }

        #region Проброс событий
        private void ContentFld_Click(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm реализация
        public string FilePath
        {
            get { return FilePathTxtBox.Text; }
        }

        public string Content
        {
            get { return ContentFld.Text; }
            set { ContentFld.Text = value; }
        }

        public void SetSymbolCount(int count)
        {
            SymbolCountLbl.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        #endregion

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Teкстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FilePathTxtBox.Text = dlg.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void FontNum_ValueChanged(object sender , EventArgs e)
        {
            ContentFld.Font = new Font("Calibri", (float)FontNum.Value);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}