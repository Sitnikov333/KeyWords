using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void TestIndicators(string word)
        {
            

            if (checkBox4.Checked == false)
            { if (checkBox3.Checked == false){
                    if (checkBox2.Checked == false) {
                        if (checkBox1.Checked == false) {
                            MessageBox.Show("Задайте хотя бы один параметр!");
                            return;
                        }
                    }
                }
            }

            if (checkBox1.Checked == true) //Цифры
            {

                word += "0123456789";
                
            }
            //radioButton1 анг radioButton2 рус radioButton3 оба
            if (checkBox4.Checked == true) //нижний рег
            {
                if (radioButton1.Checked == true) { word += "abcdefghijklmnopqrstuvwxyz"; }
                else if (radioButton2.Checked == true) { word += "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; }
                else { word += "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя"; }
            }

            if (checkBox2.Checked == true) //спец симв
            {
                word += "~!@#$%^&*()_+`-={}[]:;<>./\\";
            }
            if (checkBox3.Checked == true)//верхний рег
            {
                if (radioButton1.Checked == true) { word += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
                else if (radioButton2.Checked == true) { word += "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; }
                else { word += "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; }
            }
                Random rnd = new Random();
                int lng = word.Length;
                for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    textBox1.Text += word[rnd.Next(lng)];
                }
            }
        private void button1_Click(object sender, EventArgs e) 
        {
            string word = "";
            textBox1.Text = "";
            TestIndicators(word);        
        }

        private void button2_Click(object sender, EventArgs e) //Закрытие формы
        {
            this.Close();
        }

        private void оСоздателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель Ситников Д.С. студент группы 1243гму");
        }
    }
}
