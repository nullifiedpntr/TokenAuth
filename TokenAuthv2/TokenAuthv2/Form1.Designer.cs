namespace TokenAuthv2
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
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            name = new TextBox();
            token = new TextBox();
            uuid = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 37);
            label1.Name = "label1";
            label1.Size = new Size(202, 40);
            label1.TabIndex = 0;
            label1.Text = "Token Auth V2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 16);
            label4.Name = "label4";
            label4.Size = new Size(182, 21);
            label4.TabIndex = 6;
            label4.Text = "Made with <3 by twisted";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 85, 95);
            button1.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 387);
            button1.Name = "button1";
            button1.Size = new Size(378, 32);
            button1.TabIndex = 7;
            button1.Text = "Launch";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(419, 12);
            button2.Name = "button2";
            button2.Size = new Size(21, 23);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(40, 40, 40);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(76, 92);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 94);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // name
            // 
            name.BackColor = Color.FromArgb(40, 40, 40);
            name.BorderStyle = BorderStyle.None;
            name.ForeColor = SystemColors.Window;
            name.Location = new Point(108, 208);
            name.Name = "name";
            name.Size = new Size(258, 16);
            name.TabIndex = 15;
            name.Text = "Name";
            // 
            // token
            // 
            token.BackColor = Color.FromArgb(40, 40, 40);
            token.BorderStyle = BorderStyle.None;
            token.ForeColor = SystemColors.Window;
            token.Location = new Point(108, 230);
            token.Name = "token";
            token.Size = new Size(258, 16);
            token.TabIndex = 16;
            token.Text = "Access Token";
            // 
            // uuid
            // 
            uuid.BackColor = Color.FromArgb(40, 40, 40);
            uuid.BorderStyle = BorderStyle.None;
            uuid.ForeColor = SystemColors.Window;
            uuid.Location = new Point(108, 252);
            uuid.Name = "uuid";
            uuid.Size = new Size(258, 16);
            uuid.TabIndex = 17;
            uuid.Text = "UUID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(452, 431);
            Controls.Add(uuid);
            Controls.Add(token);
            Controls.Add(name);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "token auth v2 made by twisted";
            Load += Form1_Load;
            MouseDown += TokenAuth_MouseDown;
            MouseMove += TokenAuth_MouseMove;
            MouseUp += TokenAuth_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private TextBox name;
        private TextBox token;
        private TextBox uuid;
    }
}
