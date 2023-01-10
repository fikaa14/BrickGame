using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igrica
{
    public partial class Igrica : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 15;

        int ballx = 5;
        int bally = 5;
        int rezultat = 0;

        public static String gameResult;

        public Igrica()
        {
            InitializeComponent();
            FormClosed += Igrica_FormClosed;
        }

        private void Igrica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            updateScore();      // Updejtovanje rezultata
            moveBall();         // Kretanje loptice
            movePlatform();     // Kretnja platforme lijevo desno
            endOfRoad();        // Ogranicavamo kretnju platfrome
            boundOfPlatfrom();  // Odbijanje od platfrome
            boundOfWalls();     // Odbijanje od zidova
            checkBlocks();      // Provjerava da li je loptica udarila u block            
            gameWon();          // Ako je rezultat = 30 presli smo igricu
        }

        private void gameOver()
        {
            gameTimer.Stop();

            if (rezultat < 30)
            {
                this.Hide();
                gameResult = "Izgubili ste";
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void gameWon()
        {
            if (rezultat == 30)
            {
                txtScore.Text = "Rezultat: " + rezultat;
                gameTimer.Stop();
                this.Hide();
                gameResult = "Pobijedili ste";
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void updateScore()
        {
            txtScore.Text = "Rezultat: " + rezultat;
        }

        private void boundOfWalls()
        {
            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx;
            }
        }

        private void moveBall()
        {
            ball.Left += ballx;
            ball.Top += bally;
        }

        private void boundOfPlatfrom()
        {
            if (ball.Top < 0 || ball.Bounds.IntersectsWith(platfrom.Bounds))
            {
                if (rezultat % 5 == 0)
                {
                    int increase = rezultat / 5;
                    bally = bally + increase;

                    if (ballx < 0)
                    {
                        ballx = -bally;
                    }
                    else
                    {
                        ballx = bally;
                    }
                }
                bally = -bally;

                
            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
            }
        }

        private void movePlatform()
        {
            if (goLeft) { platfrom.Left -= speed; }
            if (goRight) { platfrom.Left += speed; }
        }

        private void endOfRoad() 
        {
            if (platfrom.Left < 0)
            {
                goLeft = false;
            }
            else if (platfrom.Left + platfrom.Width > 754)
            {
                goRight = false;
            }
        }

        private void checkBlocks()
        {
            foreach (Control x in this.Controls)
            {
                if (isTagBlock(x)) //provjerava da li je block(picture) tagovan
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        removeBlock(x); //kada loptica udari block, on se brise,
                                        //a loptica mijenja putanju
                    }
                }
            }
        }

        private void removeBlock(Control x)
        {
            this.Controls.Remove(x);// sklanja blok
            bally = -bally; // mijenjanje putanje
            rezultat++; // azuriranje rezultata
        }

        private bool isTagBlock(Control x)
        {
            if (x is PictureBox && (String)x.Tag == "blocks")
                return true;
            return false;
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //Kad pritisnemo strelicu za lijevo platforma ce ici u lijevo
            leftGo(e);

            //Isto kao prethodna funkcija sako u desno 
            rightGo(e);
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //zaustavljanje kretanje platforme u lijevo
            leftStop(e);
            //zaustavljanje kretanje platforme u desno
            rightStop(e);
        }

        private void leftGo(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && platfrom.Left > 0)
            {
                goLeft = true;
            }
        }

        private void rightGo(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && platfrom.Left + platfrom.Width < 754)
            {
                goRight = true;
            }
        }

        private void leftStop(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
        }

        private void rightStop(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void Igrica_Load(object sender, EventArgs e)
        {
            labelName.Text = Form2.name;
        }
    }
}
