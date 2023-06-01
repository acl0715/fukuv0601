namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string chr = "(‚ÂOƒÖO)‚Â";

        public Form1()
        {
            InitializeComponent();//‰Šú‰»‚·‚éƒvƒƒOƒ‰ƒ€
            //MessageBox.Show($"{label1.Bottom}");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "‰Ú–¼";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            /*if (label1.Left < 0)
            {
                vx = 10;
            }*/
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx+(vx/10));
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx = Math.Abs(vx+(vx/10));
            }
            /*if (label1.Top < 0)
            {
                vy = 10;
            }*/
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy+(vy/10));
            }
            else if (label1.Bottom > ClientSize.Height) 
            {
                vy = Math.Abs(vy/10);
            }
            if (label1.Right > 800)
            {
                vx = -10;
            }
            if (label1.Bottom > 450)
            {
                vy = -10;
            }

            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }
    }
}