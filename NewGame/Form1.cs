using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace NewGame
{
    public partial class RollBall : Form
    {
        public RollBall()
        {
            InitializeComponent();
        }

        private String path = @"high_score.txt";

        private void RollBall_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            
        }

        private int score = 0;
        private bool game_over = false;

        private void timer_Tick(object sender, EventArgs e)
        {

            score++;
            lbl_score.Text = "Score: " + score;

            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Tag == "platform")
                {

                    c.Top += 10;

                    if(c.Top > 600)
                    {
                        c.Top = 0;
                    }

                    if (picture_ball.Bounds.IntersectsWith(c.Bounds))
                    {
                        timer.Stop();
                        game_over = true;
                        showHighScoreBoard();
                    }
                }
            }

            gameSpeed(score);

        }

        private void showHighScoreBoard()
        {

            top_panel.Visible = true;
            gb_high_score.Visible = true;

            lbl_point.Text = "Score: " + writeHighScoreToFileAndReturn();
        }

        private void hideHighScoreBoard()
        {
            gb_high_score.Visible = false;
            top_panel.Visible = false;
        }

        
        private void gameSpeed(int score)
        {
            if(score == 100) // 10 second
            {
                timer.Interval = 80;
            }else if(score == 200)
            {
                timer.Interval = 60;
            }else if(score == 300)
            {
                timer.Interval = 50;
            }else if(score == 400)
            {
                timer.Interval = 40;
            }else if(score == 500)
            {
                timer.Interval = 25;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            this.ActiveControl = picture_ball;
            timer.Start();
        }


        private int writeHighScoreToFileAndReturn()
        {

            int currentScore = int.Parse(lbl_score.Text.Split(':')[1].Trim());

            if (new FileInfo(path).Length != 0)
            {
                StreamReader streamReader = new StreamReader(path);
                int high_score = Int32.Parse(streamReader.ReadLine());
                streamReader.Close();
                if (high_score < currentScore)
                {
                    StreamWriter streamWriter = new StreamWriter(path);
                    streamWriter.WriteLine(currentScore);
                    streamWriter.Close();
                    return currentScore;
                }
                else
                {
                    return high_score;
                }

            }
            else
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(currentScore);
                streamWriter.Close();
            }

            return currentScore;

        }

        private void btn_restart_Click(object sender, EventArgs e)
        {

            ground_1.Location = new Point(102, 557);
            ground_2.Location = new Point(258, 527);
            ground_3.Location = new Point(11, 474);
            ground_4.Location = new Point(12, 311);
            ground_5.Location = new Point(240, 269);
            ground_6.Location = new Point(164, 178); 
            ground_7.Location = new Point(10, 89);
            ground_8.Location = new Point(280, 41);
            picture_ball.Location = new Point(180, 389);

            hideHighScoreBoard();
            this.ActiveControl = picture_ball;
            score = 0;
            game_over = false;
            timer.Interval = 100;
            lbl_score.Text = "Score: " + score;
            timer.Start();
        }

        private void picture_ball_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!game_over)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (picture_ball.Right < 350)
                        {
                            picture_ball.Left += 10;
                        }
                        break;

                    case Keys.Left:
                        if (picture_ball.Left > 10)
                        {
                            picture_ball.Left -= 10;
                        }
                        break;

                }
            }
        }
    }
}
