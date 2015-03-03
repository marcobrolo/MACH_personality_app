using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MachTest5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private String Question = "The best way to earn someone's respect is to be kind and honest.";
        private List<String> QuestionList = new List<string>();
        private List<String> QuestionAnswer = new List<string>();
        private int QuestionCounter;
        private static int MaxQuestionsCount = 10;
        private int ScoreTotal = 0;
        private string TypeResult ="";

        public MainPage()
        {
            QuestionCounter = 1;
            QuestionList.Add("Most people are honest.");
            QuestionList.Add("It is possible to be good in all respects.");
            QuestionList.Add("It is hard to get ahead without cutting corners here and there.");
            QuestionList.Add("The best way to earn someone's respect is to be kind and honest.");
            QuestionList.Add("The best way to earn someone's loyalty is show him/her your power.");
            QuestionList.Add("There are no absolute rights and wrongs. \"Right\" is what works.");
            QuestionList.Add("A good president reads the polls to find out what people want and makes those things his/her policies.");
            QuestionList.Add("Most people are extremely selfish.");
            QuestionList.Add("A promise is a sacred trust.");
            QuestionList.Add("Nice guys finish last.");

            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");
            QuestionAnswer.Add("Null");


            this.InitializeComponent();

            this.NavigationCacheMode =
        Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void Question1Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 1;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }

        private void AgreeClick(object sender, RoutedEventArgs e)
        {
            QuestionAnswer[QuestionCounter - 1] = "Agree";
        }

        private void DisagreeClick(object sender, RoutedEventArgs e)
        {
            QuestionAnswer[QuestionCounter - 1] = "Disagree";
        }

        private void UndecidedClick(object sender, RoutedEventArgs e)
        {
            QuestionAnswer[QuestionCounter - 1] = "Undecided";
        }

        private void Question2Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 2;
            QuestionBox.Text = QuestionList[QuestionCounter-1];
            UIUpdate();
        }

        private void Question3Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 3;
            QuestionBox.Text = QuestionList[QuestionCounter-1];
            UIUpdate();
        }
        private void Question4Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 4;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question5Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 5;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question6Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 6;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question7Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 7;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question8Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 8;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question9Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 9;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();
        }
        private void Question10Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 10;
            QuestionBox.Text = QuestionList[QuestionCounter - 1];
            UIUpdate();

        }

        private void NextQuestionButtonClick(object sender, RoutedEventArgs e)
        {
            if (QuestionCounter != MaxQuestionsCount)
            {
                QuestionCounter += 1;
                QuestionBox.Text = QuestionList[QuestionCounter-1];
            }
            else if (QuestionCounter == MaxQuestionsCount && NextQuestionButton.Content.ToString() == "FINISH")
            {
                //End survey
                FinishPage();
            }

            UIUpdate();

        }

        private void PreviousQuestionButtonClick(object sender, RoutedEventArgs e)
        {
            if (QuestionCounter != 1)
            {
                QuestionCounter -= 1;
                QuestionBox.Text = QuestionList[QuestionCounter - 1];
            }

            UIUpdate();

        }

        /*
         * 
         * UPDATES BUTTONS TO CORRESPOND TO CURRENT STATE OF THE SURVEY
         * 
         */ 
        private void UIUpdate()
        {
            AssignProperAnswerKey();
            UpdateTraversalBTN();
        }

        /*
         * 
         * MAKES SURE THE TRAVERSAL BUTTONS ARE DISABLED WHEN SURVEY IS OVER AND
         * BTN TEXT CORRESPONDS TO THE CURRENT QUESTIONS (IE LAST QUESTION THEN NEXT
         * BTN SHOULD SAY FINISH)
         * 
         */ 
        private void UpdateTraversalBTN()
        {
            if (QuestionCounter == MaxQuestionsCount)
            {
                NextQuestionButton.Content = "FINISH";
            }
            else if (QuestionCounter == 1)
            {
                PreviousQuestionButton.IsEnabled = false;
            }
            else
            {
                PreviousQuestionButton.IsEnabled = true;
                NextQuestionButton.Content = "Next Question";
            }
        }

        /*
         * 
         * WHEN TRAVERSING THROUGH QUESTIONS, MAKE SURE SURVEY REMEMBERS WHAT USER'S SELECTION WAS
         * FOR THAT QUESTION. IF THERE IS NO SELECTION MAKE SURE BUTTONS ARE NOT SELECTED
         * 
         */ 
        private void AssignProperAnswerKey()
        {
            if (QuestionAnswer[QuestionCounter-1] == "Null")
            {
                AgreeButton.IsChecked = false;
                DisagreeButton.IsChecked = false;
                UndecidedButton.IsChecked = false;
            }
            else if (QuestionAnswer[QuestionCounter-1] == "Agree")
            {
                AgreeButton.IsChecked = true;
                DisagreeButton.IsChecked = false;
                UndecidedButton.IsChecked = false;
            }
            else if (QuestionAnswer[QuestionCounter - 1] == "Disagree")
            {
                AgreeButton.IsChecked = false;
                DisagreeButton.IsChecked = true;
                UndecidedButton.IsChecked = false;
            }
            else if (QuestionAnswer[QuestionCounter - 1] == "Undecided")
            {
                AgreeButton.IsChecked = false;
                DisagreeButton.IsChecked = false;
                UndecidedButton.IsChecked = true;
            }
        }

        /*
         * 
         * DISABLE THE QUICK LINKS BUTTONS ON THE SIDE, USED WHEN SURVEY IS OVER
         * 
         */ 
        private void DisableQuestionJumpBTN()
        {
            Question1QuickLink.IsEnabled = false;
            Question2QuickLink.IsEnabled = false;
            Question3QuickLink.IsEnabled = false;
            Question4QuickLink.IsEnabled = false;
            Question5QuickLink.IsEnabled = false;
            Question6QuickLink.IsEnabled = false;
            Question7QuickLink.IsEnabled = false;
            Question8QuickLink.IsEnabled = false;
            Question9QuickLink.IsEnabled = false;
            Question10QuickLink.IsEnabled = false;
        }

        /*
         * 
         * DISABLE THE ANSWER SELECTION BUTTONS, USED WHEN SURVEY IS OVER
         * 
         */ 
        private void DisableAnswerSelectionBTN()
        {
            AgreeButton.IsChecked = false;
            DisagreeButton.IsChecked = false;
            UndecidedButton.IsChecked = false;

            AgreeButton.IsEnabled = false;
            DisagreeButton.IsEnabled = false;
            UndecidedButton.IsEnabled = false;

        }

        /*
         * 
         * HANDLES LOGIC WHEN FINISHED BTN IS CLICKED
         * 
         */ 
        private void FinishPage()
        {
            NextQuestionButton.IsEnabled = false;
            PreviousQuestionButton.IsEnabled = false;
            DisableQuestionJumpBTN();
            DisableAnswerSelectionBTN();
            CalculateResultTotal();
            QuestionBox.Text = TypeResult + ScoreTotal.ToString();
        }

        /*
         * 
         * CALCULATE THE SCORE BEFORE GIVING USER FINAL RESULT
         * 
         */ 
        private void CalculateResultTotal()
        {
            for (int i =0; i<=QuestionAnswer.Count()-1 ;i++)
            {
                if (QuestionAnswer[i].ToString() == "Undecided")
                {
                    ScoreTotal += 3;
                }
                else if (i == 0 || i==1 || i==3 || i==6)
                {
                    if (QuestionAnswer[i].ToString() == "Agree")
                    {
                        ScoreTotal += 1;
                    }
                    else if (QuestionAnswer[i].ToString() == "Disagree")
                    {
                        ScoreTotal += 5;
                    }
                }
                else
                {
                    if (QuestionAnswer[i].ToString() == "Agree")
                    {
                        ScoreTotal += 5;
                    }
                    else if (QuestionAnswer[i].ToString() == "Disagree")
                    {
                        ScoreTotal += 1;
                    }
                }
                
            }

            FinalResult(ScoreTotal);
        }

        /*
         * 
         * DETERMINE USER'S TYPE BASED ON SURVEY SCORE
         * 
         */ 
        private void FinalResult(int ScoreTotal)
        {
            if (ScoreTotal <23)
            {
                TypeResult = "TypeA";
            }
            else if (ScoreTotal > 23 && ScoreTotal < 36)
            {
                TypeResult = "TypeB";
            }
            else
            {
                TypeResult = "TypeC";
            }
        }

    }
}
