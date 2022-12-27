using System;
using System.Collections;
using System.Windows.Forms;


namespace CPU_scheduling
{
    public partial class Form1 : Form
    {
        ArrayList array = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        // FCFS Process
        private void FCFS_button_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(textBox1.Text));
            array.Add(Convert.ToInt32(textBox2.Text));
            array.Add(Convert.ToInt32(textBox3.Text));
            array.Add(Convert.ToInt32(textBox4.Text));
            array.Add(Convert.ToInt32(textBox5.Text));
            array.Add(Convert.ToInt32(textBox6.Text));
            foreach(var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
            if (checkedListBox1.Items[0].ToString() == textBox1.Text)
            {
                CPU_box.Text = label1.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox2.Text){
                CPU_box.Text = label2.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox3.Text)
            {
                CPU_box.Text = label3.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox4.Text)
            {
                CPU_box.Text = label4.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox5.Text)
            {
                CPU_box.Text = label5.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox6.Text)
            {
                CPU_box.Text = label6.Text;
            }
            checkedListBox1.Items.RemoveAt(0);
            if(checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("there is no any proccesses");
                timer1.Stop();
            }


        }

        private void SJF_button_Click(object sender, EventArgs e)
        {
            array.Add(Convert.ToInt32(textBox1.Text));
            array.Add(Convert.ToInt32(textBox2.Text));
            array.Add(Convert.ToInt32(textBox3.Text));
            array.Add(Convert.ToInt32(textBox4.Text));
            array.Add(Convert.ToInt32(textBox5.Text));
            array.Add(Convert.ToInt32(textBox6.Text));
            array.Sort();
            foreach (var item in array)
            {
                checkedListBox1.Items.Add(item);
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = Convert.ToInt32(checkedListBox1.Items[0] + "000");
            if (checkedListBox1.Items[0].ToString() == textBox1.Text)
            {
                CPU_box.Text = label1.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox2.Text)
            {
                CPU_box.Text = label2.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox3.Text)
            {
                CPU_box.Text = label3.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox4.Text)
            {
                CPU_box.Text = label4.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox5.Text)
            {
                CPU_box.Text = label5.Text;
            }
            else if (checkedListBox1.Items[0].ToString() == textBox6.Text)
            {
                CPU_box.Text = label6.Text;
            }
            checkedListBox1.Items.RemoveAt(0);
            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("there is no any proccesses");
                timer2.Stop();
            }

        }
    }
}