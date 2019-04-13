namespace My_Test
{
    partial class Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managment));
            this.panelUsers = new System.Windows.Forms.Panel();
            this.buttonEditInf = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ListView();
            this.columnNumberUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUserPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.panelTests = new System.Windows.Forms.Panel();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.tests = new System.Windows.Forms.ListView();
            this.columnNumberTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdTest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTestMinimum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteTest = new System.Windows.Forms.Button();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panelUsers.SuspendLayout();
            this.panelTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.buttonEditInf);
            this.panelUsers.Controls.Add(this.Users);
            this.panelUsers.Controls.Add(this.buttonDeleteUser);
            this.panelUsers.Controls.Add(this.buttonAddUser);
            this.panelUsers.Location = new System.Drawing.Point(34, 353);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(683, 320);
            this.panelUsers.TabIndex = 14;
            // 
            // buttonEditInf
            // 
            this.buttonEditInf.Location = new System.Drawing.Point(270, 268);
            this.buttonEditInf.Name = "buttonEditInf";
            this.buttonEditInf.Size = new System.Drawing.Size(122, 23);
            this.buttonEditInf.TabIndex = 14;
            this.buttonEditInf.Text = "Edit";
            this.buttonEditInf.UseVisualStyleBackColor = true;
            this.buttonEditInf.Click += new System.EventHandler(this.buttonEditInf_Click);
            // 
            // Users
            // 
            this.Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumberUser,
            this.columnIdUser,
            this.columnUserName,
            this.columnUserLogin,
            this.columnUserPassword});
            this.Users.FullRowSelect = true;
            this.Users.Location = new System.Drawing.Point(16, 19);
            this.Users.MultiSelect = false;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(579, 243);
            this.Users.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Users.TabIndex = 10;
            this.Users.UseCompatibleStateImageBehavior = false;
            this.Users.View = System.Windows.Forms.View.Details;
            // 
            // columnNumberUser
            // 
            this.columnNumberUser.Text = "N";
            this.columnNumberUser.Width = 30;
            // 
            // columnIdUser
            // 
            this.columnIdUser.DisplayIndex = 4;
            this.columnIdUser.Text = "id_user";
            // 
            // columnUserName
            // 
            this.columnUserName.DisplayIndex = 1;
            this.columnUserName.Text = "Name";
            this.columnUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUserName.Width = 140;
            // 
            // columnUserLogin
            // 
            this.columnUserLogin.DisplayIndex = 2;
            this.columnUserLogin.Text = "login";
            this.columnUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnUserLogin.Width = 100;
            // 
            // columnUserPassword
            // 
            this.columnUserPassword.DisplayIndex = 3;
            this.columnUserPassword.Text = "password";
            this.columnUserPassword.Width = 95;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(147, 268);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Delete a user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(16, 268);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(107, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add new user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // panelTests
            // 
            this.panelTests.Controls.Add(this.buttonAddQuestion);
            this.panelTests.Controls.Add(this.tests);
            this.panelTests.Controls.Add(this.buttonDeleteTest);
            this.panelTests.Controls.Add(this.buttonAddTest);
            this.panelTests.Location = new System.Drawing.Point(34, 17);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(490, 320);
            this.panelTests.TabIndex = 13;
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(270, 267);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(122, 23);
            this.buttonAddQuestion.TabIndex = 11;
            this.buttonAddQuestion.Text = "Add question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // tests
            // 
            this.tests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumberTest,
            this.columnIdTest,
            this.columnTitle,
            this.columnTestMinimum});
            this.tests.FullRowSelect = true;
            this.tests.Location = new System.Drawing.Point(16, 19);
            this.tests.MultiSelect = false;
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(454, 243);
            this.tests.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.tests.TabIndex = 10;
            this.tests.UseCompatibleStateImageBehavior = false;
            this.tests.View = System.Windows.Forms.View.Details;
            // 
            // columnNumberTest
            // 
            this.columnNumberTest.Text = "N";
            this.columnNumberTest.Width = 30;
            // 
            // columnIdTest
            // 
            this.columnIdTest.DisplayIndex = 3;
            this.columnIdTest.Text = "id_test";
            // 
            // columnTitle
            // 
            this.columnTitle.DisplayIndex = 1;
            this.columnTitle.Text = "Title";
            this.columnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTitle.Width = 140;
            // 
            // columnTestMinimum
            // 
            this.columnTestMinimum.DisplayIndex = 2;
            this.columnTestMinimum.Text = "Minimum";
            this.columnTestMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTestMinimum.Width = 100;
            // 
            // buttonDeleteTest
            // 
            this.buttonDeleteTest.Location = new System.Drawing.Point(147, 268);
            this.buttonDeleteTest.Name = "buttonDeleteTest";
            this.buttonDeleteTest.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteTest.TabIndex = 2;
            this.buttonDeleteTest.Text = "Delete a test";
            this.buttonDeleteTest.UseVisualStyleBackColor = true;
            this.buttonDeleteTest.Click += new System.EventHandler(this.buttonDeleteTest_Click);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(16, 268);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(107, 23);
            this.buttonAddTest.TabIndex = 1;
            this.buttonAddTest.Text = "Add new test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(553, 314);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(164, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 691);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managment";
            this.panelUsers.ResumeLayout(false);
            this.panelTests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Button buttonEditInf;
        private System.Windows.Forms.ListView Users;
        private System.Windows.Forms.ColumnHeader columnNumberUser;
        private System.Windows.Forms.ColumnHeader columnIdUser;
        private System.Windows.Forms.ColumnHeader columnUserName;
        private System.Windows.Forms.ColumnHeader columnUserLogin;
        private System.Windows.Forms.ColumnHeader columnUserPassword;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.ListView tests;
        private System.Windows.Forms.ColumnHeader columnNumberTest;
        private System.Windows.Forms.ColumnHeader columnIdTest;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnTestMinimum;
        private System.Windows.Forms.Button buttonDeleteTest;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button Exit;
    }
}