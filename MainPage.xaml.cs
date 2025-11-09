namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Use the registered route name from AppShell.xaml.cs
            await Shell.Current.GoToAsync(nameof(MonitoringPage));

            // NOTE: If you wanted to go back to this page, you would use:
            // await Shell.Current.GoToAsync("..");
        }

       
    }
}

