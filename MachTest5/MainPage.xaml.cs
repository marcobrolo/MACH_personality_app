﻿using System;
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
        private static int MaxQuestionsCount = 3;

        public MainPage()
        {
            QuestionCounter = 1;
            QuestionList.Add("Most people are honest.");
            QuestionList.Add("It is possible to be good in all respects.");
            QuestionList.Add("It is hard to get ahead without cutting corners here and there.");

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
        }

        private void Question3Click(object sender, RoutedEventArgs e)
        {
            QuestionCounter = 3;
            QuestionBox.Text = QuestionList[QuestionCounter-1];
        }

        private void NextQuestionButtonClick(object sender, RoutedEventArgs e)
        {
            if (QuestionCounter != MaxQuestionsCount)
            {
                QuestionCounter += 1;
                QuestionBox.Text = QuestionList[QuestionCounter-1];
            }
            else if (NextQuestionButton.Content == "FINISH")
            {
                //End survey
            }
            
        }

        private void LastQuestionVisualSetup()
        {
            NextQuestionButton.Content = "FINISH";
        }
    }
}
