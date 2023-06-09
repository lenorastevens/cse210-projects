using System;
using static System.Console;

namespace Mindfulness
{
    class ReflectionActivity: Activity
    {
        //Private lists for the Reflection class
        private List<string> _reflectPrompt;
        private List<string> _reflectQuestion;


        //Constructor for the reflection class. Holds the lists for the class and variables from Activity class.
        public ReflectionActivity(string activity, string description) : base(activity, description)
        {
            _reflectPrompt = new List<string>();
            _reflectQuestion = new List<string>();
        }


        // The function creates two lists of prompts and questions for reflection.
        private void CreateReflectionLists()
        {
            _reflectPrompt.Add(new string("Think of a time when you did something really difficult."));
            _reflectPrompt.Add(new string("Think of a time when you stood up for someone else."));
            _reflectPrompt.Add(new string("Think of a time when you helped someone in need."));
            _reflectPrompt.Add(new string("Think of a time when you did something truly selfless."));
            _reflectPrompt.Add(new string("Think of a time when you changed."));
            
            _reflectQuestion.Add(new string("Why was this experience meaningful to you?"));
            _reflectQuestion.Add(new string("Have you ever done anything like this before?"));
            _reflectQuestion.Add(new string("How did you get started?"));
            _reflectQuestion.Add(new string("How did you feel when it was complete?"));
            _reflectQuestion.Add(new string("What made this time different than other times when you were not as successful?"));
            _reflectQuestion.Add(new string("What is your favorite thing about this experience?"));
            _reflectQuestion.Add(new string("What could you learn from this experience that applies to other situations?"));
            _reflectQuestion.Add(new string("What did you learn about yourself through this experience?"));
            _reflectQuestion.Add(new string("How can you keep this experience in mind in the future?"));
        }


        // This function displays a random reflection prompt and waits for user input to begin reflecting.        
        public void DisplayReflectionPrompt()
        {
            CreateReflectionLists();
            WriteLine("");
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"**Reflection Prompt: {_reflectPrompt[GetRandomPromptIndex(_reflectPrompt.Count)]}**");
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nWhen you have something in mind, press any key to begin...");
            ReadKey();
            PauseTime("Start reflecting... ");
        }


        // The function displays and hides questions and pauses for a moment.
        public void PonderQuestions()
        {
            WriteLine("");                   
            ShowAndHideQuestions();
            CountDown(10);                            
        }


        // This function randomly selects and displays a question from a list, and removes it from the list.
        private void ShowAndHideQuestions()
        {
            //sets the random index to be used
            int index = GetRandomPromptIndex(_reflectQuestion.Count);
           
            //Displays question and then removes it from the list
            WriteLine($"\n>{_reflectQuestion[index]}");  
            _reflectQuestion.RemoveAt(index);   
        }
    }


}