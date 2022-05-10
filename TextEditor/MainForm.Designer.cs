namespace TextEditor
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
            this.FilePathTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FontNum = new System.Windows.Forms.NumericUpDown();
            this.ContentFld = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolCountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FontNum)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathTxtBox
            // 
            this.FilePathTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathTxtBox.Location = new System.Drawing.Point(109, 12);
            this.FilePathTxtBox.Name = "FilePathTxtBox";
            this.FilePathTxtBox.Size = new System.Drawing.Size(178, 23);
            this.FilePathTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectBtn.Location = new System.Drawing.Point(293, 12);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectBtn.TabIndex = 2;
            this.SelectBtn.Text = "Выбрать";
            this.SelectBtn.UseVisualStyleBackColor = true;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenBtn.Location = new System.Drawing.Point(374, 12);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 3;
            this.OpenBtn.Text = "Открыть";
            this.OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FontNum
            // 
            this.FontNum.Location = new System.Drawing.Point(77, 41);
            this.FontNum.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.FontNum.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.FontNum.Name = "FontNum";
            this.FontNum.Size = new System.Drawing.Size(120, 23);
            this.FontNum.TabIndex = 5;
            this.FontNum.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // ContentFld
            // 
            this.ContentFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentFld.Location = new System.Drawing.Point(11, 82);
            this.ContentFld.Multiline = true;
            this.ContentFld.Name = "ContentFld";
            this.ContentFld.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ContentFld.Size = new System.Drawing.Size(519, 197);
            this.ContentFld.TabIndex = 6;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(455, 294);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SymbolCountLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(542, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Количество символов";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // SymbolCountLbl
            // 
            this.SymbolCountLbl.Name = "SymbolCountLbl";
            this.SymbolCountLbl.Size = new System.Drawing.Size(10, 17);
            this.SymbolCountLbl.Text = " ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ContentFld);
            this.Controls.Add(this.FontNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePathTxtBox);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.FontNum)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FilePathTxtBox;
        private Label label1;
        private Button SelectBtn;
        private Button OpenBtn;
        private Label label2;
        private NumericUpDown FontNum;
        private TextBox ContentFld;
        private Button SaveBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel SymbolCountLbl;
    }
}