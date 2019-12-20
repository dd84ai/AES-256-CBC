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
            richTextBox1.Text = "Encrypt: Encrypt will allow you to create codes of contract for your friends to try decode without the registered key code.\n\nDecrypt: Decrypt will allow you to able decode a Encrypted code and will show what was written when a Generated code was met from when it was Encrypted\n\nGenerated Key: Self explainer, It just Generates a random made code to give to friends for easy decrypted messsages.\n\nP.S. To cut it short, when you encrypt text, it's important which key you use, as it would be needed to decode it back.\n\nWhen you want to decode a message - you need correct encrypted code and a correct key to it, to get a readable decrypted text.";
        }
    }
}
