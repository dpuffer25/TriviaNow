//Dalyno Puffer CIS345 12:00PM Project Final 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    //Allow object to be saved as bytes
    //Save function
    [Serializable]
    public class Question
    {
        //Question class variables
        private string questions;
        private string a;
        private string b;
        private string c;
        private string d;
        private string correctChoice;
        private string feedback;

        //Constructor
        public Question(string questions, string a, string b, string c, string d, string feedback, string correctChoice)
        {
            this.questions = questions;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.feedback = feedback;
            this.correctChoice = correctChoice;
        }

        //Properties
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string Questions { get => questions; set => questions = value; }
        public string CorrectChoice { get => correctChoice; set => correctChoice = value; }
        public string Feedback { get => feedback; set => feedback = value; }

        //ToString method, display question title.
        public override string ToString()
        {
            return Questions;
        }
    }
}
