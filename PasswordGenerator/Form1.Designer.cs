
namespace PasswordGenerator
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
            this.Title = new System.Windows.Forms.Label();
            this.PasswordGenerated = new System.Windows.Forms.Label();
            this.PasswordLenghtBar = new System.Windows.Forms.TrackBar();
            this.PasswordLenght = new System.Windows.Forms.Label();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            this.RegeneratePasswordButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.SpecialCharBox = new System.Windows.Forms.CheckBox();
            this.platformName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLenghtBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(317, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(561, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Password Generator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordGenerated
            // 
            this.PasswordGenerated.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordGenerated.Location = new System.Drawing.Point(317, 154);
            this.PasswordGenerated.Name = "PasswordGenerated";
            this.PasswordGenerated.Size = new System.Drawing.Size(561, 99);
            this.PasswordGenerated.TabIndex = 1;
            this.PasswordGenerated.Text = "label1";
            this.PasswordGenerated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLenghtBar
            // 
            this.PasswordLenghtBar.Location = new System.Drawing.Point(317, 314);
            this.PasswordLenghtBar.Name = "PasswordLenghtBar";
            this.PasswordLenghtBar.Size = new System.Drawing.Size(561, 56);
            this.PasswordLenghtBar.TabIndex = 2;
            this.PasswordLenghtBar.Scroll += new System.EventHandler(this.PasswordLenghtBar_Scroll);
            // 
            // PasswordLenght
            // 
            this.PasswordLenght.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLenght.Location = new System.Drawing.Point(243, 314);
            this.PasswordLenght.Name = "PasswordLenght";
            this.PasswordLenght.Size = new System.Drawing.Size(68, 45);
            this.PasswordLenght.TabIndex = 3;
            this.PasswordLenght.Text = "label1";
            this.PasswordLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Location = new System.Drawing.Point(317, 376);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(127, 47);
            this.CopyPasswordButton.TabIndex = 4;
            this.CopyPasswordButton.Text = "Copy password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // RegeneratePasswordButton
            // 
            this.RegeneratePasswordButton.Location = new System.Drawing.Point(751, 376);
            this.RegeneratePasswordButton.Name = "RegeneratePasswordButton";
            this.RegeneratePasswordButton.Size = new System.Drawing.Size(127, 47);
            this.RegeneratePasswordButton.TabIndex = 5;
            this.RegeneratePasswordButton.Text = "Generate Again";
            this.RegeneratePasswordButton.UseVisualStyleBackColor = true;
            this.RegeneratePasswordButton.Click += new System.EventHandler(this.RegeneratePasswordButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveToFileButton.Location = new System.Drawing.Point(59, 235);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(81, 24);
            this.SaveToFileButton.TabIndex = 6;
            this.SaveToFileButton.Text = "Save to file";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // SpecialCharBox
            // 
            this.SpecialCharBox.AutoSize = true;
            this.SpecialCharBox.Location = new System.Drawing.Point(59, 265);
            this.SpecialCharBox.Name = "SpecialCharBox";
            this.SpecialCharBox.Size = new System.Drawing.Size(142, 24);
            this.SpecialCharBox.TabIndex = 7;
            this.SpecialCharBox.Text = "Special chracters";
            this.SpecialCharBox.UseVisualStyleBackColor = true;
            this.SpecialCharBox.CheckedChanged += new System.EventHandler(this.SpecialCharBox_CheckedChanged);
            // 
            // platformName
            // 
            this.platformName.Location = new System.Drawing.Point(59, 202);
            this.platformName.Name = "platformName";
            this.platformName.Size = new System.Drawing.Size(142, 27);
            this.platformName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Platform name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformName);
            this.Controls.Add(this.SpecialCharBox);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.RegeneratePasswordButton);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.PasswordLenght);
            this.Controls.Add(this.PasswordLenghtBar);
            this.Controls.Add(this.PasswordGenerated);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLenghtBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PasswordGenerated;
        private System.Windows.Forms.TrackBar PasswordLenghtBar;
        private System.Windows.Forms.Label PasswordLenght;
        private System.Windows.Forms.Button CopyPasswordButton;
        private System.Windows.Forms.Button RegeneratePasswordButton;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.CheckBox SpecialCharBox;
        private System.Windows.Forms.TextBox platformName;
        private System.Windows.Forms.Label label1;
    }
}

