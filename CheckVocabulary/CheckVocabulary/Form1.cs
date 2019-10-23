using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CheckVocabulary
{
    public partial class Form1 : Form
    {
        readonly InputData inputData = new InputData();
        readonly Random randomNumber = new Random();

        private void SelectWords()
        {
            int indexOfWordPair1 = randomNumber.Next(0, inputData.WordPairs.Count);
            hungarianWordTextBox1.Text = inputData.WordPairs.ElementAt(indexOfWordPair1).HungarianWord;

            int indexOfWordPair2 = randomNumber.Next(0, inputData.WordPairs.Count);
            while (indexOfWordPair2 == indexOfWordPair1)
            {
                indexOfWordPair2 = randomNumber.Next(0, inputData.WordPairs.Count);
            }
            hungarianWordTextBox2.Text = inputData.WordPairs.ElementAt(indexOfWordPair2).HungarianWord;

            int indexOfWordPair3 = randomNumber.Next(0, inputData.WordPairs.Count);
            while (indexOfWordPair3 == indexOfWordPair1 || indexOfWordPair3 == indexOfWordPair2)
            {
                indexOfWordPair2 = randomNumber.Next(0, inputData.WordPairs.Count);
            }
            hungarianWordTextBox3.Text = inputData.WordPairs.ElementAt(indexOfWordPair3).HungarianWord;

            int indexOfWordPair4 = randomNumber.Next(0, inputData.WordPairs.Count);
            while (indexOfWordPair4 == indexOfWordPair1 || indexOfWordPair4 == indexOfWordPair2
                    || indexOfWordPair4 == indexOfWordPair3)
            {
                indexOfWordPair4 = randomNumber.Next(0, inputData.WordPairs.Count);
            }
            hungarianWordTextBox4.Text = inputData.WordPairs.ElementAt(indexOfWordPair4).HungarianWord;

            int indexOfWordPair5 = randomNumber.Next(0, inputData.WordPairs.Count);
            while (indexOfWordPair5 == indexOfWordPair1 || indexOfWordPair5 == indexOfWordPair2
                    || indexOfWordPair5 == indexOfWordPair3 || indexOfWordPair5 == indexOfWordPair4)
            {
                indexOfWordPair5 = randomNumber.Next(0, inputData.WordPairs.Count);
            }
            hungarianWordTextBox5.Text = inputData.WordPairs.ElementAt(indexOfWordPair5).HungarianWord;
        }

        public Form1()
        {
            InitializeComponent();
            SelectWords();
        }

        private void Show_button1_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if (currentWordPair.HungarianWord == hungarianWordTextBox1.Text)
                {
                    englishWordTextBox1.Text = currentWordPair.EnglishWord;
                }
            }
        }

        private void Show_button2_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if (currentWordPair.HungarianWord == hungarianWordTextBox2.Text)
                {
                    englishWordTextBox2.Text = currentWordPair.EnglishWord;
                }
            }
        }

        private void Show_button3_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if (currentWordPair.HungarianWord == hungarianWordTextBox3.Text)
                {
                    englishWordTextBox3.Text = currentWordPair.EnglishWord;
                }
            }
        }

        private void Show_button4_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if (currentWordPair.HungarianWord == hungarianWordTextBox4.Text)
                {
                    englishWordTextBox4.Text = currentWordPair.EnglishWord;
                }
            }
        }

        private void Show_button5_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if (currentWordPair.HungarianWord == hungarianWordTextBox5.Text)
                {
                    englishWordTextBox5.Text = currentWordPair.EnglishWord;
                }
            }
        }

        private void Check_button_clicked(object sender, EventArgs e)
        {
            foreach (WordPair currentWordPair in inputData.WordPairs)
            {
                if ((currentWordPair.HungarianWord == hungarianWordTextBox1.Text)
                    && (currentWordPair.EnglishWord == englishWordTextBox1.Text))
                {
                    pictureBox1.Image = Properties.Resources.Ok_icon;
                    currentWordPair.CheckDate = DateTime.Now;
                }

                if ((currentWordPair.HungarianWord == hungarianWordTextBox2.Text)
                    && (currentWordPair.EnglishWord == englishWordTextBox2.Text))
                {
                    pictureBox2.Image = Properties.Resources.Ok_icon;
                    currentWordPair.CheckDate = DateTime.Now;
                }

                if ((currentWordPair.HungarianWord == hungarianWordTextBox3.Text)
                    && (currentWordPair.EnglishWord == englishWordTextBox3.Text))
                {
                    pictureBox3.Image = Properties.Resources.Ok_icon;
                    currentWordPair.CheckDate = DateTime.Now;
                }

                if ((currentWordPair.HungarianWord == hungarianWordTextBox4.Text)
                    && (currentWordPair.EnglishWord == englishWordTextBox4.Text))
                {
                    pictureBox4.Image = Properties.Resources.Ok_icon;
                    currentWordPair.CheckDate = DateTime.Now;
                }

                if ((currentWordPair.HungarianWord == hungarianWordTextBox5.Text)
                    && (currentWordPair.EnglishWord == englishWordTextBox5.Text))
                {
                    pictureBox5.Image = Properties.Resources.Ok_icon;
                    currentWordPair.CheckDate = DateTime.Now;
                }
            }

            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Properties.Resources.Close_2_icon;
            }
            if (pictureBox2.Image == null)
            {
                pictureBox2.Image = Properties.Resources.Close_2_icon;
            }
            if (pictureBox3.Image == null)
            {
                pictureBox3.Image = Properties.Resources.Close_2_icon;
            }
            if (pictureBox4.Image == null)
            {
                pictureBox4.Image = Properties.Resources.Close_2_icon;
            }
            if (pictureBox5.Image == null)
            {
                pictureBox5.Image = Properties.Resources.Close_2_icon;
            }
        }

        private void Show_all_button_clicked(object sender, EventArgs e)
        {
            Show_button1_clicked(sender, e);
            Show_button2_clicked(sender, e);
            Show_button3_clicked(sender, e);
            Show_button4_clicked(sender, e);
            Show_button5_clicked(sender, e);
        }

        private void Next_button_clicked(object sender, EventArgs e)
        {
            SelectWords();
            englishWordTextBox1.Text = "";
            englishWordTextBox2.Text = "";
            englishWordTextBox3.Text = "";
            englishWordTextBox4.Text = "";
            englishWordTextBox5.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
        }
    }
}
