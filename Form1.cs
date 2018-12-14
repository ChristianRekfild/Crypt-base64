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

namespace Crypt
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        

        MemoryStream userInput = new MemoryStream();

        public Form1()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        //Открыть
        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                helper.FileIn = openFileDialog.FileName;
                richTextBox1.Text = System.IO.File.ReadAllText(helper.FileIn, Encoding.Default);
            }
        }

        //text in
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //шифровка
        private void button2_Click(object sender, EventArgs e)
        {
            String text = helper.Base64Encode(richTextBox1.Text);
            text = helper.Base64Encode(richTextBox1.Text);
            richTextBox2.Text = text;
        }

        //дешифровка
        private void button3_Click(object sender, EventArgs e)
        {
            String text = helper.Base64Decode(richTextBox1.Text);
            text = helper.Base64Decode(richTextBox1.Text);
            richTextBox2.Text = text;
        }

        //text out
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Сохранить
        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBox2.Text);
        }
    }
}
