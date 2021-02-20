using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Software_by_Darkwind
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
            richTextBox1.Text = "Encrypt: This button encodes your text, which could not be decoded without the key\n\n" +
                "Decrypt: This button decodes encrypted text back to readable. It requires having the right key\n\n" + "" +
                "Generate Key: This button exists for the cases when you are lazy to create your key on your own\n\n" + 
                "P.S. To cut it short, when you encrypt text, it's important which key you use, as it would be needed to decode it back.\n\nWhen you want to decode a message - you need correct encrypted text and a correct key to it in order to get a readable decrypted text back.";
        }
    }
}
