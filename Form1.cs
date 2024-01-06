using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X, false = O
        int turn_count = 0;
        int wynik_x = 0;
        int wynik_o = 0;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel_Plansza_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Informacje_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Gra w kółko i krzyżyk.\nW aplikacji zostały ukryte 2 Easter Eggi,\nczy uda ci się je odnaleźć?\n                                               SK 20.12.2021", "Informacje",
                      System.Windows.Forms.MessageBoxButtons.OK,
                      System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void Zamknij_Gre_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Nowa_Gra_Click(object sender, EventArgs e)
        {
            turn = turn ? true : false;
            turn_count = 0;
            Pole1.Text = "";
            Pole2.Text = "";
            Pole3.Text = "";
            Pole4.Text = "";
            Pole5.Text = "";
            Pole6.Text = "";
            Pole7.Text = "";
            Pole8.Text = "";
            Pole9.Text = "";
            Pole1.Enabled = true;
            Pole2.Enabled = true;
            Pole3.Enabled = true;
            Pole4.Enabled = true;
            Pole5.Enabled = true;
            Pole6.Enabled = true;
            Pole7.Enabled = true;
            Pole8.Enabled = true;
            Pole9.Enabled = true;
            Pole1.BackColor = default(Color);
            Pole2.BackColor = default(Color);
            Pole3.BackColor = default(Color);
            Pole4.BackColor = default(Color);
            Pole5.BackColor = default(Color);
            Pole6.BackColor = default(Color);
            Pole7.BackColor = default(Color);
            Pole8.BackColor = default(Color);
            Pole9.BackColor = default(Color);
        }

        private void Obrazek_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                Obrazek.Image = new Bitmap(open.FileName);



            }
        }

        private void Pole_Click(object sender, EventArgs e)
        {
            Button Pole = (Button)sender;
            if (turn)
                Pole.Text = "X";
            else
                Pole.Text = "O";
            turn = !turn;
            Gracz.Text = turn ? "X" : "O";
            Pole.Enabled = false;
            turn_count++;
            checkWinCondition();

        }

        private void checkWinCondition()
        {

            bool WinCondition = false;

            // Sprawdzenie lini poziomych
            if ((Pole1.Text == Pole2.Text) && (Pole2.Text == Pole3.Text) && (!Pole1.Enabled))

            {
                WinCondition = true;
                Pole1.BackColor = Color.LightGoldenrodYellow;
                Pole2.BackColor = Color.LightGoldenrodYellow;
                Pole3.BackColor = Color.LightGoldenrodYellow;
            }
            if ((Pole4.Text == Pole5.Text) && (Pole5.Text == Pole6.Text) && (!Pole4.Enabled))

            {
                WinCondition = true;
                Pole4.BackColor = Color.LightGoldenrodYellow;
                Pole5.BackColor = Color.LightGoldenrodYellow;
                Pole6.BackColor = Color.LightGoldenrodYellow;
            }
            if ((Pole7.Text == Pole8.Text) && (Pole8.Text == Pole9.Text) && (!Pole7.Enabled))

            {
                WinCondition = true;
                Pole7.BackColor = Color.LightGoldenrodYellow;
                Pole8.BackColor = Color.LightGoldenrodYellow;
                Pole9.BackColor = Color.LightGoldenrodYellow;
            }
            // Sprawdzenie lini pionowych
            if ((Pole1.Text == Pole4.Text) && (Pole4.Text == Pole7.Text) && (!Pole1.Enabled))

            {
                WinCondition = true;
                Pole1.BackColor = Color.LightGoldenrodYellow;
                Pole4.BackColor = Color.LightGoldenrodYellow;
                Pole7.BackColor = Color.LightGoldenrodYellow;
            }
            if ((Pole2.Text == Pole5.Text) && (Pole5.Text == Pole8.Text) && (!Pole2.Enabled))

            {
                WinCondition = true;
                Pole2.BackColor = Color.LightGoldenrodYellow;
                Pole5.BackColor = Color.LightGoldenrodYellow;
                Pole8.BackColor = Color.LightGoldenrodYellow;
            }
            if ((Pole3.Text == Pole6.Text) && (Pole6.Text == Pole9.Text) && (!Pole3.Enabled))

            {
                WinCondition = true;
                Pole3.BackColor = Color.LightGoldenrodYellow;
                Pole6.BackColor = Color.LightGoldenrodYellow;
                Pole9.BackColor = Color.LightGoldenrodYellow;
            }
            //// Sprawdzenie lini ukośnych
            if ((Pole1.Text == Pole5.Text) && (Pole5.Text == Pole9.Text) && (!Pole5.Enabled))

            {
                WinCondition = true;
                Pole1.BackColor = Color.LightGoldenrodYellow;
                Pole5.BackColor = Color.LightGoldenrodYellow;
                Pole9.BackColor = Color.LightGoldenrodYellow;
            }
            if ((Pole3.Text == Pole5.Text) && (Pole5.Text == Pole7.Text) && (!Pole5.Enabled))

            {
                WinCondition = true;
                Pole3.BackColor = Color.LightGoldenrodYellow;
                Pole5.BackColor = Color.LightGoldenrodYellow;
                Pole7.BackColor = Color.LightGoldenrodYellow;
            }

            if (WinCondition)
            {

                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = "O";
                    wynik_o++;
                    pkt_o.Text = wynik_o.ToString();
                }

                else
                {
                    winner = "X";
                    wynik_x++;
                    pkt_x.Text = wynik_x.ToString();
                }

                MessageBox.Show("Wygrywa gracz " + winner + "!", "Gratulacje!");

            }

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Powodzenia następnym razem!", "Remis");
            }
        }
        private void disableButtons()
        {

            Pole1.Enabled = false;
            Pole2.Enabled = false;
            Pole3.Enabled = false;
            Pole4.Enabled = false;
            Pole5.Enabled = false;
            Pole6.Enabled = false;
            Pole7.Enabled = false;
            Pole8.Enabled = false;
            Pole9.Enabled = false;

        }

        private void pkt_x_Click(object sender, EventArgs e)
        {

        }

        private void pkt_o_Click(object sender, EventArgs e)
        {

        }

        private void Gracz_Click(object sender, EventArgs e)
        {

        }
    }
}