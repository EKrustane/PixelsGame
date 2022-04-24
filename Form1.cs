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
        int winner = 1; //pagaidām
        string index = "s";
        string treeIndex;
        Timer pixelWaitingTimer = new Timer();

        public Form()
        {
            InitializeComponent();
            CreateTree();
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
            treeIndex = treeIndex + index;
            if (index == "f")
            {
                endPic();
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
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "1" || index == "5")
            {
                pictureBox2.Image = Properties.Resources.pixel;
                index = "2";
                InitializePixelWaitingTimer();
            }    
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "s" || index == "4" || index == "6")
            {
                pictureBox3.Image = Properties.Resources.pixel;
                index = "3";
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "1" || index == "3" || index == "5" || index == "7")
            {
                pictureBox4.Image = Properties.Resources.pixel;
                index = "4";
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "2" || index == "4")
            {
                pictureBox5.Image = Properties.Resources.pixel;
                index = "5";
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "3" || index == "7")
            {
                pictureBox6.Image = Properties.Resources.pixel;
                index = "6";
                InitializePixelWaitingTimer();
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "4" || index == "6")
            {
                pictureBox7.Image = Properties.Resources.pixel;
                index = "7";
                InitializePixelWaitingTimer();
            }
        }

        private void finishPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == "5" || index == "7")
            {
                finishPictureBox.Image = Properties.Resources.pixel;
                index = "f";
                InitializePixelWaitingTimer();
            }
        }

        private void endPic()
        {   
            if(winner == 1)
            {
                endPicture.Image = Properties.Resources.end_pic_1;
            }

            if (winner == 2)
            {
                endPicture.Image = Properties.Resources.end_pic_2;
            }

            endPicture.Visible = true;
        }

        private void CreateTree()
        {
            List<Node> tree = new List<Node>();

            tree.Add(new Node { Identificator = "s", firstChild = "s3", secondChild = "s1", thirdChild = null });
            tree.Add(new Node { Identificator = "s3", firstChild = "s36", secondChild = "s34", thirdChild = null });
            tree.Add(new Node { Identificator = "s1", firstChild = "s12", secondChild = "s14", thirdChild = null });
            tree.Add(new Node { Identificator = "s36", firstChild = "s367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s34", firstChild = "s345", secondChild = "s341", thirdChild = "s348" });
            tree.Add(new Node { Identificator = "s12", firstChild = "s125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s14", firstChild = "s147", secondChild = "s145", thirdChild = "s143" });
            tree.Add(new Node { Identificator = "s367", firstChild = "s367f", secondChild = "s3674", thirdChild = null });
            tree.Add(new Node { Identificator = "s345", firstChild = "s3452", secondChild = "s345f", thirdChild = null });
            tree.Add(new Node { Identificator = "s341", firstChild = "s3412", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s348", firstChild = "s348f", secondChild = "s3487", thirdChild = null });
            tree.Add(new Node { Identificator = "s125", firstChild = "s125f", secondChild = "s1254", thirdChild = null });
            tree.Add(new Node { Identificator = "s147", firstChild = "s147f", secondChild = "s1475", thirdChild = null });
            tree.Add(new Node { Identificator = "s145", firstChild = "s1452", secondChild = "s145f", thirdChild = null });
            tree.Add(new Node { Identificator = "s143", firstChild = "s1436", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s367f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3674", firstChild = "s36741", secondChild = "s36745", thirdChild = null });
            tree.Add(new Node { Identificator = "s3452", firstChild = "s34521", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s345f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3412", firstChild = "s34125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s348f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3487", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1254", firstChild = "s12543", secondChild = "s12547", thirdChild = null });
            tree.Add(new Node { Identificator = "s147f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1476", firstChild = "s14763", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1452", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s145f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1436", firstChild = "s14367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s36741", firstChild = "s367412", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s36745", firstChild = "s367452", secondChild = "s36745f", thirdChild = null });
            tree.Add(new Node { Identificator = "s34521", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s34125", firstChild = "s34125f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s12543", firstChild = "s125436", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s12547", firstChild = "s12547f", secondChild = "s125476", thirdChild = null });
            tree.Add(new Node { Identificator = "s14763", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s14367", firstChild = "s14367f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s367412", firstChild = "s3674125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s367452", firstChild = "s3674521", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s36745f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s34125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s125436", firstChild = "s1254367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s12547f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s125476", firstChild = "s1254763", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s14367f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3674125", firstChild = "s3674125f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3674521", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1254367", firstChild = "s1254367f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1254763", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s3674125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "s1254367f", firstChild = null, secondChild = null, thirdChild = null });
        }
        public class Node
        {
            public string Identificator { get; set; }
            public string firstChild { get; set; }
            public string secondChild { get; set; }
            public string thirdChild { get; set; }

        }
    }
}
