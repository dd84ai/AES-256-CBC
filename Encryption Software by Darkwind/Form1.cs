using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptStringSample;

namespace Encryption_Software_by_Darkwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button3_press();
        }

        private void button1_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string password = textBox1_Key.Text.Replace(" ", "");
                string plaintext = richTextBox1_Decrypted.Text;
                string encryptedstring = StringCipher.Encrypt(plaintext, password);
                richTextBox2_Encrypted.Text = encryptedstring;
            }
            catch (Exception error)
            {
                richTextBox2_Encrypted.Text = "*I could not encrypt the message*";
                MessageBox.Show(error.Message, "Error.");
            }
        }

        private void button2_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string password = textBox1_Key.Text.Replace(" ","");
            string encryptedstring = richTextBox2_Encrypted.Text.Replace(" ", "");
            string decryptedstring = StringCipher.Decrypt(encryptedstring, password);
            richTextBox1_Decrypted.Text = decryptedstring;
            }
            catch (Exception error)
            {
                richTextBox1_Decrypted.Text = "*I could not decrypt the message*";
                MessageBox.Show(error.Message, "Error: Possibly wrong crypted message or key.");
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        void button3_press()
        {
            try
            {
                textBox1_Key.Text = RandomString(32);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void button3_Generate_Key_Click(object sender, EventArgs e)
        {
            button3_press();
        }
    }
}
