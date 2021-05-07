using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeDanJi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();
            SystemSetting.loadSystemSetting();
            UserLibrary.nowUserLibrary = UserLibrary.loadFromName(SystemSetting.systemSetting.defaultUserName);
            if (UserLibrary.nowUserLibrary==null)
            {
                UserLibrary.nowUserLibrary = new UserLibrary();
                UserLibrary.nowUserLibrary.userName = "dafault";
                UserLibrary.nowUserLibrary.save();
            }
        }

        private void buttonManageQList_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
