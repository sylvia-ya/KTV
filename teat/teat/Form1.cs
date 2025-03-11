using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace teat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string bus1 = "650";
            //string[] bus = { "650", "236", "118", "275" };
            //for (int i = 0; i < bus.Length; i++)
            {
                //textBox1.Text = bus[i];
            }

        }
          
        string[] song = new string[] { "稻香", "屋梅子醬", "在樹上唱歌", "溫柔", "好不容易" };
        string[] singer = new string[] { "周杰倫", "李榮浩", "郭靜", "五月天", "告五人" };
        int[] no = new int[] { 1, 2, 3, 4, 5 };

        private void button2_Click(object sender, EventArgs e)
        {
            string[] song2 = new string[song.Length];
            song.CopyTo(song2, 0);
            Array.Sort(song,no);
            Array.Sort(song, singer);



            for (int i = 0; i < no.Length; i++)
           
                textBox1.Text = textBox1.Text += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < no.Length; i++)
            {
              



                textBox1.Text = textBox1.Text += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            string msg = $"找不到{search}";
            int index = Array.IndexOf(singer, search);
            //當index找不到時 為-1
            if (index >= 0)
            {
                msg = "排名\t歌手\t歌曲" + Environment.NewLine;
                while (index >= 0) //只要index>=0就一直執行此迴圈
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "查詢結果"); //查詢結果為msgbox的title

        }
    }
}
