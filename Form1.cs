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
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NextMove()
        {


        }

        private void Main()
        {
            List<Node> tree = new List<Node>();

            tree.Add(new Node { Identificator = "0", firstChild = "3", secondChild = "1", thirdChild = null });
            tree.Add(new Node { Identificator = "3", firstChild = "36", secondChild = "34", thirdChild = null });
            tree.Add(new Node { Identificator = "1", firstChild = "12", secondChild = "14", thirdChild = null });
            tree.Add(new Node { Identificator = "36", firstChild = "367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "34", firstChild = "345", secondChild = "341", thirdChild = "348" });
            tree.Add(new Node { Identificator = "12", firstChild = "125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "14", firstChild = "147", secondChild = "145", thirdChild = "143" });
            tree.Add(new Node { Identificator = "367", firstChild = "367f", secondChild = "3674", thirdChild = null });
            tree.Add(new Node { Identificator = "345", firstChild = "3452", secondChild = "345f", thirdChild = null });
            tree.Add(new Node { Identificator = "341", firstChild = "3412", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "348", firstChild = "348f", secondChild = "3487", thirdChild = null });
            tree.Add(new Node { Identificator = "125", firstChild = "125f", secondChild = "1254", thirdChild = null });
            tree.Add(new Node { Identificator = "147", firstChild = "147f", secondChild = "1475", thirdChild = null });
            tree.Add(new Node { Identificator = "145", firstChild = "1452", secondChild = "145f", thirdChild = null });
            tree.Add(new Node { Identificator = "143", firstChild = "1436", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "367f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3674", firstChild = "36741", secondChild = "36745", thirdChild = null });
            tree.Add(new Node { Identificator = "3452", firstChild = "34521", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "345f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3412", firstChild = "34125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "348f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3487", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1254", firstChild = "12543", secondChild = "12547", thirdChild = null });
            tree.Add(new Node { Identificator = "147f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1476", firstChild = "14763", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1452", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "145f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1436", firstChild = "14367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "36741", firstChild = "367412", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "36745", firstChild = "367452", secondChild = "36745f", thirdChild = null });
            tree.Add(new Node { Identificator = "34521", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "34125", firstChild = "34125f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "12543", firstChild = "125436", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "12547", firstChild = "12547f", secondChild = "125476", thirdChild = null });
            tree.Add(new Node { Identificator = "14763", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "14367", firstChild = "14367f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "367412", firstChild = "3674125", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "367452", firstChild = "3674521", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "36745f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "34125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "125436", firstChild = "1254367", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "12547f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "125476", firstChild = "1254763", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "14367f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3674125", firstChild = "3674125f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3674521", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1254367", firstChild = "1254367f", secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1254763", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "3674125f", firstChild = null, secondChild = null, thirdChild = null });
            tree.Add(new Node { Identificator = "1254367f", firstChild = null, secondChild = null, thirdChild = null });

        }

        private static void InitializeOne()
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pixel;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.pixel;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.pixel;
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.pixel;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Properties.Resources.pixel;
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Properties.Resources.pixel;
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.pixel;
        }

        private void finishPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            finishPictureBox.Image = Properties.Resources.pixel;
        }
    }

    public class Node
    {
        public string Identificator { get; set; }
        public string firstChild { get; set; }
        public string secondChild { get; set; }
        public string thirdChild { get; set; }


    }


}
