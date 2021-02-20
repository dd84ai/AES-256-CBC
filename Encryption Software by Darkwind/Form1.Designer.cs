namespace Encryption_Software_by_Darkwind
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1_Encrypt = new System.Windows.Forms.Button();
            this.button2_Decrypt = new System.Windows.Forms.Button();
            this.button3_Generate_Key = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_Key = new System.Windows.Forms.TextBox();
            this.richTextBox1_Decrypted = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2_Encrypted = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Encrypt
            // 
            this.button1_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Encrypt.Location = new System.Drawing.Point(12, 12);
            this.button1_Encrypt.Name = "button1_Encrypt";
            this.button1_Encrypt.Size = new System.Drawing.Size(132, 29);
            this.button1_Encrypt.TabIndex = 0;
            this.button1_Encrypt.Text = "Encrypt";
            this.button1_Encrypt.UseVisualStyleBackColor = true;
            this.button1_Encrypt.Click += new System.EventHandler(this.button1_Encrypt_Click);
            // 
            // button2_Decrypt
            // 
            this.button2_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2_Decrypt.Location = new System.Drawing.Point(150, 12);
            this.button2_Decrypt.Name = "button2_Decrypt";
            this.button2_Decrypt.Size = new System.Drawing.Size(132, 29);
            this.button2_Decrypt.TabIndex = 1;
            this.button2_Decrypt.Text = "Decrypt";
            this.button2_Decrypt.UseVisualStyleBackColor = true;
            this.button2_Decrypt.Click += new System.EventHandler(this.button2_Decrypt_Click);
            // 
            // button3_Generate_Key
            // 
            this.button3_Generate_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3_Generate_Key.Location = new System.Drawing.Point(288, 12);
            this.button3_Generate_Key.Name = "button3_Generate_Key";
            this.button3_Generate_Key.Size = new System.Drawing.Size(132, 29);
            this.button3_Generate_Key.TabIndex = 2;
            this.button3_Generate_Key.Text = "Generate Key";
            this.button3_Generate_Key.UseVisualStyleBackColor = true;
            this.button3_Generate_Key.Click += new System.EventHandler(this.button3_Generate_Key_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // textBox1_Key
            // 
            this.textBox1_Key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_Key.Location = new System.Drawing.Point(16, 67);
            this.textBox1_Key.Name = "textBox1_Key";
            this.textBox1_Key.Size = new System.Drawing.Size(772, 20);
            this.textBox1_Key.TabIndex = 4;
            this.textBox1_Key.Text = "KeyToDecrypt";
            // 
            // richTextBox1_Decrypted
            // 
            this.richTextBox1_Decrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1_Decrypted.Location = new System.Drawing.Point(4, 26);
            this.richTextBox1_Decrypted.Name = "richTextBox1_Decrypted";
            this.richTextBox1_Decrypted.Size = new System.Drawing.Size(370, 316);
            this.richTextBox1_Decrypted.TabIndex = 5;
            this.richTextBox1_Decrypted.Text = "Insert text to encrypt here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decrypted Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encrypted Text";
            // 
            // richTextBox2_Encrypted
            // 
            this.richTextBox2_Encrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2_Encrypted.Location = new System.Drawing.Point(9, 26);
            this.richTextBox2_Encrypted.Name = "richTextBox2_Encrypted";
            this.richTextBox2_Encrypted.Size = new System.Drawing.Size(383, 316);
            this.richTextBox2_Encrypted.TabIndex = 8;
            this.richTextBox2_Encrypted.Text = "Insert text to decrypt here";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1_Decrypted);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2_Encrypted);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(776, 345);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(426, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Instruction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Encryption_Software_by_Darkwind.Properties.Resources.star_space_tile;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1_Key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_Generate_Key);
            this.Controls.Add(this.button2_Decrypt);
            this.Controls.Add(this.button1_Encrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dark Encrypting Software (1.6)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Encrypt;
        private System.Windows.Forms.Button button2_Decrypt;
        private System.Windows.Forms.Button button3_Generate_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_Key;
        private System.Windows.Forms.RichTextBox richTextBox1_Decrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2_Encrypted;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}

