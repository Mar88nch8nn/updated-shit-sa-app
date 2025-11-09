namespace MauiApp1;

public partial class PredictionPage : ContentPage
{
    public PredictionPage()
    {
        InitializeComponent();
    }


          private async void OnMonitoringButtonClicked(object sender, EventArgs e)
    {
        // Logic for when the Prediction button is clicked
        await Shell.Current.GoToAsync(nameof(MonitoringPage));
        // You might navigate to a prediction-specific page or show prediction data.
    }

    private async void OnMitigationButtonClicked(object sender, EventArgs e)
    {
        // Logic for when the Mitigation button is clicked
        await Shell.Current.GoToAsync(nameof(MitigationPage));
        // You might navigate to a mitigation-specific page or show mitigation controls.
    }
}

