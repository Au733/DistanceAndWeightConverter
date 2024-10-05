using DistanceAndWeightConverter.Views;

namespace DistanceAndWeightConverter;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}