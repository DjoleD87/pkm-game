using System;
using System.Drawing;
using System.Windows.Forms;

namespace papir_kamen_i_makaze
{
    public partial class Form1 : Form

        
    {
        int compNumbers = 0;
        int yourChoose = 0;
        int counter1 = 0;
        int counter2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            
            if (yourNameBox.Text == " " || brojPartijaBox2.Text == "" )
            {
                MessageBox.Show("Sva polja moraju biti popunjena pre pocetka igre");
            }
            else
            {
                yourName.Text = yourNameBox.Text;
                newGameBtn.Visible = true;
                startGameBtn.Visible = false;
                startPicture1.Visible = false;
                coosePapirBox.Visible = true;
                cooseKamenBox.Visible = true;
                cooseMakazeBox.Visible = true;
                yourMoveText.Visible = true;
                score1Box.Visible = true;
                score2Box.Visible = true;
                scoreLabel1.Visible = true;
                scoreLabel2.Visible = true;
                makazPicture1.Visible = false;
                papirPicture1.Visible = false;
                kamenPicture1.Visible = false;
               
                RandomNameComp();
                
            }
            

        }

        //Izbor poteza - male slike................start

        private void coosePapirBox_Click(object sender, EventArgs e)
        {
            papirPicture1.Visible = true;
            makazPicture1.Visible = false;
            kamenPicture1.Visible = false;
            SameVisible();
            yourChoose = 1;
            Play();
            GameMoveSchem();
            ScoreShema();
        }
        

        private void cooseKamenBox_Click_1(object sender, EventArgs e)
        {
            kamenPicture1.Visible = true;
            papirPicture1.Visible = true;
            makazPicture1.Visible = false;
            SameVisible();
            yourChoose = 2;
            Play();
            GameMoveSchem();
            ScoreShema();

        }

        private void cooseMakazeBox_Click_1(object sender, EventArgs e)
        {
            makazPicture1.Visible = true;
            papirPicture1.Visible = false;
            kamenPicture1.Visible = false;
            SameVisible();
            yourChoose = 3;
            Play();
            GameMoveSchem();
            ScoreShema();
        }
        //Izbor poteza - male slike................end 

        //Izlaz btn
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //New game btn
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            ChooseOptionFalse();
            noWinLabel.Visible = false;
            winLabel1.Visible = false;
            winLabel2.Visible = false;
            startPicture2.Visible = true;
            startPicture1.Visible = true;
           scoreLabel1.Visible = false;
            scoreLabel2.Visible = false;
            yourName.Text = "";
            compiuterNameLabel.Text = "";
            score1Box.Visible = false;
            score2Box.Visible = false;
            startGameBtn.Visible = true;
            winerSmile1.Visible = false;
            winerSmile2.Visible = false;
            sadSmile2.Visible = false;
            sadSmile1.Visible = false;
            winer1.Visible = false;
            winer2.Visible = false;
            newGameBtn.Visible = false;
            yourMoveText.Visible = false;
            yourNameBox.Text = "";
            brojPartijaBox2.Text = "";
            counter1 = 0;
            counter2 = 0;
            score1Box.Text = counter1.ToString();
            score2Box.Text = counter2.ToString();
        }

        
        //Podesavanje upisivanja imena igraca i broj partija
        private void yourNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Podesavanje upisivanja  broja partija
        private void brojPartijaBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Hover malih slika....start
        private void cooseKamenBox_MouseEnter(object sender, EventArgs e)
        {
            cooseKamenBox.Location = new Point(cooseKamenBox.Location.X + 0, cooseKamenBox.Location.Y - 4);
        }

        private void cooseKamenBox_MouseLeave(object sender, EventArgs e)
        {
            cooseKamenBox.Location = new Point(cooseKamenBox.Location.X + 0, cooseKamenBox.Location.Y + 4);

        }

        private void cooseMakazeBox_MouseEnter(object sender, EventArgs e)
        {
            cooseMakazeBox.Location = new Point(cooseMakazeBox.Location.X + 0, cooseMakazeBox.Location.Y - 4);

        }

        private void cooseMakazeBox_MouseLeave(object sender, EventArgs e)
        {
            cooseMakazeBox.Location = new Point(cooseMakazeBox.Location.X + 0, cooseMakazeBox.Location.Y + 4);

        }

        private void coosePapirBox_MouseEnter(object sender, EventArgs e)
        {
            coosePapirBox.Location = new Point(coosePapirBox.Location.X + 0, coosePapirBox.Location.Y - 4);

        }

        private void coosePapirBox_MouseLeave(object sender, EventArgs e)
        {
            coosePapirBox.Location = new Point(coosePapirBox.Location.X + 0, coosePapirBox.Location.Y + 4);
        }
        //Hover malih slika....end

        //Metode
        private void Play() {
            startGameBtn.Visible = false;

            Random numbers = new Random();
            compNumbers = numbers.Next(1, 4);

            if (compNumbers == 1)
            {
                papirPicture2.Visible = true;
                kamenPicture2.Visible = false;
                makazePicture2.Visible = false;
                startPicture2.Visible = false;
            }
            else if (compNumbers == 2)
            {
                papirPicture2.Visible = false;
                kamenPicture2.Visible = true;
                makazePicture2.Visible = false;
                startPicture2.Visible = false;
            }
            else
            {
                papirPicture2.Visible = false;
                kamenPicture2.Visible = false;
                makazePicture2.Visible = true;
                startPicture2.Visible = false;
            }
            
        }

        private void GameMoveSchem()
        {
            if (yourChoose == 1 && compNumbers == 1)
            {
                noWinLabel.Visible = true;
                winLabel1.Visible = false;
                winLabel2.Visible = false;

            }
            else if (yourChoose == 1 && compNumbers == 2)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = true;
                winLabel2.Visible = false;

                counter1++;
            }
            else if (yourChoose == 1 && compNumbers == 3)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = false;
                winLabel2.Visible = true;
                counter2++;
            }
            else if (yourChoose == 2 && compNumbers == 1)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = false;
                winLabel2.Visible = true;
                counter2++;
            }
            else if (yourChoose == 2 && compNumbers == 2)
            {
                noWinLabel.Visible = true;
                winLabel1.Visible = false;
                winLabel2.Visible = false;

            }
            else if (yourChoose == 2 && compNumbers == 3)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = true;
                winLabel2.Visible = false;
                counter1++;

            }
            else if (yourChoose == 3 && compNumbers == 1)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = true;
                winLabel2.Visible = false;
                counter1++;

            }
            else if (yourChoose == 3 && compNumbers == 2)
            {
                noWinLabel.Visible = false;
                winLabel1.Visible = false;
                winLabel2.Visible = true;
                counter2++;

            }
            else if (yourChoose == 3 && compNumbers == 3)
            {
                noWinLabel.Visible = true;
                winLabel1.Visible = false;
                winLabel2.Visible = false;

            }
        }

        private void ScoreShema()
        {
            score1Box.Text = counter1.ToString();
            score2Box.Text = counter2.ToString();

            if (brojPartijaBox2.Text == score1Box.Text)
            {
                winer1.Visible = true;
                winerSmile1.Visible = true;
                sadSmile2.Visible = true;
                ChooseOptionFalse();
                yourMoveText.Visible = false;
            }
            else if (brojPartijaBox2.Text == score2Box.Text)
            {
                winer2.Visible = true;
                winerSmile2.Visible = true;
                sadSmile1.Visible = true;
                ChooseOptionFalse();
                yourMoveText.Visible = false;

            }
        }
        private void ChooseOptionFalse() {
            coosePapirBox.Visible = false;
            cooseKamenBox.Visible = false;
            cooseMakazeBox.Visible = false;
        }
        
        private void SameVisible()
        {
            coosePapirBox.Visible = true;
            cooseKamenBox.Visible = true;
            cooseMakazeBox.Visible = true;
            yourMoveText.Visible = true;
            startGameBtn.Visible = false;
            startPicture2.Visible = false;
        }
        private void RandomNameComp()
        {
            Random names = new Random();
            int name = names.Next(1, 6);
            if (name == 1)
            {
                compiuterNameLabel.Text = "Mark";
            }
            else if (name == 2)
            {
                compiuterNameLabel.Text = "Jane";
            }
            else if (name == 3)
            {
                compiuterNameLabel.Text = "Jully";
            }
            else if (name == 4)
            {
                compiuterNameLabel.Text = "Pamela";
            }
            else if (name == 5)
            {
                compiuterNameLabel.Text = "John";
            }
        }
    }
    
}
