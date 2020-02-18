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
    //Custom delegate to pass question objects
    public delegate void QuestionEntryEvent(object sender, Question q);
    

    public partial class QuestionEntry : Form
    {
        //QuestionCeated event
        public event QuestionEntryEvent QuestionCreated;
        private string correctAnswer;

        public QuestionEntry()
        {
            InitializeComponent();
        }


        private void QuestionEntry_Load(object sender, EventArgs e)
        {
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //If any Texbox is empty
            //Show message
            if (questionTextBox.Text == String.Empty || answer1TextBox.Text == String.Empty || answer2TextBox.Text == String.Empty || answer3TextBox.Text == String.Empty || answer4TextBox.Text == String.Empty || feedbackTextBox.Text == String.Empty)
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }

            //Array of radio buttons
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
            else if(radioButtonB.Checked)
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

            //Raise QuestionCreated event
            QuestionCreated(this, tmpQuestion);
         

            //Clear all textboxes
            //Focus on beginning textbox
            questionTextBox.Clear();
            answer1TextBox.Clear();
            answer2TextBox.Clear();
            answer3TextBox.Clear();
            answer4TextBox.Clear();
            feedbackTextBox.Clear();
            questionTextBox.Focus();
        }
    }
}
