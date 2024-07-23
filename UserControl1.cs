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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clipboard.SetText("你好，目前伺服器屬於關機狀態。\r\n開機時 #伺服器狀態 會有通知，還請耐心等候謝謝 :rdc:");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("目前組織分為\r\n和平組織跟好戰組織\r\n而好戰組織每周日中午十二點整會輪替地盤\r\n長按 F1新增『組織功能』表單後 即可查看當周地盤所屬組織\r\n之後可對照此表格進行販賣及收購\r\n例如: 本周福島化工組織為I.Z.O 故毒品相關則販買給I.Z.O\r\n\r\n或是線上沒有該組織成員在線可自行販賣給NPC\r\n但要注意販賣給NPC的價格與販賣給組織成員的價格是一樣的唷!");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("按下F2>物品類別>物品>給予>#對方ID>數量>確認");
            MessageBox.Show("複製成功!", "訊息");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("此為限量/限時/紅利/客製車(槍)，可以在 #紅惡魔交易交流區 向玩家收購\r\n交易前可先私訊管理方幫忙查證對方帳號，交易請謹慎小心受騙！");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("如果沒有其他問題\r\n就麻煩幫我點擊頻道最上方的『鎖頭圖示🔒 』以關閉此提問窗口 謝謝");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("你好 請問有什麼需要協助的嗎\r\n如果沒有 麻煩幫我點擊上方的『🔒』以關閉此提問窗口 謝謝");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("可以在公頻上販售，而相關的價格可以在 #職業組織公告 中查閱\r\n例：售嗎啡 電話XXXXX");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("房產分為800萬及2000萬兩種\r\n差別在於2000萬的房子可以放的傢俱數量及是否有停領車點\r\n目前800萬的房子已售罄，如果想購買可以至 #紅惡魔交易交流區 向玩家購買二手房");
            MessageBox.Show("複製成功!", "訊息");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("若被他人擊殺可以向警察報案並通緝對方\r\nF1 > 惡魔手機 > 訊息 >警視廳(報案) > 小寫gps+ID+死亡原因\r\n\r\n如短時間多次被同一玩家擊殺，可將過程錄影起來向管理員投訴該玩家為惡意玩家，以保證你的遊玩權益\r\n惡意玩家相關請至 #紅惡魔法律 中查閱。");
            MessageBox.Show("複製成功!", "訊息");
        }
    }
}
