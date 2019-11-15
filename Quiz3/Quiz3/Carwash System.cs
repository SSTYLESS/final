using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Makebox.Items.Add("Honda");
            Makebox.Items.Add("Toyota");
            Makebox.Items.Add("Audi");


            comboBox3.Items.Add("2000");
            comboBox3.Items.Add("2001");
            comboBox3.Items.Add("2002");
            comboBox3.Items.Add("2003");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (Makebox.SelectedIndex == 0)
            {
                comboBox2.Items.Add("Civic");
                comboBox2.Items.Add("Accord");
                comboBox2.Items.Add("Sport");
            }
            if (Makebox.SelectedIndex == 1)
            {
                comboBox2.Items.Add("Corolla");
                comboBox2.Items.Add("Camry");
                comboBox2.Items.Add("Prius");
            }
            if (Makebox.SelectedIndex == 2)
            {
                comboBox2.Items.Add("R8");
                comboBox2.Items.Add("A4");
                comboBox2.Items.Add("A6");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {


                string Make = Makebox.Text;
                string Model = comboBox2.Text;
                string Year = comboBox3.Text;
                string FirstName = textBox1.Text;
                string LastName = textBox2.Text;
                string Telephone = textBox3.Text;

                if (Make != "" && Model != "" && Year != "" && FirstName != "" && LastName != "" && Telephone != "")
                {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.DefaultExt = "txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Append))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(Make + " ");
                        sw.Write(Model + " ");
                        sw.Write(Year + " ");
                        sw.Write(FirstName + " ");
                        sw.Write(LastName + " ");
                        sw.Write(Telephone + "\n");
                    }
                }

            }
            
                else
                {
                    MessageBox.Show("You must fill out the form");
                }
            }

        private void resetbutton_Click(object sender, EventArgs e)
        {

            Makebox.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }


    }
    

 
    

