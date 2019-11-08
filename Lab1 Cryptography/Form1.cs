using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Cryptography
{
    public partial class Form1 : Form
    {
        ArrayList alphabet = new ArrayList() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
        ArrayList key = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
            textBox_key.Text = "qwertyuioplkjhgfdsazxcvbnm ";
        }

        private ArrayList substCypher(String keyText)
        {
            key.Clear();

            for (int i = 0; i < keyText.Length; i++) 
            {
                key.Add(Convert.ToChar(keyText[i].ToString()));
            }

            return key;
            
        }

        private void button_switch_Click(object sender, EventArgs e)
        {
            if (textBox_input.Enabled)
            {
                textBox_input.Enabled = false;
                textBox_output.Enabled = true;

                label_input.Text = "Decrypted text:";
                label_output.Text = "Plain text:";

                textBox_input.Text = textBox_output.Text = "";
            }
            else
            {
                textBox_input.Enabled = true;
                textBox_output.Enabled = false;

                label_input.Text = "Plain text:";
                label_output.Text = "Encrypted text:";

                textBox_input.Text = textBox_output.Text = "";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!(textBox_key.Text.ToString().Length == 0))
            {
                key = substCypher(textBox_key.Text.ToString());

                if (textBox_input.Enabled && textBox_input.Text.Length != 0)
                {
                    String text = textBox_input.Text.ToString();

                    String encrypted = encryptMethod(text);

                    System.Windows.Forms.Clipboard.SetText(encrypted);

                    textBox_output.Text = encrypted;
                }
                else if (textBox_output.Enabled && textBox_output.Text.Length != 0)
                {
                    String text = textBox_output.Text.ToString();

                    String decrypted = decryptMethod(text);

                    System.Windows.Forms.Clipboard.SetText(decrypted);

                    textBox_input.Text = decrypted;
                }
            } else
            {
                MessageBox.Show("The key is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private String encryptMethod(String text)
        {
            var encrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                encrypted += key[alphabet.IndexOf(text[i])].ToString();
            }

            return encrypted;
        }

        private String decryptMethod(String text)
        {
            String decrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                decrypted += alphabet[key.IndexOf(text[i])].ToString();
            }

            return decrypted;
        }
    }
}
