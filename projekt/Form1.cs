using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik = Random1(liczbaN);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }

            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik = convert(liczbaN);
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }

            }
            
            



        }
        /*void wypisz(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                label3.Text = i.ToString();

            }
        }*/


        int[] Random1(int n)
        {
            int[] tab = new int[n];
            Random random2 = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = random2.Next(1, 101);
                label3.Text = tab[i].ToString();



            }
            return tab;

        }
        int[] convert(string napis)
        {
            var liczbyS = napis.Trim().Split(',');
            var liczby = new int[liczbyS.Length];
            for (int i = 0;i < liczbyS.Length;i++)
            {
                liczby[i] = int.Parse(liczbyS[i].Trim());

            }
            return liczby;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}