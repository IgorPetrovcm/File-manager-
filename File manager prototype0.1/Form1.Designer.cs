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
            this.pathBox1 = new System.Windows.Forms.TextBox();
            this.filesBox = new System.Windows.Forms.ListBox();
            this.btnSearchbyPath = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnPathBack = new System.Windows.Forms.Button();
            this.cmbDrivesListBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pathBox1
            // 
            this.pathBox1.Location = new System.Drawing.Point(13, 49);
            this.pathBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pathBox1.Multiline = true;
            this.pathBox1.Name = "pathBox1";
            this.pathBox1.Size = new System.Drawing.Size(496, 24);
            this.pathBox1.TabIndex = 0;
            // 
            // filesBox
            // 
            this.filesBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesBox.FormattingEnabled = true;
            this.filesBox.ItemHeight = 21;
            this.filesBox.Location = new System.Drawing.Point(13, 165);
            this.filesBox.Margin = new System.Windows.Forms.Padding(4);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(312, 172);
            this.filesBox.TabIndex = 1;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.filesBox_SelectedIndexChanged);
            this.filesBox.DoubleClick += new System.EventHandler(this.filesBox_DoubleClick);
            // 
            // btnSearchbyPath
            // 
            this.btnSearchbyPath.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbyPath.Location = new System.Drawing.Point(16, 81);
            this.btnSearchbyPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchbyPath.Name = "btnSearchbyPath";
            this.btnSearchbyPath.Size = new System.Drawing.Size(93, 27);
            this.btnSearchbyPath.TabIndex = 2;
            this.btnSearchbyPath.Text = "Search";
            this.btnSearchbyPath.UseVisualStyleBackColor = true;
            this.btnSearchbyPath.Click += new System.EventHandler(this.btnSearchbyPath_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(468, 80);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(36, 27);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "<<";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnPathBack
            // 
            this.btnPathBack.Location = new System.Drawing.Point(424, 80);
            this.btnPathBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnPathBack.Name = "btnPathBack";
            this.btnPathBack.Size = new System.Drawing.Size(36, 28);
            this.btnPathBack.TabIndex = 5;
            this.btnPathBack.Text = "<";
            this.btnPathBack.UseVisualStyleBackColor = true;
            this.btnPathBack.Click += new System.EventHandler(this.btnPathBack_Click);
            // 
            // cmbDrivesListBox
            // 
            this.cmbDrivesListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrivesListBox.FormattingEnabled = true;
            this.cmbDrivesListBox.Location = new System.Drawing.Point(13, 13);
            this.cmbDrivesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrivesListBox.Name = "cmbDrivesListBox";
            this.cmbDrivesListBox.Size = new System.Drawing.Size(57, 26);
            this.cmbDrivesListBox.TabIndex = 10;
            this.cmbDrivesListBox.SelectedIndexChanged += new System.EventHandler(this.cmbDrivesListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.cmbDrivesListBox);
            this.Controls.Add(this.btnPathBack);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnSearchbyPath);
            this.Controls.Add(this.filesBox);
            this.Controls.Add(this.pathBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox1;
        private System.Windows.Forms.ListBox filesBox;
        private System.Windows.Forms.Button btnSearchbyPath;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnPathBack;
        private System.Windows.Forms.ComboBox cmbDrivesListBox;
    }
}

