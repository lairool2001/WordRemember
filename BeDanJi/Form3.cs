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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, SystemStrings.user);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var fileArray = directoryInfo.GetFiles();
            listBox1.Items.Clear();
            for (int i = 0; i < fileArray.Length; i++)
            {
                FileInfo f = fileArray[i];
                if (f.Extension == "." + SystemStrings.user)
                {
                    listBox1.Items.Add(Path.GetFileNameWithoutExtension(f.Name));
                }
            }
            showNowUserAndSelectList();
        }
        void showNowUserAndSelectList()
        {
            label1.Text = "當前使用者:" + UserLibrary.nowUserLibrary.userName;
            listBox1.FindStringExact(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                var item = listBox1.Items[i];
                if (item.ToString() == textBox1.Text)
                {
                    MessageBox.Show("使用者已經存在");
                    return;
                }
            }
            listBox1.Items.Add(textBox1.Text);
            UserLibrary userLibrary = new UserLibrary();
            userLibrary.userName = textBox1.Text;
            userLibrary.save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string name = listBox1.SelectedItem.ToString();
                File.Delete(Path.Combine(Environment.CurrentDirectory, SystemStrings.user, name + "." + SystemStrings.user));
                listBox1.Items.Remove(name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UserLibrary.nowUserLibrary = UserLibrary.loadFromName(listBox1.SelectedItem.ToString());
                showNowUserAndSelectList();
                SystemSetting.systemSetting.defaultUserName = UserLibrary.nowUserLibrary.userName;
            }
        }
    }
}
