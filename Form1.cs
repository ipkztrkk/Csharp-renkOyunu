namespace RenkOyunu_gorselprogramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] butonlar = new Button[9];
        int hamleSayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            butonlar = new Button[] { btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8, btn_9 };
            Random r = new Random();
            foreach (Button b in butonlar)
            {
                b.BackColor = (r.Next(0, 2) == 0) ? Color.Thistle : Color.PowderBlue;
            }
        }
        void butonRenkDegistir(Button b)
        {
            if (b.BackColor == Color.PowderBlue)
                b.BackColor = Color.Thistle;
            else
                b.BackColor = Color.PowderBlue;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_1);
            butonRenkDegistir(btn_2);
            butonRenkDegistir(btn_4);
            oyunBittiMi();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_1);
            butonRenkDegistir(btn_2);
            butonRenkDegistir(btn_3);
            butonRenkDegistir(btn_5);
            oyunBittiMi();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_2);
            butonRenkDegistir(btn_3);
            butonRenkDegistir(btn_6);
            oyunBittiMi();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_1);
            butonRenkDegistir(btn_4);
            butonRenkDegistir(btn_5);
            butonRenkDegistir(btn_7);
            oyunBittiMi();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_2);
            butonRenkDegistir(btn_4);
            butonRenkDegistir(btn_6);
            butonRenkDegistir(btn_8);
            butonRenkDegistir(btn_5);
            oyunBittiMi();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_3);
            butonRenkDegistir(btn_6);
            butonRenkDegistir(btn_9);
            butonRenkDegistir(btn_5);
            oyunBittiMi();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_4);
            butonRenkDegistir(btn_7);
            butonRenkDegistir(btn_8);
            oyunBittiMi();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_7);
            butonRenkDegistir(btn_8);
            butonRenkDegistir(btn_9);
            butonRenkDegistir(btn_5);
            oyunBittiMi();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            butonRenkDegistir(btn_6);
            butonRenkDegistir(btn_9);
            butonRenkDegistir(btn_8);
            oyunBittiMi();
        }
        void oyunBittiMi()
        {
            lbl_hamleSayisi.Text = (++hamleSayisi).ToString();
            bool ayni = true;

            foreach (var item in butonlar)
            {
                if (item.BackColor != btn_1.BackColor)
                    ayni = false;
            }
            if (ayni == true)
            {
                foreach (var item in butonlar)
                {
                    item.Enabled = false;
                }
               DialogResult dr = MessageBox.Show("Oyun " + hamleSayisi + " Hamlede Bitti. \nYeni Oyuna Baþlamak istiyor musunuz?",
                    "Yeni Oyun", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    Application.Restart();
                else
                    this.Close();
            }
        }
    }
}
