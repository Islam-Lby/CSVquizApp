using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVquizApp
{
    public partial class Form1 : Form
    {
        private string[] questions;
        private string[,] options;
        private string[] correctAnswers;
        private int currentQuestion = 0;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            LoadQuestionsFromCSV();
            ShowQuestion();
        }
      
        public void LoadQuestionsFromCSV()
        {
            try
            {
                string[] lines = File.ReadAllLines("Compression_Encryption_and_hashing.csv");
                if (lines[0].StartsWith("Question"))
                {
                    lines = lines.Skip(1).ToArray();
                }
                questions = new string[lines.Length];
                options = new string[lines.Length, 4];
                correctAnswers = new string[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split(',');
                    questions[i] = columns[0];
                    options[i,0] = columns[1];
                    options[i,1] = columns[2];
                    options[i,2] = columns[3];
                    options[i,3] = columns[4];
                }
            }
            catch
            {
                MessageBox.Show($"Error loading questions");
                Environment.Exit(1);
            }

        }

        public void ShowQuestion()
        {
            if (currentQuestion >= questions.Length)
            {
                lblQuestion.Text = $"Quiz complete! Score = {score}/{questions.Length}";
                rbOptionA.Visible = false;
                rbOptionB.Visible = false;
                rbOptionC.Visible = false;
                rbOptionD.Visible = false;
                return;
            }
            lblQuestion.Text =$"Question {currentQuestion+1}/{questions.Length}:{questions[currentQuestion]}";
            rbOptionA.Text = options[currentQuestion,0];
            rbOptionB.Text = options[currentQuestion,1];
            rbOptionC.Text = options[currentQuestion,2];
            rbOptionD.Text = options[currentQuestion,3];
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                currentQuestion++;
                ShowQuestion();
            
        }
    }
}
