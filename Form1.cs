using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelsGame
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool firstPlayerTurn = true;
        int firstScore, secondScore;
        int winner = 0; 
        string index = "s";
        string treeIndex = "s";
        Timer pixelWaitingTimer = new Timer();
        List<Node> tree = new List<Node>();

        public Form()
        {
            InitializeComponent();
            CreateTree();
            InitializeScore();
            InicializeSolutionPath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializePixelWaitingTimer()
        {
            pixelWaitingTimer.Interval = 1000;
            pixelWaitingTimer.Tick += new EventHandler(Timer_Tick);
            startPictureBox.Image = Properties.Resources.black;
            pixelWaitingTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextMove();
            
            if (index == "f")
            {
                endPic();
            }
        }

        private void InitializeLabelScore()
        {
            point.Width = 10;
            point.Height = 25;
            point.Location = new Point(305, 9);
            point.Text = ":";
            score1.Width = 25;
            score1.Height = 25;
            score1.Location = new Point(280, 9);
            score2.Width = 25;
            score2.Height = 25;
            score2.Location = new Point(325, 9);
        }
        private void InitializeScore()
        {
            InitializeLabelScore();
            int p = 0;
            char[] str;
            str = treeIndex.ToArray();
            string[] strArray = str.Select(x => x.ToString()).ToArray();

            if ((index == "3" && strArray[strArray.Length - 2] == "s") ||
                (index == "2" && strArray[strArray.Length - 3] == "s") ||
                (index == "6" && strArray[strArray.Length - 3] == "s") ||
                (index == "5" && strArray[strArray.Length - 3] == "3") ||
                (index == "f" && strArray[strArray.Length - 3] == "2") ||
                (index == "f" && strArray[strArray.Length - 3] == "6") ||
                (index == "1" && strArray[strArray.Length - 3] == "7") ||
                (index == "7" && strArray[strArray.Length - 3] == "1") ||
                (index == "3" && strArray[strArray.Length - 3] == "5"))
                p = 1;

            else if ((index == "1" && strArray[strArray.Length - 2] == "s") ||
                (index == "1" && strArray[strArray.Length - 2] == "4" && strArray[strArray.Length - 3] != "7") ||
                (index == "1" && strArray[strArray.Length - 2] == "2") ||
                (index == "2" && strArray[strArray.Length - 2] == "1" && strArray[strArray.Length - 3] != "s") ||
                (index == "2" && strArray[strArray.Length - 2] == "5") ||
                (index == "3" && strArray[strArray.Length - 2] == "4" && strArray[strArray.Length - 3] != "5") ||
                (index == "3" && strArray[strArray.Length - 2] == "6") ||
                (index == "4" && strArray[strArray.Length - 2] == "1") ||
                (index == "4" && strArray[strArray.Length - 2] == "7") ||
                (index == "4" && strArray[strArray.Length - 2] == "3") ||
                (index == "4" && strArray[strArray.Length - 2] == "5") ||
                (index == "5" && strArray[strArray.Length - 2] == "4" && strArray[strArray.Length - 3] != "3") ||
                (index == "5" && strArray[strArray.Length - 2] == "2") ||
                (index == "6" && strArray[strArray.Length - 2] == "3" && strArray[strArray.Length - 3] != "s") ||
                (index == "6" && strArray[strArray.Length - 2] == "7") ||
                (index == "7" && strArray[strArray.Length - 2] == "6") ||
                (index == "7" && strArray[strArray.Length - 2] == "4" && strArray[strArray.Length - 3] != "1") ||
                (index == "f" && strArray[strArray.Length - 2] == "7" && strArray[strArray.Length - 3] != "6"))
                p = 2;

            if (firstPlayerTurn)
            {
                firstScore += p;
                score1.Text = firstScore.ToString();
            }
            else
            {
                secondScore += p;
                score2.Text = secondScore.ToString();
            }
                
        }

        private void NextMove()
        {
            if (index == "1")
            {
                pictureBox1.Image = Properties.Resources.black;
            }

            if (index == "2")
            {
                pictureBox2.Image = Properties.Resources.black;
            }

            if (index == "3")
            {
                pictureBox3.Image = Properties.Resources.black;
            }

            if (index == "4")
            {
                pictureBox4.Image = Properties.Resources.black;
            }

            if (index == "5")
            {
                pictureBox5.Image = Properties.Resources.black;
            }

            if (index == "6")
            {
                pictureBox6.Image = Properties.Resources.black;
            }

            if (index == "7")
            {
                pictureBox7.Image = Properties.Resources.black;
            }

            if (finishPictureBox.Image == Properties.Resources.pixel)
            {
                finishPictureBox.Image = Properties.Resources.black;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "s" || index == "4" || index == "2")
            {
                pictureBox1.Image = Properties.Resources.pixel;
                index = "1";
                treeIndex = treeIndex + index;

                if (firstPlayerTurn && treeIndex.Length < 3)
                {
                    firstScore = 2;
                    score1.Text = firstScore.ToString();
                }
                else if (!firstPlayerTurn && treeIndex.Length < 3)
                {
                    secondScore = 2;
                    score2.Text = secondScore.ToString();
                }
                else InitializeScore();
                
                InitializePixelWaitingTimer();
                
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "1" || index == "5")
            {
                pictureBox2.Image = Properties.Resources.pixel;
                index = "2";
                treeIndex = treeIndex + index;
                InitializeScore();
                InitializePixelWaitingTimer();
            }    
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "s" || index == "4" || index == "6")
            {
                pictureBox3.Image = Properties.Resources.pixel;
                index = "3";
                treeIndex = treeIndex + index;
                if (firstPlayerTurn && treeIndex.Length < 3)
                {
                    firstScore = 1;
                    score1.Text = firstScore.ToString();
                }
                else if (!firstPlayerTurn && treeIndex.Length < 3)
                {
                    secondScore = 1;
                    score2.Text = secondScore.ToString();
                }
                else InitializeScore();

                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "1" || index == "3" || index == "5" || index == "7")
            {
                pictureBox4.Image = Properties.Resources.pixel;
                index = "4";
                treeIndex = treeIndex + index;
                InitializeScore();
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "2" || index == "4")
            {
                pictureBox5.Image = Properties.Resources.pixel;
                index = "5";
                treeIndex = treeIndex + index;
                InitializeScore();
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "3" || index == "7")
            {
                pictureBox6.Image = Properties.Resources.pixel;
                index = "6";
                treeIndex = treeIndex + index;
                InitializeScore();
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "4" || index == "6")
            {
                pictureBox7.Image = Properties.Resources.pixel;
                index = "7";
                treeIndex = treeIndex + index;
                InitializeScore();
                InitializePixelWaitingTimer();
            }
        }

        private void finishPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "5" || index == "7")
            {
                finishPictureBox.Image = Properties.Resources.pixel;
                index = "f";
                treeIndex = treeIndex + index;
                InitializePixelWaitingTimer();
                InitializeScore();
            }
        }

        private void endPic()
        {
            grid.Visible = false;
            if(winner == 1)
            {
                endPicture.Image = Properties.Resources.end_pic_1;
            }

            if (winner == 2)
            {
                endPicture.Image = Properties.Resources.end_pic_2;
            }

            endPicture.Visible = true;
            restartButton.Visible = true;
        }

        private void restartButton_MouseClick(object sender, MouseEventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            endPicture.Visible = false;
            restartButton.Visible = false;
            grid.Visible = true;
            startPictureBox.Image = Properties.Resources.start;
            pictureBox1.Image = Properties.Resources.pink;
            pictureBox2.Image = Properties.Resources.pink;
            pictureBox3.Image = Properties.Resources.pink;
            pictureBox4.Image = Properties.Resources.pink;
            pictureBox5.Image = Properties.Resources.pink;
            pictureBox6.Image = Properties.Resources.pink;
            pictureBox7.Image = Properties.Resources.pink;
            finishPictureBox.Image = Properties.Resources.pink;
            index = "s";
            treeIndex = "s";
            firstScore = 0;
            score1.Text = firstScore.ToString();
            secondScore = 0;
            score2.Text = secondScore.ToString();
        }

        private void InicializeSolutionPath()
        {
            List<Path> path = new List<Path>();
            foreach(Node n in tree)
            {
                if(n.value == 1)
                {
                    path.Add(new Path { Identificator = n.Identificator, Value = n.value });
                }
            }
        }

        private void CreateTree()
        {
            

            tree.Add(new Node { Identificator = "s", firstChild = "s3", secondChild = "s1", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s3", firstChild = "s36", secondChild = "s34", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s1", firstChild = "s12", secondChild = "s14", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s36", firstChild = "s367", secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s34", firstChild = "s345", secondChild = "s341", thirdChild = "s348", value = 0 });
            tree.Add(new Node { Identificator = "s12", firstChild = "s125", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s14", firstChild = "s147", secondChild = "s145", thirdChild = "s143", value = 1 });
            tree.Add(new Node { Identificator = "s367", firstChild = "s367f", secondChild = "s3674", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s345", firstChild = "s3452", secondChild = "s345f", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s341", firstChild = "s3412", secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s348", firstChild = "s348f", secondChild = "s3487", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s125", firstChild = "s125f", secondChild = "s1254", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s147", firstChild = "s147f", secondChild = "s1475", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s145", firstChild = "s1452", secondChild = "s145f", thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s143", firstChild = "s1436", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s367f", firstChild = null, secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s3674", firstChild = "s36741", secondChild = "s36745", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s3452", firstChild = "s34521", secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s345f", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s3412", firstChild = "s34125", secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s348f", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s3487", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s125f", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s1254", firstChild = "s12543", secondChild = "s12547", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s147f", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s1476", firstChild = "s14763", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s1452", firstChild = null, secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s145f", firstChild = null, secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s1436", firstChild = "s14367", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s36741", firstChild = "s367412", secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s36745", firstChild = "s367452", secondChild = "s36745f", thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s34521", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s34125", firstChild = "s34125f", secondChild = null, thirdChild = null, value = 0 });
            tree.Add(new Node { Identificator = "s12543", firstChild = "s125436", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s12547", firstChild = "s12547f", secondChild = "s125476", thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s14763", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s14367", firstChild = "s14367f", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s367412", firstChild = "s3674125", secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s367452", firstChild = "s3674521", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s36745f", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s34125f", firstChild = null, secondChild = null, thirdChild = null, value = 0});
            tree.Add(new Node { Identificator = "s125436", firstChild = "s1254367", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s12547f", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s125476", firstChild = "s1254763", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s14367f", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s3674125", firstChild = "s3674125f", secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s3674521", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s1254367", firstChild = "s1254367f", secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s1254763", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
            tree.Add(new Node { Identificator = "s3674125f", firstChild = null, secondChild = null, thirdChild = null, value = -1 });
            tree.Add(new Node { Identificator = "s1254367f", firstChild = null, secondChild = null, thirdChild = null, value = 1 });
        }

        public class Node
        {
            public string Identificator { get; set; }
            public string firstChild { get; set; }
            public string secondChild { get; set; }
            public string thirdChild { get; set; }

            public int value { get; set; }

        }

        public class Path
        {
            public string Identificator { get; set; }
            public int Value { get; set; }

        }
    }
}
