namespace My_Test
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.textboxLogin = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.StringConnection = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxLogin
            // 
            this.textboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxLogin.Location = new System.Drawing.Point(127, 46);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(359, 26);
            this.textboxLogin.TabIndex = 2;
            this.textboxLogin.Text = "dragunova";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textboxPassword.Location = new System.Drawing.Point(127, 94);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(359, 26);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.Text = "123456789";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(127, 162);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(132, 33);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 162);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Exit";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonClear);
            this.panelMain.Controls.Add(this.buttonSignup);
            this.panelMain.Controls.Add(this.labelPassword);
            this.panelMain.Controls.Add(this.labelLogin);
            this.panelMain.Controls.Add(this.textboxLogin);
            this.panelMain.Controls.Add(this.textboxPassword);
            this.panelMain.Controls.Add(this.buttonApply);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Location = new System.Drawing.Point(128, 14);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(528, 252);
            this.panelMain.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(406, 7);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSignup
            // 
            this.buttonSignup.Location = new System.Drawing.Point(127, 216);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(359, 33);
            this.buttonSignup.TabIndex = 6;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPassword.Location = new System.Drawing.Point(20, 97);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLogin.Location = new System.Drawing.Point(53, 46);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 20);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // StringConnection
            // 
            this.StringConnection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StringConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.StringConnection.Location = new System.Drawing.Point(0, 300);
            this.StringConnection.Name = "StringConnection";
            this.StringConnection.Size = new System.Drawing.Size(779, 21);
            this.StringConnection.TabIndex = 8;
            this.StringConnection.Text = "Data Source=DESKTOP-L9KBQDS\\SERVER;Initial Catalog=Test;Integrated Security=True;" +
    "MultipleActiveResultSets=True";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 321);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.StringConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxLogin;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox StringConnection;
    }
}

