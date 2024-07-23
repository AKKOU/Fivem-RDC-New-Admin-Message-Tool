using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDCNEW
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("以下為面試影片網址\r\nhttps://youtu.be/9NVnGLhY45A");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("以下為面試表單網址\r\nhttps://forms.gle/yDyMnkWUSdVzBrPc7");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("以下為F1自訂教學網址，可以按照影片操作\r\nhttps://youtu.be/8ZiAS1Hve2g");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("以下為影像設定教學網址，可以按照影片操作\r\nhttps://youtu.be/ly2zue4ET3Y");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("**以下為【新手村投訴表單】如需投訴請填寫以下表單。**\r\n https://reurl.cc/mlg4al");
            MessageBox.Show("複製成功!", "訊息");
        }
    }
}
