namespace CPU_scheduling
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
            this.components = new System.ComponentModel.Container();
            this.FCFS_button = new System.Windows.Forms.Button();
            this.SJF_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CPU_box = new System.Windows.Forms.RichTextBox();
            this.CPU_lable = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FCFS_button
            // 
            this.FCFS_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FCFS_button.Location = new System.Drawing.Point(111, 376);
            this.FCFS_button.Name = "FCFS_button";
            this.FCFS_button.Size = new System.Drawing.Size(103, 43);
            this.FCFS_button.TabIndex = 0;
            this.FCFS_button.Text = "FCFS";
            this.FCFS_button.UseVisualStyleBackColor = false;
            this.FCFS_button.Click += new System.EventHandler(this.FCFS_button_Click);
            // 
            // SJF_button
            // 
            this.SJF_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SJF_button.Location = new System.Drawing.Point(241, 376);
            this.SJF_button.Name = "SJF_button";
            this.SJF_button.Size = new System.Drawing.Size(103, 43);
            this.SJF_button.TabIndex = 1;
            this.SJF_button.Text = "SJF";
            this.SJF_button.UseVisualStyleBackColor = false;
            this.SJF_button.Click += new System.EventHandler(this.SJF_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(391, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "RR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(532, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Priority";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(141, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 27);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 27);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 27);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(140, 225);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 27);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "p2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "P3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "P4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "P5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "P6";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(391, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(136, 136);
            this.checkedListBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(141, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(214, 224);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(50, 27);
            this.textBox8.TabIndex = 24;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(214, 191);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(50, 27);
            this.textBox9.TabIndex = 23;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(214, 155);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(50, 27);
            this.textBox10.TabIndex = 22;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(214, 122);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(50, 27);
            this.textBox11.TabIndex = 21;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(214, 89);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(50, 27);
            this.textBox12.TabIndex = 20;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(214, 56);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(50, 27);
            this.textBox13.TabIndex = 19;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(214, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Priority";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Q";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(283, 125);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(47, 27);
            this.textBox14.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "RAM";
            // 
            // CPU_box
            // 
            this.CPU_box.Location = new System.Drawing.Point(565, 56);
            this.CPU_box.Name = "CPU_box";
            this.CPU_box.Size = new System.Drawing.Size(125, 136);
            this.CPU_box.TabIndex = 29;
            this.CPU_box.Text = "";
            // 
            // CPU_lable
            // 
            this.CPU_lable.AutoSize = true;
            this.CPU_lable.Location = new System.Drawing.Point(599, 33);
            this.CPU_lable.Name = "CPU_lable";
            this.CPU_lable.Size = new System.Drawing.Size(36, 20);
            this.CPU_lable.TabIndex = 30;
            this.CPU_lable.Text = "CPU";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(162, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Processes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CPU_lable);
            this.Controls.Add(this.CPU_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SJF_button);
            this.Controls.Add(this.FCFS_button);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Button FCFS_button;
        private Button SJF_button;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckedListBox checkedListBox1;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label8;
        private Label label9;
        private TextBox textBox14;
        private Label label10;
        private RichTextBox CPU_box;
        private Label CPU_lable;
        private Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}