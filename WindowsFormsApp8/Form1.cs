using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // создали экземпляр установим фильтр для файлов
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt) | *.txt || ";
            open.FilterIndex = 1;// по умолчанию фильтруются
                                 // текстовые файлы
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader =
                File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd(); //
                                                    // считываем файл до конца
                reader.Close(); // закрываем reader
            }

        }


        private void розоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void чёрная_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            textBox1.ForeColor = Color.Black;
        }

        private void розовая_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            textBox1.ForeColor = Color.Black;
        }

        private void стандартная_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void оранжевая_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            textBox1.ForeColor = Color.Black;
        }

        private void англToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem1.Visible = false;
            ToolStripMenuItem2.Visible = true;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem2.Visible = false;
            ToolStripMenuItem1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Purple;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.DarkGreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            // создали экземпляр
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                // записываем в файл содержимое поля
                writer.Write(textBox1.Text);
                writer.Close();
                // закрываем writer
            }

        }

        private void Размер_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(textBox2.Text);
            this.textBox1.Font = new Font(textBox1.Font.FontFamily, y);
        }
    }
}
