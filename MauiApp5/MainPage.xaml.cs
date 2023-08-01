namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ScrollView_OnScrolled(object sender, ScrolledEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("ScrollView_OnScrolled: ScrollX:" + e.ScrollX + "ScrollY:" + e.ScrollY);
        }
    }
}