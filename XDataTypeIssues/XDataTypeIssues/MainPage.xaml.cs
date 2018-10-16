using Xamarin.Forms;

namespace XDataTypeIssues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string SomeNullValue { get; set; }

        public SomeClass SomeNullInstance { get; set; }
    }

    public class SomeClass
    {
        public string SomeProperty { get; set; }
    }
}
