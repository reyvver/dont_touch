namespace My_Test
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textboxName_user = new System.Windows.Forms.MaskedTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textboxLogin = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonClear);
            this.panelMain.Controls.Add(this.textboxName_user);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.labelLogin);
            this.panelMain.Controls.Add(this.textboxLogin);
            this.panelMain.Controls.Add(this.textboxPassword);
            this.panelMain.Controls.Add(this.buttonApply);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Location = new System.Drawing.Point(25, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(528, 323);
            this.panelMain.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(413, 38);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textboxName_user
            // 
            this.textboxName_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxName_user.Location = new System.Drawing.Point(134, 94);
            this.textboxName_user.Mask = ">L.L.L<???????????????";
            this.textboxName_user.Name = "textboxName_user";
            this.textboxName_user.Size = new System.Drawing.Size(359, 26);
            this.textboxName_user.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(60, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPassword.Location = new System.Drawing.Point(27, 191);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLogin.Location = new System.Drawing.Point(60, 140);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 20);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // textboxLogin
            // 
            this.textboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxLogin.Location = new System.Drawing.Point(134, 140);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(359, 26);
            this.textboxLogin.TabIndex = 2;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxPassword.Location = new System.Drawing.Point(134, 188);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(359, 26);
            this.textboxPassword.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(134, 240);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(132, 33);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(361, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 386);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MaskedTextBox textboxName_user;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textboxLogin;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonClear;
    }
}