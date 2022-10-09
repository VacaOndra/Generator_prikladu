using System;
using System.Windows.Forms;

namespace Generator_prikladu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int a,b;
            int vysledek = 0;
            int i = 0;
            int operace;
            string znak = null;
            int pocet_opakovani = int.Parse(textBox6.Text);
            Random random = new Random();
            do
            {
                operace = random.Next(1, 3);
                a = random.Next(int.Parse(textBox2.Text) - 1);
                b = random.Next(int.Parse(textBox3.Text) - 1);
                switch (operace)
                {
                    case 1:
                        vysledek = a + b;
                        znak = "+";
                        break;
                    case 2:
                        vysledek = a - b;
                        znak = "-";
                        break;
                }    
                if (vysledek < int.Parse(textBox5.Text) && vysledek >= int.Parse(textBox4.Text))
                {
                    textBox1.Text += $"{a} {znak} {b} = \r\n";
                    i++;
                }

            }
            while (i < pocet_opakovani);
        }
    }
}
