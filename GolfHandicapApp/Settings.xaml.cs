﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace GolfHandicapApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            //switch all the switches to the saved settings
            if (Preferences.ContainsKey("SeparateHandicaps"))
            {
                SeparateHandicaps.IsToggled = Preferences.Get("Separatehandicaps", false);
            }
            if (Preferences.ContainsKey("DisplayEUDate"))
            {
                DisplayEUDate.IsToggled = Preferences.Get("DisplayEUDate", false);
            }
            if (Preferences.ContainsKey("HighlightScores"))
            {
                HighlightScores.IsToggled = Preferences.Get("HighlightScores", false);
            }
            if (Preferences.ContainsKey("DisplayAverageScore"))
            {
                DisplayAverageScore.IsToggled = Preferences.Get("DisplayAverageScore", false);
            }
        }
    }
}