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
    public partial class QuestionSearch : Form
    {
        //initial variables
        BindingList<Question> questionList;
        UpdateQuestion updateForm;
        Question selectedQuestion;

        public QuestionSearch()
        {
            InitializeComponent();
        }

        public QuestionSearch(BindingList<Question> bindingList)
        {
            //set datasource
            InitializeComponent();
            questionList = bindingList;
            searchListBox.DataSource = questionList;            
        }

        private void QuestionSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchListBox.SelectedItems.Clear();

            //for loop
            //If items contain whats in the textbox
            //highlight it
            for(int i = 0; i < searchListBox.Items.Count; i++)
            {
                if(searchListBox.Items[i].ToString().ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    searchListBox.SetSelected(i, true);
                }
            }
        }

        private void searchListBox_DoubleClick(object sender, EventArgs e)
        {
            if (searchListBox.SelectedItem == null)
            {
                return;
            }

            // get the question which is currently selected
            selectedQuestion = (Question)searchListBox.SelectedItem;

            // create the form
            updateForm = new UpdateQuestion();

            // register the event handler
            updateForm.QuestionUpdated += new QuestionEntryEvent(this.UpdateForm_QuestionUpdated);

            // show the form and set it to show details of the selected student
            updateForm.PopulateData(selectedQuestion);
            updateForm.Show();
        }

        private void UpdateForm_QuestionUpdated(object sender, Question q)
        {
            // reset the bindings so that the listbox updates
            // manual refresh
            questionList.ResetBindings();
        }
    }
}
