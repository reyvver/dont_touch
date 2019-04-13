namespace My_Test
{
    partial class Creating_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creating_test));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.textboxMinimum = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(41, 233);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(139, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create new test";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(379, 67);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(226, 233);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(72, 118);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(276, 22);
            this.textboxTitle.TabIndex = 3;
            // 
            // textboxMinimum
            // 
            this.textboxMinimum.Location = new System.Drawing.Point(100, 170);
            this.textboxMinimum.Name = "textboxMinimum";
            this.textboxMinimum.Size = new System.Drawing.Size(248, 22);
            this.textboxMinimum.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 122);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Title";
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Location = new System.Drawing.Point(16, 170);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(67, 17);
            this.labelMinimum.TabIndex = 6;
            this.labelMinimum.Text = "Minimum ";
            // 
            // Creating_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 303);
            this.Controls.Add(this.labelMinimum);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textboxMinimum);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Creating_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.TextBox textboxMinimum;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinimum;
    }
}