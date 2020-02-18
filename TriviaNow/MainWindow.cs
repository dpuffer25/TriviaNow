//Dalyno Puffer CIS345 12:00PM Project Final 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class Form1 : Form
    {
        //Declare a BindingList of type question
        BindingList<Question> questionList;

        //Declare variables based on class type / different forms
        UpdateQuestion updateForm;
        Question selectedQuestion;
        QuestionEntry questionForm;
        GameWindow gameForm;
        QuestionSearch questionSearch;


        //Declare and instantiate BinaryFormatter
        BinaryFormatter bf = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();           
        }

        private void QuestionForm_NewQuestionCreated(object sender, Question q)
        {
            // event handler for NewStudentCreated method
            // s is the Student passed as event information

            // Add the newly created Student to the List (not ListBox)
            questionList.Add(q);
        }

        private void UpdateForm_QuestionUpdated(object sender, Question q)
        {
            // reset the bindings so that the listbox updates
            // manual refresh
            questionList.ResetBindings();
        }


        private void questionListBox_DoubleClick(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem == null)
            {
                return;
            }

            // get the question which is currently selected
            selectedQuestion = (Question)questionListBox.SelectedItem;

            // create the form
            updateForm = new UpdateQuestion();

            // register the event handler
            updateForm.QuestionUpdated += new QuestionEntryEvent(this.UpdateForm_QuestionUpdated);

            // show the form and set it to show details of the selected student
            updateForm.PopulateData(selectedQuestion);
            updateForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate BindingList
            //Set datasource property  
            questionList = new BindingList<Question>();
            questionListBox.DataSource = questionList;
            LoadData();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Extension and name of category files
                //.Dat files
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.FileName = "";
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    //open file
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();

                    //Call Deserialize method
                    //Pass to file
                    //store studentList object , downcast bindingList of students
                    questionList = (BindingList<Question>)bf.Deserialize(file);
                    questionListBox.DataSource = questionList;
                    statusLabel.Text = "Data loaded";

                }
            }
            catch (Exception)
            {
                statusLabel.Text = "Data loading not successful";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Extension and name of category files
            //.Dat files
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

            //call ShowDialog method and store into variable
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    //Create file
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, questionList);
                    file.Close();
                    statusLabel.Text = "File saved.";
                }
                catch (Exception)
                {
                    statusLabel.Text = "Save Not successful";
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Instantiate list
            List<Question> selectedQuestions = new List<Question>();

            //Display message if items count < 3
            if(questionListBox.Items.Count < 3)
            {
                MessageBox.Show("Three questions must be added to start game", "Hold your horses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;               
            }

            //Foreach loop
            foreach (Question q in questionListBox.SelectedItems)
            {
                //Add selected questions into selectedQuestion variable
                if(questionListBox.SelectedItems.Count == 3)
                {
                    selectedQuestions.Add(q);
                }
                //Prompt user that only three questions can be selected
                else if(questionListBox.SelectedItems.Count < 3 || questionListBox.SelectedItems.Count > 3)
                {
                    MessageBox.Show("Please select 3 questions.", "Almost there!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            //Pass selectedQuestions into GameWindow form
            //Show form
            gameForm = new GameWindow(selectedQuestions);
            gameForm.Show();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //For loop used to remove at selected index
            for (int i = 0; i < questionList.Count; i++)
            {
                questionList.RemoveAt(i);
                --i;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Instantiate questionForm
            questionForm = new QuestionEntry();

            //call .Show  method to display form
            questionForm.Show();

            //set eventhandler for QuestionCreated event
            questionForm.QuestionCreated += new QuestionEntryEvent(this.QuestionForm_NewQuestionCreated);       
        }

        private void LoadData()
        {
            //Question tmpQuestion = new Question("How many Star Wars movies are there?", "7", "2", "9", "0", "Star Wars fan?", "9");
            //questionList.Add(tmpQuestion);
            //Question tmpQuestion2 = new Question("Who's Luke Skywalker's father?", "Darth Vader", "He has no father.", "Yoda", "Jedi Gods", "Nooooo! Thats not true. Thats impossible!!", "Darth Vader");
            //questionList.Add(tmpQuestion2);
            //Question tmpQuestion3 = new Question("Who killed the Emperor?", "Luke Skywalker", "Darth Vader", "He's still alive?!", "Princess Leia", "I've been expecting you", "");
            //questionList.Add(tmpQuestion3);
            //Question tmpQuestion4 = new Question("What color is Mace Windu's lightsaber?", "Red", "Green", "Purple", "Blue", "Feel the force, motherf***er?", "Purple");
            //questionList.Add(tmpQuestion4);
            //Question tmpQuestion5 = new Question("What is R2-D2's name often shorted to?", "D2", "R2", "RD", "R2-D", "Beep Beep Beep Boop", "R2");
            //questionList.Add(tmpQuestion5);
            //Question tmpQuestion6 = new Question("What species is Jabba?", "Jawa", "Alien", "Kobok", "Hutt", "There will be no bargain, my young Jedi. I shall enjoy watching you die", "Hutt");
            //questionList.Add(tmpQuestion6);
            //Question tmpQuestion7 = new Question("Which furry species lives on the forest moon of Endor?", "Ewoks", "Wookiees", "Trandoshans", "Tusken Raiders ", "That was an easy one :)", "Ewoks");
            //questionList.Add(tmpQuestion7);
            //Question tmpQuestion8 = new Question("Who originally played Han Solo?", "Mel Gibson", "Sylvester Stallone", "James Brolin", "Harrison Ford", "Listen, big deal. You got another problem. Women always figure out the truth. Always", "Harrison Ford");
            //questionList.Add(tmpQuestion8);
            //Question tmpQuestion9 = new Question("Who built C-3PO?", "Luke Skywalker", "Young Anakin", "Yoda", "Obi-Wan", "Die, Jedi dogs. Oh... what did I say?", "Young Anakin");
            //questionList.Add(tmpQuestion9);
            //Question tmpQuestion10 = new Question("Who is Boba Fett’s father?", "Bango Fett", "Dango Fett", "Rango Fett", "Jango Fett", "He's no good to me dead", "Jango Fett");
            //questionList.Add(tmpQuestion10);
        }

        private void questionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questionSearch = new QuestionSearch(questionList);
            questionSearch.Show();
        }
    }
}
