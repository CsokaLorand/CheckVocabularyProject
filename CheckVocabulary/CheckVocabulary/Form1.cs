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
        const int checkLevel = 5;
        private DateTime latestCheckTime = DateTime.MaxValue;
        readonly InputData inputData = new InputData();
        readonly Random randomNumber = new Random();

        private List<WordPair> OldestWordPairs(List<WordPair> allWordPair, int wordPairNeeded)
        {
            List<WordPair> returnList = new List<WordPair>();

            List<WordPair> wordPairsCopy = new List<WordPair>(allWordPair);
            int neededWordPairNumber = wordPairNeeded;

            WordPair currentOldestWordPair = new WordPair("","");

            while (returnList.Count < checkLevel)
            {
                for(int i = wordPairsCopy.Count - 1; i >= 0; i--)
                {
                    if (neededWordPairNumber > 0)
                    {
                        string asdweqweq = wordPairsCopy.ElementAt(i).EnglishWord;
                        DateTime qweqweqrtssas = wordPairsCopy.ElementAt(i).CheckDate;

                        if (wordPairsCopy.ElementAt(i).CheckDate <= latestCheckTime)
                        {
                            currentOldestWordPair = wordPairsCopy.ElementAt(i);
                            latestCheckTime = currentOldestWordPair.CheckDate;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                wordPairsCopy.Remove(currentOldestWordPair);
                returnList.Add(currentOldestWordPair);
                neededWordPairNumber--;
                latestCheckTime = DateTime.MaxValue;
            }

            return returnList;
        }

        private void SetHungarianWordTextBoxes()
        {
            List<WordPair> oldestWordpairs = OldestWordPairs(inputData.WordPairs, checkLevel);

            string ateszt1 = oldestWordpairs.ElementAt(0).HungarianWord;
            string ateszt2 = oldestWordpairs.ElementAt(1).HungarianWord;
            string ateszt3 = oldestWordpairs.ElementAt(2).HungarianWord;
            string ateszt4 = oldestWordpairs.ElementAt(3).HungarianWord;
            string ateszt5 = oldestWordpairs.ElementAt(4).HungarianWord;

            hungarianWordTextBox1.Text = oldestWordpairs.ElementAt(0).HungarianWord;
            hungarianWordTextBox2.Text = oldestWordpairs.ElementAt(1).HungarianWord;
            hungarianWordTextBox3.Text = oldestWordpairs.ElementAt(2).HungarianWord;
            hungarianWordTextBox4.Text = oldestWordpairs.ElementAt(3).HungarianWord;
            hungarianWordTextBox5.Text = oldestWordpairs.ElementAt(4).HungarianWord;
        }

        public Form1()
        {
            InitializeComponent();
            SetHungarianWordTextBoxes();
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
            SetHungarianWordTextBoxes();
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
