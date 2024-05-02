namespace Word
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
            TBtext = new TextBox();
            BTNSave = new Button();
            button1 = new Button();
            BTNselectfolder = new Button();
            TXTFolder = new TextBox();
            TBFileName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // TBtext
            // 
            TBtext.Location = new Point(28, 126);
            TBtext.Multiline = true;
            TBtext.Name = "TBtext";
            TBtext.Size = new Size(547, 267);
            TBtext.TabIndex = 0;
            // 
            // BTNSave
            // 
            BTNSave.Font = new Font("Segoe UI", 15F);
            BTNSave.Location = new Point(624, 259);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(129, 64);
            BTNSave.TabIndex = 1;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(624, 329);
            button1.Name = "button1";
            button1.Size = new Size(129, 64);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // BTNselectfolder
            // 
            BTNselectfolder.Font = new Font("Segoe UI", 12F);
            BTNselectfolder.Location = new Point(28, 19);
            BTNselectfolder.Name = "BTNselectfolder";
            BTNselectfolder.Size = new Size(129, 41);
            BTNselectfolder.TabIndex = 3;
            BTNselectfolder.Text = "Select folder";
            BTNselectfolder.UseVisualStyleBackColor = true;
            BTNselectfolder.Click += BTNselectfolder_Click;
            // 
            // TXTFolder
            // 
            TXTFolder.Location = new Point(163, 29);
            TXTFolder.Name = "TXTFolder";
            TXTFolder.ReadOnly = true;
            TXTFolder.Size = new Size(412, 27);
            TXTFolder.TabIndex = 4;
            // 
            // TBFileName
            // 
            TBFileName.Location = new Point(163, 93);
            TBFileName.Name = "TBFileName";
            TBFileName.Size = new Size(412, 27);
            TBFileName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 93);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "filename";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 414);
            Controls.Add(label1);
            Controls.Add(TBFileName);
            Controls.Add(TXTFolder);
            Controls.Add(BTNselectfolder);
            Controls.Add(button1);
            Controls.Add(BTNSave);
            Controls.Add(TBtext);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBtext;
        private Button BTNSave;
        private Button button1;
        private Button BTNselectfolder;
        private TextBox TXTFolder;
        private TextBox TBFileName;
        private Label label1;
    }
}
