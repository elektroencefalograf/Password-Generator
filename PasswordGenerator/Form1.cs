using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int CurrnetPassLenght = 5;
        Random character = new Random();
        bool specialChecker = false;

        private void GeneratePassword(int passwordLenght)
        {
            String Allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz!@#$%^&*?";
            String password = "";
            for(int i = 0; i < passwordLenght; i++)
            {
                password += Allcharacters[character.Next(0, Allcharacters.Length)];
            }
            PasswordGenerated.Text = password;
        }

        private void GeneratePassword(int passwordLenght, bool SpecialCharacter)
        {
            String Allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz";
            String password = "";
            for (int i = 0; i < passwordLenght; i++)
            {
                password += Allcharacters[character.Next(0, Allcharacters.Length)];
            }
            PasswordGenerated.Text = password;
        }

        public Form1()
        {
            InitializeComponent();
            PasswordLenghtBar.Minimum = 5;
            PasswordLenghtBar.Maximum = 25;
            PasswordLenght.Text = PasswordLenghtBar.Value.ToString();
            GeneratePassword(5,specialChecker);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordGenerated.Text);
        }

       

        private void RegeneratePasswordButton_Click(object sender, EventArgs e)
        {
            if (SpecialCharBox.Checked)
            {
                GeneratePassword(CurrnetPassLenght);
            }
            else
            {
                GeneratePassword(CurrnetPassLenght, true);
            }
        }

        private void PasswordLenghtBar_Scroll(object sender, EventArgs e)
        {
            PasswordLenght.Text = PasswordLenghtBar.Value.ToString();
            CurrnetPassLenght = PasswordLenghtBar.Value;
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            if (platformName.Text == "")
            {
                MessageBox.Show("Platform name cannot be empty");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"passwords.txt", true))
                {
                    writer.WriteLine(platformName.Text + " - " + PasswordGenerated.Text);
                }
                MessageBox.Show("Password saved!!");
                platformName.Text = "";
            }
        }

        private void SpecialCharBox_CheckedChanged(object sender, EventArgs e)
        {
            if(specialChecker == false) { specialChecker = true; }
            else { specialChecker = false; }
        }
    }
}
