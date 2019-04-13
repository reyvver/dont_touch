namespace My_Test
{
    partial class Main_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_screen));
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUserStatus = new System.Windows.Forms.Label();
            this.buttonEditInf = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonManagment = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(596, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(62, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.labelUserStatus);
            this.panelHeader.Controls.Add(this.labelStatus);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 33);
            this.panelHeader.TabIndex = 1;
            // 
            // labelUserStatus
            // 
            this.labelUserStatus.AutoSize = true;
            this.labelUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUserStatus.Location = new System.Drawing.Point(664, 9);
            this.labelUserStatus.Name = "labelUserStatus";
            this.labelUserStatus.Size = new System.Drawing.Size(16, 20);
            this.labelUserStatus.TabIndex = 1;
            this.labelUserStatus.Text = "-";
            // 
            // buttonEditInf
            // 
            this.buttonEditInf.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEditInf.Location = new System.Drawing.Point(26, 67);
            this.buttonEditInf.Name = "buttonEditInf";
            this.buttonEditInf.Size = new System.Drawing.Size(226, 37);
            this.buttonEditInf.TabIndex = 2;
            this.buttonEditInf.Text = "Edit profil information";
            this.buttonEditInf.UseVisualStyleBackColor = false;
            this.buttonEditInf.Click += new System.EventHandler(this.buttonEditInf_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTest.Location = new System.Drawing.Point(26, 152);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(226, 39);
            this.buttonTest.TabIndex = 3;
            this.buttonTest.Text = "Go testing";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonManagment
            // 
            this.buttonManagment.BackColor = System.Drawing.SystemColors.Control;
            this.buttonManagment.Location = new System.Drawing.Point(26, 225);
            this.buttonManagment.Name = "buttonManagment";
            this.buttonManagment.Size = new System.Drawing.Size(226, 47);
            this.buttonManagment.TabIndex = 4;
            this.buttonManagment.Text = "Test editing";
            this.buttonManagment.UseVisualStyleBackColor = false;
            this.buttonManagment.Click += new System.EventHandler(this.buttonManagment_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.Controls.Add(this.buttonLogout);
            this.panelMain.Controls.Add(this.buttonExit);
            this.panelMain.Controls.Add(this.buttonEditInf);
            this.panelMain.Controls.Add(this.buttonManagment);
            this.panelMain.Controls.Add(this.buttonTest);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(289, 399);
            this.panelMain.TabIndex = 5;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(97, 351);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 36);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(195, 351);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackground.BackgroundImage")));
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(289, 33);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(511, 399);
            this.panelBackground.TabIndex = 6;
            // 
            // Main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_screen_FormClosed);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelUserStatus;
        private System.Windows.Forms.Button buttonEditInf;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonManagment;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogout;
    }
}