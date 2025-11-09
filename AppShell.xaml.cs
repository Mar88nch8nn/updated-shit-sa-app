namespace MauiApp1
{// AppShell.xaml.cs
 // 1. Ensure you have the 'using' statement for where MonitoringPage lives
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // 2. The route name and the page type MUST match your MonitoringPage class name.
            Routing.RegisterRoute(nameof(MonitoringPage), typeof(MonitoringPage));

            //  NEW ROUTING: PredictionPage
            Routing.RegisterRoute(nameof(PredictionPage), typeof(PredictionPage));

            //  NEW ROUTING: MitigationPage
            Routing.RegisterRoute(nameof(MitigationPage), typeof(MitigationPage));
        }

    }
    }

