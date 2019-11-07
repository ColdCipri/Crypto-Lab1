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
        ArrayList randomList = new ArrayList(); 
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList substCypher(ArrayList alpha)
        {
            randomList = (ArrayList)alpha.Clone();


            Random rand = new Random();
            for (int i = 0; i < randomList.Capacity - 1; i++)
            {
                int j = rand.Next(i, randomList.Capacity);
                var temp = randomList[i];
                randomList[i] = randomList[j];
                randomList[j] = temp;
            }

            return randomList;
            
        }

        private void button_switch_Click(object sender, EventArgs e)
        {
            if (textBox_input.Enabled)
            {
                textBox_input.Enabled = false;
                textBox_output.Enabled = true;

                textBox_input.Text = textBox_output.Text = "";
            }
            else
            {
                textBox_input.Enabled = true;
                textBox_output.Enabled = false;
                
                textBox_input.Text = textBox_output.Text = "";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (randomList.Capacity == 0)
            {
                randomList = substCypher(alphabet);
            }

            if (textBox_input.Enabled)
            {
                var text = textBox_input.Text.ToString();
                
                var encrypted = encryptMethod(text);

                textBox_output.Text = encrypted;
            } else
            {
                var text = textBox_output.Text.ToString();

                var decrypted = decryptMethod(text);

                textBox_input.Text = decrypted;
            }

        }

        private String encryptMethod(String text)
        {
            var encrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                var pos = alphabet.IndexOf(text[i]);
                encrypted += randomList[pos].ToString();
            }

            return encrypted;
        }

        private String decryptMethod(String text)
        {
            var decrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                var pos = randomList.IndexOf(text[i]);
                decrypted += alphabet[pos].ToString();
            }

            return decrypted;
        }
    }
}
