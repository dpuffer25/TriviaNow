//Dalyno Puffer CIS345 12:00PM Project Final 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class GameWindow : Form
    {
        //initial variables
        List<Question> questionList = new List<Question>();
        private string correctAnswer;
        private string message;
        private int totalScore;
        private int submissions;
        private int questions = 1;

        SoundPlayer soundPlayer;
        SoundPlayer sP;


        //Overloaded constructor
        //Type list
        public GameWindow(List<Question> list)
        {         
            InitializeComponent();
            questionList = list;
            DisplayNextQuestion();
        }

        public GameWindow()
        {
            InitializeComponent();
        }


        private void GameWindow_Load(object sender, EventArgs e)
        {
            //load soundplayer
            soundPlayer = new SoundPlayer("imperial_march.wav");
            soundPlayer.Load();
            soundPlayer.PlayLooping();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Array of radioButtons
            RadioButton[] radioButtons = new RadioButton[] { radioButtonA, radioButtonB, radioButtonC, radioButtonD };

            //If a radiobutton isnt checked
            if (!radioButtons.Any(rb => rb.Checked))
            {
                MessageBox.Show("Please select an answer");
                return;
            }

            //Foreach loop
            foreach(RadioButton r in radioButtons)
            {
                //If user selects correctAnswer
                //Add score / increment submissions
                //Show MessageBox
                if(r.Checked && r.Text == correctAnswer)
                {
                    MessageBox.Show($"Correct! \n\n\"{message}\"", "Good Job :)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    totalScore = totalScore + 1;
                    correctScoreLabel.Text = Convert.ToString(totalScore);
                    submissions++;                  
                }
                //If user selects wrong answer
                //Increment submissions
                //Show MessageBox
                else if(r.Checked && r.Text != correctAnswer)
                {
                    MessageBox.Show("Wrong answer!", "Sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    submissions++;                   
                }
            }

            //Once submissions = 3
            //Close GameWindow form
            //Display message
            if (submissions == 3)
            {
                Close();
                soundPlayer.Stop();
                MessageBox.Show($"Thank you for playing my game!\nYour total score was {totalScore}/3! v", "Game Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                sP = new SoundPlayer("force.wav");
                sP.Load();
                sP.Play();

            }
            else
            {
                //Method
                questions++;
                questionsLeftNum.Text = Convert.ToString(questions);
                DisplayNextQuestion();
            }
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void DisplayNextQuestion()
        {
            //Initial Variables
            Random randomGenerator = new Random();
            int index;
            Question tmpQuestion;

            //Set index to randomGenerator 
            //Min = 0 / Max = questionList count
            index = randomGenerator.Next(0, questionList.Count);

            //Set tmpQuestion to ElementAt(index)
            tmpQuestion = questionList.ElementAt(index);

            //Display the tmpQuestion components
            questionLabel.Text = tmpQuestion.Questions;
            radioButtonA.Text = tmpQuestion.A;
            radioButtonB.Text = tmpQuestion.B;
            radioButtonC.Text = tmpQuestion.C;
            radioButtonD.Text = tmpQuestion.D;
            correctAnswer = tmpQuestion.CorrectChoice;
            message = tmpQuestion.Feedback;

            //Remove question from index
            questionList.RemoveAt(index);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
