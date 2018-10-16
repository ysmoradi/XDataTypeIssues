using System.Collections.Generic;
using Xamarin.Forms;

namespace XDataTypeIssues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> Data { get; set; }
    }
}
