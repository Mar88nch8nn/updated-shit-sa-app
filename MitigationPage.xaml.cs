namespace MauiApp1;

public partial class MitigationPage : ContentPage
{
    public MitigationPage()
    {
        InitializeComponent();
    }

          private async void OnMonitoringButtonClicked(object sender, EventArgs e)
    {
        // Logic for when the Prediction button is clicked
        await Shell.Current.GoToAsync(nameof(MonitoringPage));
        // You might navigate to a prediction-specific page or show prediction data.
    }

    private async void OnPredictionButtonClicked(object sender, EventArgs e)
    {
        // Logic for when the Mitigation button is clicked
        await Shell.Current.GoToAsync(nameof(PredictionPage));
        // You might navigate to a mitigation-specific page or show mitigation controls.
    }
}
