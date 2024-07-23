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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("**哈囉~恭喜你通過進入新手村的第一階段表單審核 :NEW: \r\n接下來要進到第二階段的面試\r\n需要觀看面試影片及操作一些事項 (包含改名、添加遊戲身分等)\r\n\r\n◎ 麻煩請挑選自身時間充裕的時間 並 回覆方便面試的時間\r\n◎ 請和我們約時間這邊才能安排高層進行面試\r\n◎ 不接受臨時面試，可以面試的時間為晚間 18:30~21:30 **");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("我先邀請你進新手村DC\r\n裡面有一些基本的教學供你查閱\r\n如果有任何問題都可以在裡面詢問或是直接私訊我\r\n面試時間到了之後幫我進入面試頻道稍作等候");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("**還在為了沒朋友一起玩或是沒人帶你認識紅惡魔而感到困擾嗎？\r\n\r\n徵徵徵徵的就是你！歡迎各位新手加入新手村！\r\n\r\n這裡有優良的轉職機制，讓你可以快速的找到新工作！\r\n\r\n遊戲上有任何疑問都可以與組織的夥伴共同討論！\r\n\r\n別再當邊緣人了，快來加入我們吧 :NEW: \r\n\r\n【新手村】擴大招生中，若想加入歡迎填寫以下表單。\r\nhttps://reurl.cc/7RaL5y\r\n\r\n⚠️ 表單已洗白，歡迎新手填單\r\n⚠️ 若通過面試高層將會主動通知面試，請勿私訊詢問審核結果\r\n⚠️ 以下為【新手村投訴表單】如需投訴請填寫以下表單。\r\n:NEW:  https://reurl.cc/mlg4al **");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("哈囉 遊玩上都還OK嗎~");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("好 如果有問題都可以提問!");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("恭喜你已完成７天簽到任務! 請找時間來找我領取 ２０萬獎金");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("獎金已完成發放❗ \r\n之後不必繼續簽到，可以開始帶著其他新人玩，帶領新人遊玩也可以領取獎勵呦");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("基本上新手村的工作跟一般市民一樣，只是這邊主要是提供給你們安心探索紅惡魔的組織\r\n除了禁止收購毒品等非法物品外，沒有限制你們的賺錢方式\r\n而新手村裡面都是新手，如有任何問題都可以在新手村discord裡面進行交流\r\n");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("**你好\r\n因目前組織成員爆滿，故高層這邊決定開始移除組織成員中較資深的玩家。\r\n在此也感謝你對新手村長期以來的支持❤️\r\n\r\n移除後也可以留在新手村的discord群組與大家一起聊天\r\n也期望之後能在新手村舉辦的活動上再次見到你～\r\n那這邊沒有問題的話，我們就先將你移除囉！期待下次再會**");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("**在這提醒如有轉職的需要，必須在加入新手村一個禮拜後才可以做申請唷\r\n若急需去其他職業的話就需要自行去紅惡魔DC填寫他們的表單，這邊就不提供DC轉職項目**");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("你好 我看妳好一陣子沒上線了 成員位置有限 先把你位置讓出來給其他人ok嗎");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("\r\n**你好，這邊已經收到你的投訴我會把相關資料傳給負責處理事情的高層\r\n如下次需要投訴成員直接至下面的連結填寫即可，謝謝配合!\r\nhttps://reurl.cc/mlg4al **");
            MessageBox.Show("複製成功!", "訊息");
        }
    }
}
