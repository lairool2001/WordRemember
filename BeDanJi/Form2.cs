using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeDanJi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1)
            {
                MessageBox.Show("分割字符必須為恰好一個字");
                textBox1.Focus();
                return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string text = File.ReadAllText(path);
                string[] lineArray = text.Replace("\r", "").Split('\n');
                listBox1.Items.Clear();
                for (int i = 0; i < lineArray.Length; i++)
                {
                    string line = lineArray[i];
                    string[] s = line.Split(textBox1.Text[0]);
                    QandA qAndA = new QandA();
                    qAndA.q = s[0];
                    qAndA.a = s[1];
                    listBox1.Items.Add(qAndA);
                }
                //listBox1.Items.AddRange(lineArray);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserLibrary.nowUserLibrary != null)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    QandA item = listBox1.Items[i] as QandA;
                    UserLibrary.nowUserLibrary.qAndAList.Add(item);
                }
                UserLibrary.nowUserLibrary.save();
                MessageBox.Show("匯入了" + listBox1.Items.Count + "個到" + UserLibrary.nowUserLibrary.userName + "的庫");
            }
        }
    }
}
