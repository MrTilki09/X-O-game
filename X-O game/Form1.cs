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

    public partial class Form1 : Form
    {
        int sira=1;
        public Form1()
        {
            InitializeComponent();
            textBox10.Text+=deneme.instance.Oyuncu1.Text;
            textBox11.Text += deneme.instance.Oyuncu2.Text;
            OyuncuSirasi.Text += deneme.instance.Oyuncu1.Text;
        }

        private void operasyon(object sender, EventArgs e)
        {
            
            if((sender as TextBox).Text == "")
            {

            
                if (sira % 2 == 1)
                {
                    //Oyuncu 1den basladi;
                    (sender as TextBox).Text = "X";

                    sira++;
                    OyuncuSirasi.Text = deneme.instance.Oyuncu2.Text;
                }
                else
                {
                    (sender as TextBox).Text = "O";



                    sira++;
                    OyuncuSirasi.Text = deneme.instance.Oyuncu1.Text;
                }

                if((textBox1.Text=="X" && textBox2.Text == "X" && textBox3.Text == "X") || (textBox1.Text == "O" && textBox2.Text == "O" && textBox3.Text == "O") || (textBox4.Text == "X" && textBox5.Text == "X" && textBox6.Text == "X") || (textBox4.Text == "O" && textBox5.Text == "O" && textBox6.Text == "O") || (textBox7.Text=="X" && textBox8.Text == "X" && textBox9.Text == "X") || (textBox7.Text == "O" && textBox8.Text == "O" && textBox9.Text == "O") || (textBox1.Text=="X" && textBox4.Text == "X" && textBox7.Text == "X") || (textBox1.Text == "O" && textBox4.Text == "O" && textBox7.Text == "O") || (textBox2.Text == "X" && textBox5.Text == "X" && textBox8.Text == "X") || (textBox2.Text == "O" && textBox5.Text == "O" && textBox8.Text == "O") || (textBox3.Text == "X" && textBox6.Text == "X" && textBox9.Text == "X") || (textBox3.Text == "O" && textBox6.Text == "O" && textBox9.Text == "O") || (textBox1.Text == "X" && textBox5.Text == "X" && textBox9.Text == "X") || (textBox1.Text == "O" && textBox5.Text == "O" && textBox9.Text == "O") || (textBox3.Text == "X" && textBox5.Text == "X" && textBox7.Text == "X") || (textBox3.Text == "O" && textBox5.Text == "O" && textBox7.Text == "O"))
                {
                    if ((sira-1) % 2 == 1)
                    {
                        this.Close();
                        MessageBox.Show("Oyunu Kazanan -->" + deneme.instance.Oyuncu1.Text);
                    }
                    else
                    {
                        this.Close();
                        MessageBox.Show("Oyunu Kazanan -->" + deneme.instance.Oyuncu2.Text);
                    }
                }


                
            }
            else
            {
                MessageBox.Show("KorMusun be Kardesim!!!!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
