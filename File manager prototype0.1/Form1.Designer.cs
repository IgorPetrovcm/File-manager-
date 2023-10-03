namespace File_manager_prototype0._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditingPath = new System.Windows.Forms.TextBox();
            this.BoxFolderManager = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturnToFolder = new System.Windows.Forms.Button();
            this.btnRemovePartOfPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.drivesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditingPath
            // 
            this.EditingPath.Location = new System.Drawing.Point(16, 34);
            this.EditingPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditingPath.Multiline = true;
            this.EditingPath.Name = "EditingPath";
            this.EditingPath.Size = new System.Drawing.Size(496, 24);
            this.EditingPath.TabIndex = 0;
            // 
            // BoxFolderManager
            // 
            this.BoxFolderManager.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFolderManager.FormattingEnabled = true;
            this.BoxFolderManager.ItemHeight = 21;
            this.BoxFolderManager.Location = new System.Drawing.Point(16, 140);
            this.BoxFolderManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxFolderManager.Name = "BoxFolderManager";
            this.BoxFolderManager.Size = new System.Drawing.Size(312, 172);
            this.BoxFolderManager.TabIndex = 1;
            this.BoxFolderManager.SelectedIndexChanged += new System.EventHandler(this.BoxFolderManager_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(332, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturnToFolder
            // 
            this.btnReturnToFolder.Location = new System.Drawing.Point(477, 6);
            this.btnReturnToFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnToFolder.Name = "btnReturnToFolder";
            this.btnReturnToFolder.Size = new System.Drawing.Size(36, 27);
            this.btnReturnToFolder.TabIndex = 3;
            this.btnReturnToFolder.Text = "<<";
            this.btnReturnToFolder.UseVisualStyleBackColor = true;
            this.btnReturnToFolder.Click += new System.EventHandler(this.btnReturnToFolder_Click);
            // 
            // btnRemovePartOfPath
            // 
            this.btnRemovePartOfPath.Location = new System.Drawing.Point(433, 5);
            this.btnRemovePartOfPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePartOfPath.Name = "btnRemovePartOfPath";
            this.btnRemovePartOfPath.Size = new System.Drawing.Size(36, 28);
            this.btnRemovePartOfPath.TabIndex = 5;
            this.btnRemovePartOfPath.Text = "<";
            this.btnRemovePartOfPath.UseVisualStyleBackColor = true;
            this.btnRemovePartOfPath.Click += new System.EventHandler(this.btnRemovePartOfPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Found files";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(337, 252);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(100, 28);
            this.btnReadFile.TabIndex = 8;
            this.btnReadFile.Text = "Read file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(337, 217);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 28);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // drivesBox
            // 
            this.drivesBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivesBox.FormattingEnabled = true;
            this.drivesBox.Location = new System.Drawing.Point(16, 66);
            this.drivesBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drivesBox.Name = "drivesBox";
            this.drivesBox.Size = new System.Drawing.Size(79, 26);
            this.drivesBox.TabIndex = 10;
            this.drivesBox.SelectedIndexChanged += new System.EventHandler(this.drivesBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Drives";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drivesBox);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemovePartOfPath);
            this.Controls.Add(this.btnReturnToFolder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.BoxFolderManager);
            this.Controls.Add(this.EditingPath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadInBox);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditingPath;
        private System.Windows.Forms.ListBox BoxFolderManager;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturnToFolder;
        private System.Windows.Forms.Button btnRemovePartOfPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox drivesBox;
        private System.Windows.Forms.Label label3;
    }
}

