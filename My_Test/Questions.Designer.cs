namespace My_Test
{
    partial class Questions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.labelChoose = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.RadioButton();
            this.answer4 = new System.Windows.Forms.RadioButton();
            this.answer2 = new System.Windows.Forms.RadioButton();
            this.answer3 = new System.Windows.Forms.RadioButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.CommonTime = new System.Windows.Forms.Label();
            this.labelCommonTime = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.RichTextBox();
            this.panelAnswes = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelQuesiton = new System.Windows.Forms.Label();
            this.Name_user = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelQuesitonCount = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelAnswes.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 500;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Location = new System.Drawing.Point(255, 13);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(153, 17);
            this.labelChoose.TabIndex = 10;
            this.labelChoose.Text = "Choose correct answer";
            // 
            // answer1
            // 
            this.answer1.AutoSize = true;
            this.answer1.Location = new System.Drawing.Point(17, 55);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(110, 21);
            this.answer1.TabIndex = 6;
            this.answer1.TabStop = true;
            this.answer1.Text = "radioButton1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.AutoSize = true;
            this.answer4.Location = new System.Drawing.Point(572, 55);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(110, 21);
            this.answer4.TabIndex = 9;
            this.answer4.TabStop = true;
            this.answer4.Text = "radioButton1";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Location = new System.Drawing.Point(194, 55);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(110, 21);
            this.answer2.TabIndex = 7;
            this.answer2.TabStop = true;
            this.answer2.Text = "radioButton1";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Location = new System.Drawing.Point(380, 55);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(110, 21);
            this.answer3.TabIndex = 8;
            this.answer3.TabStop = true;
            this.answer3.Text = "radioButton1";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.CommonTime);
            this.panelMain.Controls.Add(this.labelCommonTime);
            this.panelMain.Controls.Add(this.QuestionText);
            this.panelMain.Controls.Add(this.panelAnswes);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 451);
            this.panelMain.TabIndex = 5;
            // 
            // CommonTime
            // 
            this.CommonTime.AutoSize = true;
            this.CommonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CommonTime.Location = new System.Drawing.Point(197, 392);
            this.CommonTime.Name = "CommonTime";
            this.CommonTime.Size = new System.Drawing.Size(15, 20);
            this.CommonTime.TabIndex = 15;
            this.CommonTime.Text = "-";
            // 
            // labelCommonTime
            // 
            this.labelCommonTime.AutoSize = true;
            this.labelCommonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCommonTime.Location = new System.Drawing.Point(58, 392);
            this.labelCommonTime.Name = "labelCommonTime";
            this.labelCommonTime.Size = new System.Drawing.Size(113, 20);
            this.labelCommonTime.TabIndex = 12;
            this.labelCommonTime.Text = "Common time";
            // 
            // QuestionText
            // 
            this.QuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuestionText.Location = new System.Drawing.Point(62, 36);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(682, 164);
            this.QuestionText.TabIndex = 11;
            this.QuestionText.Text = "";
            // 
            // panelAnswes
            // 
            this.panelAnswes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAnswes.Controls.Add(this.labelChoose);
            this.panelAnswes.Controls.Add(this.answer1);
            this.panelAnswes.Controls.Add(this.answer4);
            this.panelAnswes.Controls.Add(this.answer2);
            this.panelAnswes.Controls.Add(this.answer3);
            this.panelAnswes.Location = new System.Drawing.Point(62, 232);
            this.panelAnswes.Name = "panelAnswes";
            this.panelAnswes.Size = new System.Drawing.Size(691, 100);
            this.panelAnswes.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(584, 37);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit test";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelQuesiton
            // 
            this.labelQuesiton.AutoSize = true;
            this.labelQuesiton.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelQuesiton.Location = new System.Drawing.Point(23, 24);
            this.labelQuesiton.Name = "labelQuesiton";
            this.labelQuesiton.Size = new System.Drawing.Size(81, 20);
            this.labelQuesiton.TabIndex = 6;
            this.labelQuesiton.Text = "Question ";
            // 
            // Name_user
            // 
            this.Name_user.AutoSize = true;
            this.Name_user.BackColor = System.Drawing.Color.Transparent;
            this.Name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name_user.ForeColor = System.Drawing.Color.Green;
            this.Name_user.Location = new System.Drawing.Point(659, 24);
            this.Name_user.Name = "Name_user";
            this.Name_user.Size = new System.Drawing.Size(15, 20);
            this.Name_user.TabIndex = 5;
            this.Name_user.Text = "-";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(521, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Your name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(218, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(16, 20);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "-";
            // 
            // labelQuesitonCount
            // 
            this.labelQuesitonCount.AutoSize = true;
            this.labelQuesitonCount.BackColor = System.Drawing.Color.Transparent;
            this.labelQuesitonCount.Location = new System.Drawing.Point(148, 27);
            this.labelQuesitonCount.Name = "labelQuesitonCount";
            this.labelQuesitonCount.Size = new System.Drawing.Size(13, 17);
            this.labelQuesitonCount.TabIndex = 9;
            this.labelQuesitonCount.Text = "-";
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.BackColor = System.Drawing.Color.Transparent;
            this.labelLabel.Location = new System.Drawing.Point(129, 27);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(12, 17);
            this.labelLabel.TabIndex = 8;
            this.labelLabel.Text = "/";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Location = new System.Drawing.Point(110, 27);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(13, 17);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "-";
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Controls.Add(this.labelQuesitonCount);
            this.panelHeader.Controls.Add(this.labelLabel);
            this.panelHeader.Controls.Add(this.labelNumber);
            this.panelHeader.Controls.Add(this.labelQuesiton);
            this.panelHeader.Controls.Add(this.Name_user);
            this.panelHeader.Controls.Add(this.labelName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 62);
            this.panelHeader.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(320, 35);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(160, 25);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFooter.BackgroundImage")));
            this.panelFooter.Controls.Add(this.buttonApply);
            this.panelFooter.Controls.Add(this.buttonExit);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 513);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 93);
            this.panelFooter.TabIndex = 4;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelAnswes.ResumeLayout(false);
            this.panelAnswes.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.RadioButton answer1;
        private System.Windows.Forms.RadioButton answer4;
        private System.Windows.Forms.RadioButton answer2;
        private System.Windows.Forms.RadioButton answer3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label CommonTime;
        private System.Windows.Forms.Label labelCommonTime;
        private System.Windows.Forms.RichTextBox QuestionText;
        private System.Windows.Forms.Panel panelAnswes;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelQuesiton;
        private System.Windows.Forms.Label Name_user;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelQuesitonCount;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panelFooter;
    }
}