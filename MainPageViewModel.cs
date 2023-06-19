using CommunityToolkit.Mvvm.ComponentModel;
namespace GenerateBarcode;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    string _stringText;
}
