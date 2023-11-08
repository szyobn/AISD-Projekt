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
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = SS(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = SS(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik = Random1(liczbaN);
                label3.Text = "";


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik = convert(liczbaN);
                label3.Text = "";


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
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i].Trim());

            }
            return liczby;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        int[] Sb(int[] tab1)
        {
            bool cbz;
            int n = tab1.Length;
            do
            {
                cbz = false;
                for (int i = 1; i < n; i++)
                {


                    if (tab1[i] < tab1[i - 1])
                    {
                        int a = tab1[i - 1];
                        tab1[i - 1] = tab1[i];
                        tab1[i] = a;
                        cbz = true;

                    }

                }
                n--;



            }
            while (cbz);
            return tab1;
        }

        int[] SS(int[] tab2)
        {

            for (int i = 0; i < tab2.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab2.Length; j++)
                {
                    if (tab2[min] > tab2[j])
                    {
                        min = j;
                    }
                }

                int temp = tab2[i];
                tab2[i] = tab2[min];
                tab2[min] = temp;
            }
            return tab2;

        }

        int[] Si(int[] tab3)
        {

            for (int i = 1; i < tab3.Length; i++)
            {
                int temp = tab3[i];
                int j = i - 1;

                while (j >= 0 && tab3[j] > temp)
                {
                    tab3[j + 1] = tab3[j];
                    j--;
                }
                tab3[j + 1] = temp;
            }
            return tab3;
        }







        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Sb(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Sb(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int liczbaN = (int)numericUpDown1.Value;
                int[] wynik1 = Random1(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }


            }
            else
            {
                string liczbaN = textBox1.Text.ToString();
                int[] wynik1 = convert(liczbaN);
                int[] wynik = Si(wynik1);
                label3.Text = "";
                for (int i = 0; i < wynik.Length; i++)
                {
                    label3.Text += wynik[i].ToString() + " ";
                }
            }
        }
    }
}