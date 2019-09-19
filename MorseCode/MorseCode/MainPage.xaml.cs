using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private string myMorse = "";
        private string myResult = "";
        private int spaceCount = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnDot_Clicked(object sender, EventArgs e)
        {
            myMorse += ".";
            AddText();
            spaceCount = 0;
        }

        private void BtnDash_Clicked(object sender, EventArgs e)
        {
            myMorse += "-";
            AddText();
            spaceCount = 0;
        }

        private void BtnSpace_Clicked(object sender, EventArgs e)
        {
            char morseResult;
            spaceCount++;
            if (spaceCount < 2)
            {
                morseResult = Morse.MorseCoder(myMorse);
                myResult += morseResult.ToString();
                lblResult.Text = myResult;
            }
            else
            {
                myMorse = "";
                morseResult = Morse.MorseCoder(myMorse);
                myResult += morseResult.ToString();
                lblResult.Text = myResult;
                spaceCount = 0;
            }
            lblInput.Text = "";
            myMorse = "";
        }

        public void AddText()
        {
           lblInput.Text = myMorse;
        }
    }
}
