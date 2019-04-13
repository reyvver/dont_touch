namespace My_Test
{
    partial class User_test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_test));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.results = new System.Windows.Forms.ListView();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSelect = new System.Windows.Forms.Label();
            this.Tests_list = new System.Windows.Forms.ComboBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.Controls.Add(this.buttonEdit);
            this.panelHeader.Controls.Add(this.labelUserName);
            this.panelHeader.Controls.Add(this.labelUserLogin);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Controls.Add(this.labelLogin);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 124);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(632, 86);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit profil";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserName.ForeColor = System.Drawing.Color.Green;
            this.labelUserName.Location = new System.Drawing.Point(628, 52);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(15, 20);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "-";
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserLogin.ForeColor = System.Drawing.Color.Green;
            this.labelUserLogin.Location = new System.Drawing.Point(628, 21);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(15, 20);
            this.labelUserLogin.TabIndex = 2;
            this.labelUserLogin.Text = "-";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(490, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Your name";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLogin.Location = new System.Drawing.Point(496, 21);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(83, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Your login";
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.buttonClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 486);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 47);
            this.panelFooter.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(632, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(149, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.results);
            this.panelMain.Controls.Add(this.labelSelect);
            this.panelMain.Controls.Add(this.Tests_list);
            this.panelMain.Controls.Add(this.buttonRun);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 124);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 362);
            this.panelMain.TabIndex = 2;
            // 
            // results
            // 
            this.results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnTitle,
            this.columnCount,
            this.columnTime,
            this.columnData,
            this.columnResult});
            this.results.Location = new System.Drawing.Point(16, 102);
            this.results.MultiSelect = false;
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(765, 243);
            this.results.TabIndex = 9;
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.View = System.Windows.Forms.View.Details;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "N";
            this.columnNumber.Width = 30;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTitle.Width = 140;
            // 
            // columnCount
            // 
            this.columnCount.Text = "Count";
            this.columnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCount.Width = 100;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 100;
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            this.columnData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnData.Width = 100;
            // 
            // columnResult
            // 
            this.columnResult.Text = "Result";
            this.columnResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnResult.Width = 100;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSelect.Location = new System.Drawing.Point(12, 33);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(103, 20);
            this.labelSelect.TabIndex = 5;
            this.labelSelect.Text = "Select a test";
            // 
            // Tests_list
            // 
            this.Tests_list.FormattingEnabled = true;
            this.Tests_list.Location = new System.Drawing.Point(136, 33);
            this.Tests_list.Name = "Tests_list";
            this.Tests_list.Size = new System.Drawing.Size(474, 24);
            this.Tests_list.TabIndex = 6;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(632, 34);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(149, 23);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // User_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_test";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.ComboBox Tests_list;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ColumnHeader columnResult;
    }
}