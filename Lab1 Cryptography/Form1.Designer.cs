namespace Lab1_Cryptography
{
    partial class Form1
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_switch = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(15, 77);
            this.textBox_input.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(298, 137);
            this.textBox_input.TabIndex = 0;
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_input.Location = new System.Drawing.Point(6, 27);
            this.label_input.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(196, 46);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Plain text:";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output.Location = new System.Drawing.Point(465, 27);
            this.label_output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(287, 46);
            this.label_output.TabIndex = 2;
            this.label_output.Text = "Encrypted text:";
            // 
            // textBox_output
            // 
            this.textBox_output.Enabled = false;
            this.textBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_output.Location = new System.Drawing.Point(473, 77);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(321, 137);
            this.textBox_output.TabIndex = 3;
            // 
            // button_switch
            // 
            this.button_switch.Location = new System.Drawing.Point(354, 133);
            this.button_switch.Margin = new System.Windows.Forms.Padding(4);
            this.button_switch.Name = "button_switch";
            this.button_switch.Size = new System.Drawing.Size(79, 28);
            this.button_switch.TabIndex = 4;
            this.button_switch.Text = "Switch";
            this.button_switch.UseVisualStyleBackColor = true;
            this.button_switch.Click += new System.EventHandler(this.button_switch_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(319, 307);
            this.button_start.Margin = new System.Windows.Forms.Padding(4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(164, 48);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 396);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_switch);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.textBox_input);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_switch;
        private System.Windows.Forms.Button button_start;
    }
}

