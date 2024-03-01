using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_game
{
    public partial class deneme : Form
    {
        
        public TextBox Oyuncu1, Oyuncu2;
        public static deneme instance;
        public deneme()
        {
            InitializeComponent();
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.temp.Bilgi.Text = "Gorev Basarili Asker";

            if(textBox1.Text !="" && textBox2.Text != "")
            {
                // oyuncu bilgileri girildi
                //Oyuncu1 = textBox1.Text;
                Oyuncu2 = textBox2;
                Oyuncu1 = textBox1;


                Form1 f= new Form1();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!");
            }
        }
    }
}
