//Dalyno Puffer CIS345 12:00PM Project Final 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class UpdateQuestion : Form
    {
        //QuestionUpdated event
        public event QuestionEntryEvent QuestionUpdated;
        private Question currentQuestion;
        private string correctAnswer;

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        public void PopulateData(Question question)
        {

            //current question = object of the populated data
            currentQuestion = question;

            //Set textbox text to the values of the question object
            questionTextBox.Text = question.Questions;
            answer1TextBox.Text = question.A;
            answer2TextBox.Text = question.B;
            answer3TextBox.Text = question.C;
            answer4TextBox.Text = question.D;
            feedbackTextBox.Text = question.Feedback;
            correctAnswer = question.CorrectChoice;

            //Label what correct answer is chosen based off selected question
            currentCorrectAnswerLabel.Text = correctAnswer;
          
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //If any Texbox is empty
            //Show message
            if (questionTextBox.Text == String.Empty || answer1TextBox.Text == String.Empty || answer2TextBox.Text == String.Empty || answer3TextBox.Text == String.Empty || answer4TextBox.Text == String.Empty || feedbackTextBox.Text == String.Empty)
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }

            //Array of radioButtons
            RadioButton[] radioButtons = new RadioButton[] { radioButtonA, radioButtonB, radioButtonC, radioButtonD };

            //If a radio button is not selected
            //Show message
            if (!radioButtons.Any(rb => rb.Checked))
            {
                MessageBox.Show("Please select a correct answer");
                return;
            }

            //If else loop
            //Based on which radio button is selected, if that button is selected
            //correct answer = corresponding textbox
            if (radioButtonA.Checked)
            {
                correctAnswer = answer1TextBox.Text;
            }
            else if (radioButtonB.Checked)
            {
                correctAnswer = answer2TextBox.Text;
            }
            else if (radioButtonC.Checked)
            {
                correctAnswer = answer3TextBox.Text;
            }
            else if (radioButtonD.Checked)
            {
                correctAnswer = answer4TextBox.Text;
            }
            //Create new question object based on user input
            Question tmpQuestion = new Question(questionTextBox.Text, answer1TextBox.Text, answer2TextBox.Text, answer3TextBox.Text, answer4TextBox.Text, feedbackTextBox.Text, correctAnswer);

            //currentQuetion variables now equal the new inputed data
            currentQuestion.Questions = questionTextBox.Text;
            currentQuestion.A = answer1TextBox.Text;
            currentQuestion.B = answer2TextBox.Text;
            currentQuestion.C = answer3TextBox.Text;
            currentQuestion.D = answer4TextBox.Text;
            currentQuestion.Feedback = feedbackTextBox.Text;
            currentQuestion.CorrectChoice = correctAnswer;

            //Raise QuestionUpdated event appropiately
            if (QuestionUpdated != null)
                QuestionUpdated(this, tmpQuestion);

            //Close form
            this.Close();
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
